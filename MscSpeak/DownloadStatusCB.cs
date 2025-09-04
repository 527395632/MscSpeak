using System;
using System.Runtime.InteropServices;

namespace MscSpeak
{
    /// <summary>
    /// 下载状态回调函数
    /// </summary>
    /// <param name="errorCode">错误代码</param>
    /// <param name="param1">参数1</param>
    /// <param name="param2">参数2</param>
    /// <param name="userData">用户数据</param>
    /// <returns>处理结果</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int DownloadStatusCB(int errorCode, long param1, nint param2, nint userData);
}
