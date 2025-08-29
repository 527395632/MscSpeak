namespace MscSpeak.Msc
{
    /// <summary>
    /// 合成过程标志枚举
    /// </summary>
    internal enum TSynthesisFlags
    {
        /// <summary>
        /// 仍有数据
        /// </summary>
        MSP_TTS_FLAG_STILL_HAVE_DATA = 1,
        /// <summary>
        /// 数据结束
        /// </summary>
        MSP_TTS_FLAG_DATA_END = 2,
        /// <summary>
        /// 命令已取消
        /// </summary>
        MSP_TTS_FLAG_CMD_CANCELED = 4
    }
}
