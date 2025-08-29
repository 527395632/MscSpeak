using MscSpeak.Player.Linux;
using System;
using System.IO;

namespace MscSpeak.Player
{
    public sealed class LinuxDevice : SoundDevice
    {
        private IntPtr _playbackPcm;
        private IntPtr _mixer;
        private IntPtr _elem;
        private static readonly object _mixerLock = new object();

        public unsafe override void Play(Stream wavStream)
        {
            if (wavStream.GetWavHeader() is WavHeader header)
            {
                var param = IntPtr.Zero;
                int dir = 0;
                try
                {
                    OpenPcm();
                    InitializePcm(_playbackPcm, header, ref param, ref dir);
                    WritePcm(wavStream, header, ref param, ref dir);
                }
                finally
                {
                    Stop();
                }
            }
        }

        public override void Stop()
        {
            if (_playbackPcm != default)
            {
                AsoundNative.snd_pcm_drop(_playbackPcm).ThrowAsoundIFError("停止播放设备!");
                AsoundNative.snd_pcm_close(_playbackPcm).ThrowAsoundIFError("关闭播放设备!");
                _playbackPcm = default;
            }
        }

        private void OpenPcm()
        {
            if (_playbackPcm != default)
            {
                return;
            }

            lock (this)
            {
                AsoundNative.snd_pcm_open(ref _playbackPcm, "default", snd_pcm_stream_t.SND_PCM_STREAM_PLAYBACK, 0).ThrowAsoundIFError("无法打开播放设备!");
            }
        }

        private unsafe void InitializePcm(IntPtr pcm, WavHeader header, ref IntPtr param, ref int dir)
        {
            AsoundNative.snd_pcm_hw_params_malloc(ref param).ThrowAsoundIFError("无法分配参数对象!");
            AsoundNative.snd_pcm_hw_params_any(pcm, param).ThrowAsoundIFError("无法填充参数对象!");
            AsoundNative.snd_pcm_hw_params_set_access(pcm, param, snd_pcm_access_t.SND_PCM_ACCESS_RW_INTERLEAVED).ThrowAsoundIFError("无法设置访问模式!");
            ((int)(header.BitsPerSample / 8) switch
            {
                1 => AsoundNative.snd_pcm_hw_params_set_format(pcm, param, snd_pcm_format_t.SND_PCM_FORMAT_U8),
                2 => AsoundNative.snd_pcm_hw_params_set_format(pcm, param, snd_pcm_format_t.SND_PCM_FORMAT_S16_LE),
                3 => AsoundNative.snd_pcm_hw_params_set_format(pcm, param, snd_pcm_format_t.SND_PCM_FORMAT_S24_LE),
                _ => throw new Exception("采样位数错误!"),
            }).ThrowAsoundIFError("无法设置格式!");
            AsoundNative.snd_pcm_hw_params_set_channels(pcm, param, header.NumChannels).ThrowAsoundIFError("无法设置声道!");
            uint val = header.SampleRate;
            fixed (int* dirP = &dir)
            {
                AsoundNative.snd_pcm_hw_params_set_rate_near(pcm, param, &val, dirP).ThrowAsoundIFError("无法设置采样率!");
            }
            AsoundNative.snd_pcm_hw_params(pcm, param).ThrowAsoundIFError("无法设置硬件参数!");
        }

        private unsafe void WritePcm(Stream wavStream, WavHeader header, ref IntPtr param, ref int dir)
        {
            ulong frames, bufferSize;

            fixed (int* dirP = &dir)
            {
                AsoundNative.snd_pcm_hw_params_get_period_size(param, &frames, dirP).ThrowAsoundIFError("无法获取周期大小!");
            }

            bufferSize = frames * header.BlockAlign;
            byte[] readBuffer = new byte[(int)bufferSize];
            wavStream.Position = 44;

            fixed (byte* buffer = readBuffer)
                while (wavStream.Read(readBuffer) != 0)
                {
                    AsoundNative.snd_pcm_writei(_playbackPcm, (IntPtr)buffer, frames).ThrowAsoundIFError("无法向设备写入数据!");
                }
        }

        public unsafe long Volume
        {
            get
            {
                long volumeLeft, volumeRight;

                OpenMixer();

                AsoundNative.snd_mixer_selem_get_playback_volume(_elem, snd_mixer_selem_channel_id.SND_MIXER_SCHN_FRONT_LEFT, &volumeLeft);
                AsoundNative.snd_mixer_selem_get_playback_volume(_elem, snd_mixer_selem_channel_id.SND_MIXER_SCHN_FRONT_RIGHT, &volumeRight).ThrowAsoundIFError("获取播放音量错误!");

                CloseMixer();

                return (volumeLeft + volumeRight) / 2;
            }
            set
            {
                OpenMixer();

                AsoundNative.snd_mixer_selem_set_playback_volume(_elem, snd_mixer_selem_channel_id.SND_MIXER_SCHN_FRONT_LEFT, value);
                AsoundNative.snd_mixer_selem_set_playback_volume(_elem, snd_mixer_selem_channel_id.SND_MIXER_SCHN_FRONT_RIGHT, value).ThrowAsoundIFError("设置播放音量错误!");

                CloseMixer();
            }
        }

        private void OpenMixer()
        {
            if (_mixer != default)
            {
                return;
            }

            lock (_mixerLock)
            {
                AsoundNative.snd_mixer_open(ref _mixer, 0).ThrowAsoundIFError("无法打开音频设备混音器!");

                AsoundNative.snd_mixer_attach(_mixer, "default").ThrowAsoundIFError("无法连接音频设备混音器!");

                AsoundNative.snd_mixer_selem_register(_mixer, IntPtr.Zero, IntPtr.Zero).ThrowAsoundIFError("无法注册音频设备混音器!");

                AsoundNative.snd_mixer_load(_mixer).ThrowAsoundIFError("无法加载音频设备混音器!");

                _elem = AsoundNative.snd_mixer_first_elem(_mixer);
            }
        }

        private void CloseMixer()
        {
            if (_mixer != default)
            {
                AsoundNative.snd_mixer_close(_mixer).ThrowAsoundIFError("关闭音频设备混音器错误!");

                _mixer = default;
                _elem = default;
            }
        }
    }
}