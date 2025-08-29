using System.Runtime.InteropServices;

namespace MscSpeak
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct WavHeader
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] ChunkId;

        public uint ChunkSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] Format;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] Subchunk1ID;

        public uint Subchunk1Size;

        public ushort AudioFormat;

        public ushort NumChannels;

        public uint SampleRate;

        public uint ByteRate;

        public ushort BlockAlign;

        public ushort BitsPerSample;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] Subchunk2Id;

        public uint Subchunk2Size;
    }
}