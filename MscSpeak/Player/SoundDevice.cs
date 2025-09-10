using System;
using System.IO;

namespace MscSpeak.Player
{
    public abstract partial class SoundDevice : IDisposable
    {
        /// <summary>
        /// 播放 WAV 音频
        /// </summary>
        public abstract void Play(Stream wavStream);

        /// <summary>
        /// 停止播放。
        /// </summary>
        public abstract void Stop();

        #region IDisposable
        ~SoundDevice() => Dispose();
        public virtual void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}