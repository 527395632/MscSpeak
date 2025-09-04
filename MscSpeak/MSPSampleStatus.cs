namespace MscSpeak
{
    /// <summary>
    /// 音频样本状态枚举
    /// 指示样本缓冲区应如何处理
    /// </summary>
    internal enum MSPSampleStatus
    {
        /// <summary>
        /// 初始状态
        /// </summary>
        MSP_AUDIO_SAMPLE_INIT = 0x00,
        /// <summary>
        /// 样本缓冲区是音频的开始
        /// 如果识别器已经在识别，它将丢弃迄今为止收到的音频并重新开始识别
        /// </summary>
        MSP_AUDIO_SAMPLE_FIRST = 0x01,
        /// <summary>
        /// 样本缓冲区是连续的音频
        /// </summary>
        MSP_AUDIO_SAMPLE_CONTINUE = 0x02,
        /// <summary>
        /// 样本缓冲区是音频的结尾
        /// 识别器将停止处理音频并返回结果
        /// </summary>
        MSP_AUDIO_SAMPLE_LAST = 0x04
    }
}
