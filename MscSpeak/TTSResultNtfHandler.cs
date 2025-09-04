using System;
using System.Runtime.InteropServices;

namespace MscSpeak
{
    /// <summary>
    /// TTS结果通知回调函数
    /// </summary>
    /// <param name="sessionID">会话ID</param>
    /// <param name="audio">音频数据</param>
    /// <param name="audioLen">音频长度</param>
    /// <param name="synthStatus">合成状态</param>
    /// <param name="ced">相关参数</param>
    /// <param name="audioInfo">音频信息</param>
    /// <param name="audioInfoLen">音频信息长度</param>
    /// <param name="userData">用户数据</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void TTSResultNtfHandler(nint sessionID, nint audio, int audioLen, int synthStatus, int ced, nint audioInfo, int audioInfoLen, nint userData);
}
