using System;
using System.Runtime.InteropServices;

namespace MscSpeak
{
    /// <summary>
    /// MSP状态通知回调函数
    /// </summary>
    /// <param name="type">类型</param>
    /// <param name="status">状态</param>
    /// <param name="param1">参数1</param>
    /// <param name="param2">参数2</param>
    /// <param name="userData">用户数据</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void MSPStatusNtfHandler(int type, int status, int param1, nint param2, nint userData);
}
