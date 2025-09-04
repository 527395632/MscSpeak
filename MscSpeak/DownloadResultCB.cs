using System;
using System.Runtime.InteropServices;

namespace MscSpeak
{
    /// <summary>
    /// 下载结果回调函数
    /// </summary>
    /// <param name="data">数据</param>
    /// <param name="dataLen">数据长度</param>
    /// <param name="userData">用户数据</param>
    /// <returns>处理结果</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int DownloadResultCB(nint data, long dataLen, nint userData);
}
