using System.Runtime.InteropServices;

namespace MscSpeak.Player
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WaveFormat
    {
        public ushort Tag;
        public ushort Channels;
        public uint SamplesPerSec;
        public uint AvgBytesPerSec;
        public ushort BlockAlign;
        public ushort BitsPerSample;
        public ushort Size;

        public WaveFormat(int sampleRate, int bitsPerSample, int channels)
        {
            Tag = 1;
            Channels = (ushort)channels;
            SamplesPerSec = (uint)sampleRate;
            BitsPerSample = (ushort)bitsPerSample;
            BlockAlign = (ushort)(Channels * BitsPerSample / 8);
            AvgBytesPerSec = SamplesPerSec * BlockAlign;
            Size = 0;
        }
    }
}
