using MscSpeak.Player.Linux;
using System;
using System.Diagnostics;
using System.IO;

namespace MscSpeak.Player
{
    public sealed class LinuxFileDevice : SoundDevice
    {
        private Process _p;


        public override void Play(Stream wavStream)
        {
            if (wavStream.Length > 0)
            {
                try
                {
                    string tempFilePath = Path.Combine(AppContext.BaseDirectory, "temp.wav");
                    using (var memoryStream = (MemoryStream)wavStream)
                    {
                        File.WriteAllBytes(tempFilePath, memoryStream.ToArray());
                    }
                    var _p = Process.Start(new ProcessStartInfo
                    {
                        FileName = "aplay",
                        Arguments = $"\"{tempFilePath}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = false,
                        RedirectStandardError = false,
                        CreateNoWindow = true
                    });
                    _p.WaitForExit();
                }
                finally
                {
                    Stop();
                }
            }
        }

        public override void Stop()
        {
            _p?.Dispose();
            _p = null;
        }
    }
}