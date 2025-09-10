using System;
using System.Runtime.InteropServices;

namespace MscSpeak.Player
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WaveInfo
    {
        public IntPtr Data;
        public int BufferLength;
        public int BytesRecorded;
        public IntPtr User;
        public int Flags;
        public int Loops;
        public IntPtr Next;
        public IntPtr reserved;

        public const uint WHDR_DONE = 0x00000001;
    }
}
