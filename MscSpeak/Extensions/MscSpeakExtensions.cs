using System.Buffers.Binary;
using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Text;
using MscSpeak.Player.Linux;

namespace MscSpeak
{
    public static class MscSpeakExtensions
    {
        public static byte[] ToBytes<T>(this T source) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(source, ptr, false);

            var bytes = new byte[size];
            Marshal.Copy(ptr, bytes, 0, size);
            Marshal.FreeHGlobal(ptr);
            return bytes;
        }

        public static WavHeader? GetWavHeader(this Stream wavStream)
        {
            Span<byte> readBuffer2 = stackalloc byte[2];
            Span<byte> readBuffer4 = stackalloc byte[4];
            wavStream.Position = 0;
            try
            {
                var header = new WavHeader();

                wavStream.Read(readBuffer4);
                header.ChunkId = Encoding.ASCII.GetString(readBuffer4).ToCharArray();

                wavStream.Read(readBuffer4);
                header.ChunkSize = BinaryPrimitives.ReadUInt32LittleEndian(readBuffer4);

                wavStream.Read(readBuffer4);
                header.Format = Encoding.ASCII.GetString(readBuffer4).ToCharArray();

                wavStream.Read(readBuffer4);
                header.Subchunk1ID = Encoding.ASCII.GetString(readBuffer4).ToCharArray();

                wavStream.Read(readBuffer4);
                header.Subchunk1Size = BinaryPrimitives.ReadUInt32LittleEndian(readBuffer4);

                wavStream.Read(readBuffer2);
                header.AudioFormat = BinaryPrimitives.ReadUInt16LittleEndian(readBuffer2);

                wavStream.Read(readBuffer2);
                header.NumChannels = BinaryPrimitives.ReadUInt16LittleEndian(readBuffer2);

                wavStream.Read(readBuffer4);
                header.SampleRate = BinaryPrimitives.ReadUInt32LittleEndian(readBuffer4);

                wavStream.Read(readBuffer4);
                header.ByteRate = BinaryPrimitives.ReadUInt32LittleEndian(readBuffer4);

                wavStream.Read(readBuffer2);
                header.BlockAlign = BinaryPrimitives.ReadUInt16LittleEndian(readBuffer2);

                wavStream.Read(readBuffer2);
                header.BitsPerSample = BinaryPrimitives.ReadUInt16LittleEndian(readBuffer2);

                wavStream.Read(readBuffer4);
                header.Subchunk2Id = Encoding.ASCII.GetString(readBuffer4).ToCharArray();

                wavStream.Read(readBuffer4);
                header.Subchunk2Size = BinaryPrimitives.ReadUInt32LittleEndian(readBuffer4);

                return header;
            }
            catch
            { }
            return null;
        }


        public static void ThrowAsoundIFError(this int code, string message)
        {
            if (code < 0)
            {
                string errorMsg = Marshal.PtrToStringAnsi(AsoundNative.snd_strerror(code));
                throw new Exception($"{message}\nCode: {code}\nMessage: {errorMsg}.");
            }
        }
    }
}