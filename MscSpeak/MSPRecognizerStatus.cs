namespace MscSpeak
{
    /// <summary>
    /// 识别器状态枚举
    /// 包含识别操作的各种状态
    /// </summary>
    internal enum MSPRecognizerStatus
    {
        /// <summary>
        /// 识别成功，带有部分结果
        /// </summary>
        MSP_REC_STATUS_SUCCESS = 0,
        /// <summary>
        /// 识别被拒绝
        /// </summary>
        MSP_REC_STATUS_NO_MATCH = 1,
        /// <summary>
        /// 识别器需要更多时间计算结果
        /// </summary>
        MSP_REC_STATUS_INCOMPLETE = 2,
        /// <summary>
        /// 检测到非语音，已不再使用
        /// </summary>
        MSP_REC_STATUS_NON_SPEECH_DETECTED = 3,
        /// <summary>
        /// 识别器已检测到音频，这是延迟状态
        /// </summary>
        MSP_REC_STATUS_SPEECH_DETECTED = 4,
        /// <summary>
        /// 识别器已返回所有结果
        /// </summary>
        MSP_REC_STATUS_COMPLETE = 5,
        /// <summary>
        /// 超出CPU时间限制
        /// </summary>
        MSP_REC_STATUS_MAX_CPU_TIME = 6,
        /// <summary>
        /// 超出最大语音长度，可能返回部分结果
        /// </summary>
        MSP_REC_STATUS_MAX_SPEECH = 7,
        /// <summary>
        /// 识别已停止
        /// </summary>
        MSP_REC_STATUS_STOPPED = 8,
        /// <summary>
        /// 由于置信度低而被识别器拒绝
        /// </summary>
        MSP_REC_STATUS_REJECTED = 9,
        /// <summary>
        /// 识别器仍未找到任何音频，这是延迟状态
        /// </summary>
        MSP_REC_STATUS_NO_SPEECH_FOUND = 10,
        /// <summary>
        /// 识别失败（与MSP_REC_STATUS_NO_MATCH相同）
        /// </summary>
        MSP_REC_STATUS_FAILURE = MSP_REC_STATUS_NO_MATCH
    }
}
