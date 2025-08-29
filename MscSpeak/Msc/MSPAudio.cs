using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace MscSpeak.Msc
{
    public abstract class MSPAudio : IDisposable
    {
        private IntPtr _hwd = IntPtr.Zero;

        static MSPAudio()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="appid">科大讯飞AppID</param>
        protected MSPAudio(string appid)
        {
            if (MSPNative.MSPLogin(null, null, $"appid={appid},work_dir=.") != MSPErrorCode.MSP_SUCCESS)
                throw new Exception("登录失败!");
        }

        /// <summary>
        /// 创建语音
        /// </summary>
        /// <param name="text">语音文字内容</param>
        /// <param name="speed">语音语速百分比</param>
        /// <param name="volume">音量大小 (0-100)</param>
        /// <param name="voiceName">发音人</param>
        /// <param name="rate">音频采样率</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected Stream Create(string text, byte speed = 100, byte volume = 100, string voiceName = "xiaoyan", uint rate = 16000)
        {
            lock (this)
            {
                speed = (byte)(50 / 100.0 * speed);
                volume = (byte)(volume < 0 ? 0 : volume > 100 ? 100 : volume);
                var stream = new MemoryStream();
                try
                {
                    _hwd = MSPNative.QTTSSessionBegin($"engine_type=local,voice_name={voiceName},text_encoding=GBK,tts_res_path=fo|{voiceName}.jet;fo|common.jet,sample_rate={rate},speed={speed},volume={volume},pitch=50,rdn=2,rcn=0", out var errorCode);
                    if (_hwd != IntPtr.Zero && errorCode == MSPErrorCode.MSP_SUCCESS)
                    {
                        uint textLen = (uint)Encoding.GetEncoding("GBK").GetByteCount(text);
                        if (MSPNative.QTTSTextPut(_hwd, text, textLen, "") == MSPErrorCode.MSP_SUCCESS)
                        {
                            uint audioLen;
                            TSynthesisFlags synthStatus = 0;
                            do
                            {
                                var audioData = MSPNative.QTTSAudioGet(_hwd, out audioLen, out synthStatus, out var getError);
                                if (getError != MSPErrorCode.MSP_SUCCESS)
                                {
                                    stream.Dispose();
                                    return null;
                                }
                                if (audioLen > 0 && audioData != nint.Zero)
                                {
                                    var buffer = new byte[audioLen];
                                    Marshal.Copy(audioData, buffer, 0, (int)audioLen);
                                    stream.Write(buffer, 0, (int)audioLen);
                                }
                            } while (synthStatus != TSynthesisFlags.MSP_TTS_FLAG_DATA_END);
                            stream.Position = 0;
                            stream.Write(new WavHeader
                            {
                                ChunkId = ['R', 'I', 'F', 'F'],
                                ChunkSize = (uint)(stream.Length + Marshal.SizeOf<WavHeader>() - 8),
                                Format = ['W', 'A', 'V', 'E'],
                                Subchunk1ID = ['f', 'm', 't', ' '],
                                Subchunk1Size = 16,
                                AudioFormat = 1,
                                NumChannels = 1,
                                SampleRate = rate,
                                ByteRate = rate * 2,
                                BlockAlign = 2,
                                BitsPerSample = 16,
                                Subchunk2Id = ['d', 'a', 't', 'a'],
                                Subchunk2Size = (uint)stream.Length
                            }.ToBytes(), 0, Marshal.SizeOf<WavHeader>());
                            stream.Position = 0;
                            return stream;
                        }
                    }
                }
                catch
                {
                    stream.Dispose();
                }
                finally
                {
                    Cleanup();
                }
                return null;
            }
        }

        protected void Cleanup()
        {
            lock (this)
            {
                if (_hwd != nint.Zero)
                    MSPNative.QTTSSessionEnd(_hwd, "合成完成");
            }
        }

        public virtual void Dispose()
        {
            Cleanup();
            MSPNative.MSPLogout();
        }
    }
}