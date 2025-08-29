using System.Runtime.InteropServices;

namespace MscSpeak
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct WavHeader
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        internal char[] ChunkId;

        internal uint ChunkSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        internal char[] Format;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        internal char[] Subchunk1ID;

        internal uint Subchunk1Size;

        internal ushort AudioFormat;

        internal ushort NumChannels;

        internal uint SampleRate;

        internal uint ByteRate;

        internal ushort BlockAlign;

        internal ushort BitsPerSample;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        internal char[] Subchunk2Id;

        internal uint Subchunk2Size;
    }
}