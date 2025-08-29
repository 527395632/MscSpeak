namespace MscSpeak.Msc
{
    /// <summary>
    /// 端点检测器状态枚举
    /// 包含当前端点检测器的状态
    /// </summary>
    internal enum MSPepState
    {
        /// <summary>
        /// 尚未找到语音的开始
        /// </summary>
        MSP_EP_LOOKING_FOR_SPEECH = 0,
        /// <summary>
        /// 已找到语音的开始，但未找到结束
        /// </summary>
        MSP_EP_IN_SPEECH = 1,
        /// <summary>
        /// 已找到语音的开始和结束
        /// </summary>
        MSP_EP_AFTER_SPEECH = 3,
        /// <summary>
        /// 超时前未找到任何音频
        /// </summary>
        MSP_EP_TIMEOUT = 4,
        /// <summary>
        /// 端点检测器遇到严重错误
        /// </summary>
        MSP_EP_ERROR = 5,
        /// <summary>
        /// 已达到最大语音大小
        /// </summary>
        MSP_EP_MAX_SPEECH = 6,
        /// <summary>
        /// 内部状态：停止后、开始前
        /// </summary>
        MSP_EP_IDLE = 7
    }
}
