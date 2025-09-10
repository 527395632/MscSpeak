using System;
using System.Runtime.InteropServices;

namespace MscSpeak.Player
{
    internal class WinmmNative
    {
        [DllImport("winmm.dll", SetLastError = true, EntryPoint = "waveOutOpen", CallingConvention = CallingConvention.Winapi)]
        internal static extern int WaveOutOpen(out IntPtr hWaveOut, int uDeviceID, ref WaveFormat lpFormat, IntPtr lpCallback, IntPtr dwInstance, uint dwFlags);

        [DllImport("winmm", EntryPoint = "waveOutPrepareHeader")]
        internal static extern int WaveOutPrepareHeader(nint hWaveOut, ref WaveInfo lpWaveHeader, int uSize);

        [DllImport("winmm", EntryPoint = "waveOutWrite")]
        internal static extern int WaveOutWrite(nint hWaveOut, ref WaveInfo lpWaveHeader, int uSize);

        [DllImport("winmm", EntryPoint = "waveOutClose")]
        internal static extern int WaveOutClose(nint hWaveOut);

        [DllImport("winmm", EntryPoint = "waveOutUnprepareHeader")]
        internal static extern int WaveOutUnprepareHeader(nint hWaveOut, ref WaveInfo lpWaveHeader, int uSize);

        [DllImport("winmm", EntryPoint = "waveOutGetPosition")]
        internal static extern int WaveOutGetPosition(nint hWaveOut, ref MMTIME lpmmt, int uSize);

        [DllImport("winmm", EntryPoint = "waveOutReset")]
        internal static extern int WaveOutReset(nint hWaveOut);
    }
}