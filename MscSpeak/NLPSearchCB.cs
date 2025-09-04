using System;
using System.Runtime.InteropServices;

namespace MscSpeak
{
    /// <summary>
    /// NLP搜索回调函数
    /// </summary>
    /// <param name="sessionID">会话ID</param>
    /// <param name="errorCode">错误代码</param>
    /// <param name="status">状态</param>
    /// <param name="result">结果</param>
    /// <param name="rsltLen">结果长度</param>
    /// <param name="userData">用户数据</param>
    /// <returns>处理结果</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int NLPSearchCB(nint sessionID, int errorCode, int status, nint result, long rsltLen, nint userData);
}
