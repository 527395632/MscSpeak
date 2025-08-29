using MscSpeak.Msc;
using MscSpeak.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MscSpeak
{
    public class TextSpeak : MSPAudio
    {
        private SoundDevice _soundDevice = null;
        private EventWaitHandle _playWait = null;

        public TextSpeak(string appid) : base(appid)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                _soundDevice = new WindowsDevice();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                _soundDevice = new LinuxDevice();
            }
            else
            {
                throw new NotSupportedException($"暂不支持该平台!");
            }
        }

        public void Speak(string text, byte speed = 100, byte volume = 100, string voiceName = "xiaoyan", uint rate = 16000)
        {
            Stop();
            _playWait = new AutoResetEvent(false);
            try
            {

                using (var stream = Create(text, speed, volume, voiceName, rate))
                {
                    if (stream?.Length > 44)
                    {
                        _soundDevice.Play(stream);
                    }
                }
            }
            finally
            {
                _playWait.Set();
            }
        }

        public void Stop()
        {
            base.Cleanup();
            _soundDevice?.Stop();
            _playWait?.WaitOne();
        }

        public override void Dispose()
        {
            Stop();
            _soundDevice.Dispose();
            base.Dispose();
        }
    }
}