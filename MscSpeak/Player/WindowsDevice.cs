using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace MscSpeak.Player
{
    public sealed class WindowsDevice : SoundDevice
    {
        private IntPtr _hwd = IntPtr.Zero;
        private WaveInfo _dataHwd = new WaveInfo();

        bool IsPlayed => (_dataHwd.Flags & WaveInfo.WHDR_DONE) == WaveInfo.WHDR_DONE;

        public override void Play(Stream wavStream)
        {
            if (_hwd != IntPtr.Zero && !IsPlayed)
            {
                Stop();
            }
            lock (this)
            {
                try
                {
                    if (wavStream.GetWavHeader() is WavHeader header)
                    {
                        if (WinmmNative.WaveOutOpen(out _hwd, -1, new WaveFormat((int)header.SampleRate, header.BitsPerSample, header.NumChannels), IntPtr.Zero, IntPtr.Zero, 0) == 0)
                        {
                            var wavBuffer = new byte[wavStream.Length - Marshal.SizeOf<WavHeader>()];
                            wavStream.Read(wavBuffer, 0, wavBuffer.Length);
                            _dataHwd.BufferLength = wavBuffer.Length;
                            _dataHwd.Data = Marshal.AllocHGlobal(wavBuffer.Length);
                            Marshal.Copy(wavBuffer, 0, _dataHwd.Data, wavBuffer.Length);
                            var headerSize = Marshal.SizeOf(_dataHwd);
                            if (WinmmNative.WaveOutPrepareHeader(_hwd, ref _dataHwd, headerSize) == 0)
                            {
                                if (WinmmNative.WaveOutWrite(_hwd, ref _dataHwd, headerSize) == 0)
                                {
                                    while (!IsPlayed) Thread.Sleep(50);
                                }
                            }
                        }
                    }
                }
                finally
                {
                    if (_hwd != IntPtr.Zero)
                    {
                        if (_dataHwd.Data != IntPtr.Zero)
                            WinmmNative.WaveOutUnprepareHeader(_hwd, ref _dataHwd, Marshal.SizeOf(_dataHwd));
                        WinmmNative.WaveOutClose(_hwd);
                        _hwd = IntPtr.Zero;
                    }
                    Marshal.FreeHGlobal(_dataHwd.Data);
                    _dataHwd.BufferLength = 0;
                    _dataHwd.Data = IntPtr.Zero;
                }
            }
        }

        public override void Stop()
        {
            if (_hwd != IntPtr.Zero)
            {
                WinmmNative.WaveOutReset(_hwd);
                while (!IsPlayed) Thread.Sleep(50);
            }
        }
    }
}