using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MscSpeak.Msc
{
    internal static class MSPNative
    {
        /// <summary>
        /// 开始一个TTS会话
        /// 创建一个用于合成数据的TTS会话
        /// </summary>
        /// <param name="param">创建会话时的参数</param>
        /// <param name="errorCode">错误代码，成功时为0</param>
        /// <returns>成功时返回新会话ID，否则返回NULL和错误代码</returns>
        internal static IntPtr QTTSSessionBegin(string param, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSSessionBegin(param, out errorCode);
                }
                else
                {
                    return Windows86.QTTSSessionBegin(param, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSSessionBegin(param, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSSessionBegin(param, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSSessionBegin(param, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSSessionBegin(param, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 开始一个TTS会话（宽字符版本）
        /// 创建一个用于合成数据的TTS会话
        /// </summary>
        /// <param name="param">创建会话时的参数（宽字符）</param>
        /// <param name="errorCode">错误代码，成功时为0</param>
        /// <returns>成功时返回新会话ID，否则返回NULL和错误代码</returns>
        internal static IntPtr QTTSSessionBeginW(string param, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSSessionBeginW(param, out errorCode);
                }
                else
                {
                    return Windows86.QTTSSessionBeginW(param, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSSessionBeginW(param, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSSessionBeginW(param, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSSessionBeginW(param, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSSessionBeginW(param, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 向TTS会话输入文本缓冲区
        /// 将文本字符串写入合成器
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID</param>
        /// <param name="textString">文本缓冲区</param>
        /// <param name="textLen">文本字节大小</param>
        /// <param name="param">参数</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode QTTSTextPut(IntPtr sessionID, string textString, uint textLen, string param)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSTextPut(sessionID, textString, textLen, param);
                }
                else
                {
                    return Windows86.QTTSTextPut(sessionID, textString, textLen, param);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSTextPut(sessionID, textString, textLen, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSTextPut(sessionID, textString, textLen, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSTextPut(sessionID, textString, textLen, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSTextPut(sessionID, textString, textLen, param);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 向TTS会话输入文本缓冲区（宽字符版本）
        /// 将文本字符串写入合成器
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID（宽字符）</param>
        /// <param name="textString">文本缓冲区（宽字符）</param>
        /// <param name="textLen">文本字节大小</param>
        /// <param name="param">参数（宽字符）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode QTTSTextPutW(IntPtr sessionID, string textString, uint textLen, string param)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSTextPutW(sessionID, textString, textLen, param);
                }
                else
                {
                    return Windows86.QTTSTextPutW(sessionID, textString, textLen, param);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSTextPutW(sessionID, textString, textLen, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSTextPutW(sessionID, textString, textLen, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSTextPutW(sessionID, textString, textLen, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSTextPutW(sessionID, textString, textLen, param);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 将文本合成为音频
        /// 合成文本为音频，并返回音频信息
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID</param>
        /// <param name="audioLen">合成的音频字节大小（输出）</param>
        /// <param name="synthStatus">合成状态（输出）</param>
        /// <param name="errorCode">错误代码，成功时为0（输出）</param>
        /// <returns>当前合成的音频数据缓冲区，大小由QTTSTextSynth返回</returns>
        internal static IntPtr QTTSAudioGet(IntPtr sessionID, out uint audioLen, out TSynthesisFlags synthStatus, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSAudioGet(sessionID, out audioLen, out synthStatus, out errorCode);
                }
                else
                {
                    return Windows86.QTTSAudioGet(sessionID, out audioLen, out synthStatus, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSAudioGet(sessionID, out audioLen, out synthStatus, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSAudioGet(sessionID, out audioLen, out synthStatus, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSAudioGet(sessionID, out audioLen, out synthStatus, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSAudioGet(sessionID, out audioLen, out synthStatus, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 将文本合成为音频（宽字符版本）
        /// 合成文本为音频，并返回音频信息
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID（宽字符）</param>
        /// <param name="audioLen">合成的音频字节大小（输出）</param>
        /// <param name="synthStatus">合成状态（输出）</param>
        /// <param name="errorCode">错误代码，成功时为0（输出）</param>
        /// <returns>当前合成的音频数据缓冲区，大小由QTTSTextSynth返回</returns>
        internal static IntPtr QTTSAudioGetW(IntPtr sessionID, out uint audioLen, out int synthStatus, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSAudioGetW(sessionID, out audioLen, out synthStatus, out errorCode);
                }
                else
                {
                    return Windows86.QTTSAudioGetW(sessionID, out audioLen, out synthStatus, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSAudioGetW(sessionID, out audioLen, out synthStatus, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSAudioGetW(sessionID, out audioLen, out synthStatus, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSAudioGetW(sessionID, out audioLen, out synthStatus, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSAudioGetW(sessionID, out audioLen, out synthStatus, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 获取合成的音频信息
        /// 获取合成音频数据的信息
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID</param>
        /// <returns>返回音频信息字符串</returns>
        internal static IntPtr QTTSAudioInfo(IntPtr sessionID)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSAudioInfo(sessionID);
                }
                else
                {
                    return Windows86.QTTSAudioInfo(sessionID);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSAudioInfo(sessionID);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSAudioInfo(sessionID);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSAudioInfo(sessionID);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSAudioInfo(sessionID);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 获取合成的音频信息（宽字符版本）
        /// 获取合成音频数据的信息
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID（宽字符）</param>
        /// <returns>返回音频信息字符串（宽字符）</returns>
        internal static IntPtr QTTSAudioInfoW(IntPtr sessionID)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSAudioInfoW(sessionID);
                }
                else
                {
                    return Windows86.QTTSAudioInfoW(sessionID);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSAudioInfoW(sessionID);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSAudioInfoW(sessionID);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSAudioInfoW(sessionID);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSAudioInfoW(sessionID);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 结束识别器会话
        /// 结束识别器会话，释放所有资源
        /// </summary>
        /// <param name="sessionID">要结束的会话ID字符串</param>
        /// <param name="hints">结束会话的用户提示，提示将被记录到CallLog</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode QTTSSessionEnd(IntPtr sessionID, string hints)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSSessionEnd(sessionID, hints);
                }
                else
                {
                    return Windows86.QTTSSessionEnd(sessionID, hints);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSSessionEnd(sessionID, hints);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSSessionEnd(sessionID, hints);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSSessionEnd(sessionID, hints);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSSessionEnd(sessionID, hints);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 结束识别器会话（宽字符版本）
        /// 结束识别器会话，释放所有资源
        /// </summary>
        /// <param name="sessionID">要结束的会话ID字符串（宽字符）</param>
        /// <param name="hints">结束会话的用户提示（宽字符），提示将被记录到CallLog</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode QTTSSessionEndW(IntPtr sessionID, string hints)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSSessionEndW(sessionID, hints);
                }
                else
                {
                    return Windows86.QTTSSessionEndW(sessionID, hints);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSSessionEndW(sessionID, hints);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSSessionEndW(sessionID, hints);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSSessionEndW(sessionID, hints);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSSessionEndW(sessionID, hints);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 获取与MSC相关的参数
        /// 参数可以是本地或服务器参数，目前仅支持网络流量参数"upflow"和"downflow"
        /// </summary>
        /// <param name="sessionID">相关参数的会话ID，设置为NULL以获取全局参数</param>
        /// <param name="paramName">参数名称，可以传递多个参数，用','、';'或'\n'分隔</param>
        /// <param name="paramValue">参数值缓冲区，由用户分配</param>
        /// <param name="valueLen">输入值缓冲区的长度，并返回值字符串的长度（输入/输出）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode QTTSGetParam(IntPtr sessionID, string paramName, StringBuilder paramValue, ref uint valueLen)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSGetParam(sessionID, paramName, paramValue, ref valueLen);
                }
                else
                {
                    return Windows86.QTTSGetParam(sessionID, paramName, paramValue, ref valueLen);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSGetParam(sessionID, paramName, paramValue, ref valueLen);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSGetParam(sessionID, paramName, paramValue, ref valueLen);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSGetParam(sessionID, paramName, paramValue, ref valueLen);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSGetParam(sessionID, paramName, paramValue, ref valueLen);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 获取与MSC相关的参数（宽字符版本）
        /// 参数可以是本地或服务器参数，目前仅支持网络流量参数"upflow"和"downflow"
        /// </summary>
        /// <param name="sessionID">相关参数的会话ID（宽字符），设置为NULL以获取全局参数</param>
        /// <param name="paramName">参数名称（宽字符），可以传递多个参数，用','、';'或'\n'分隔</param>
        /// <param name="paramValue">参数值缓冲区（宽字符），由用户分配</param>
        /// <param name="valueLen">输入值缓冲区的长度，并返回值字符串的长度（输入/输出）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode QTTSGetParamW(IntPtr sessionID, string paramName, StringBuilder paramValue, ref uint valueLen)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSGetParamW(sessionID, paramName, paramValue, ref valueLen);
                }
                else
                {
                    return Windows86.QTTSGetParamW(sessionID, paramName, paramValue, ref valueLen);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSGetParamW(sessionID, paramName, paramValue, ref valueLen);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSGetParamW(sessionID, paramName, paramValue, ref valueLen);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSGetParamW(sessionID, paramName, paramValue, ref valueLen);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSGetParamW(sessionID, paramName, paramValue, ref valueLen);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 设置与MSC相关的参数
        /// 参数可以是本地或服务器参数，目前仅支持网络流量参数"upflow"和"downflow"
        /// </summary>
        /// <param name="sessionID">相关参数的会话ID，设置为NULL以设置全局参数</param>
        /// <param name="paramName">参数名称，可以传递多个参数，用','、';'或'\n'分隔</param>
        /// <param name="paramValue">参数值缓冲区，由用户分配</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode QTTSSetParam(IntPtr sessionID, string paramName, string paramValue)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSSetParam(sessionID, paramName, paramValue);
                }
                else
                {
                    return Windows86.QTTSSetParam(sessionID, paramName, paramValue);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSSetParam(sessionID, paramName, paramValue);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSSetParam(sessionID, paramName, paramValue);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSSetParam(sessionID, paramName, paramValue);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSSetParam(sessionID, paramName, paramValue);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 设置与MSC相关的参数（宽字符版本）
        /// 参数可以是本地或服务器参数，目前仅支持网络流量参数"upflow"和"downflow"
        /// </summary>
        /// <param name="sessionID">相关参数的会话ID（宽字符），设置为NULL以设置全局参数</param>
        /// <param name="paramName">参数名称（宽字符），可以传递多个参数，用','、';'或'\n'分隔</param>
        /// <param name="paramValue">参数值缓冲区（宽字符），由用户分配</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode QTTSSetParamW(IntPtr sessionID, string paramName, string paramValue)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.QTTSSetParamW(sessionID, paramName, paramValue);
                }
                else
                {
                    return Windows86.QTTSSetParamW(sessionID, paramName, paramValue);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.QTTSSetParamW(sessionID, paramName, paramValue);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.QTTSSetParamW(sessionID, paramName, paramValue);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.QTTSSetParamW(sessionID, paramName, paramValue);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.QTTSSetParamW(sessionID, paramName, paramValue);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 宽字符转多字节
        /// </summary>
        /// <param name="wcstr">以空结尾的源字符串（wchar_t *）</param>
        /// <returns>转换后的多字节字符串</returns>
        internal static IntPtr Wchar2Mbytes(string wcstr)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.Wchar2Mbytes(wcstr);
                }
                else
                {
                    return Windows86.Wchar2Mbytes(wcstr);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.Wchar2Mbytes(wcstr);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.Wchar2Mbytes(wcstr);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.Wchar2Mbytes(wcstr);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.Wchar2Mbytes(wcstr);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 多字节转宽字符
        /// </summary>
        /// <param name="mbstr">以空结尾的源字符串（char *）</param>
        /// <returns>转换后的宽字符字符串</returns>
        internal static IntPtr Mbytes2Wchar(string mbstr)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.Mbytes2Wchar(mbstr);
                }
                else
                {
                    return Windows86.Mbytes2Wchar(mbstr);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.Mbytes2Wchar(mbstr);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.Mbytes2Wchar(mbstr);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.Mbytes2Wchar(mbstr);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.Mbytes2Wchar(mbstr);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 用户登录接口
        /// 用于用户登录系统
        /// </summary>
        /// <param name="usr">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="param">用户登录时的参数</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPLogin(string usr, string pwd, string param)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPLogin(usr, pwd, param);
                }
                else
                {
                    return Windows86.MSPLogin(usr, pwd, param);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPLogin(usr, pwd, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPLogin(usr, pwd, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPLogin(usr, pwd, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPLogin(usr, pwd, param);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 用户登录接口（宽字符版本）
        /// 用于用户登录系统
        /// </summary>
        /// <param name="usr">用户名（宽字符）</param>
        /// <param name="pwd">密码（宽字符）</param>
        /// <param name="param">用户登录时的参数（宽字符）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPLoginW(string usr, string pwd, string param)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPLoginW(usr, pwd, param);
                }
                else
                {
                    return Windows86.MSPLoginW(usr, pwd, param);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPLoginW(usr, pwd, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPLoginW(usr, pwd, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPLoginW(usr, pwd, param);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPLoginW(usr, pwd, param);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 用户登出接口
        /// 用于用户登出系统
        /// </summary>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPLogout()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPLogout();
                }
                else
                {
                    return Windows86.MSPLogout();
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPLogout();
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPLogout();
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPLogout();
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPLogout();
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 用户登出接口（宽字符版本）
        /// 用于用户登出系统
        /// </summary>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPLogoutW()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPLogoutW();
                }
                else
                {
                    return Windows86.MSPLogoutW();
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPLogoutW();
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPLogoutW();
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPLogoutW();
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPLogoutW();
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 上传用户特定数据
        /// 上传诸如用户配置、自定义语法等数据
        /// </summary>
        /// <param name="dataName">数据名称，应唯一以区分其他数据</param>
        /// <param name="param">关于上传数据的参数</param>
        /// <param name="dataID">要操作的数据的ID</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPUpload(string dataName, string param, string dataID)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPUpload(dataName, param, dataID);
                }
                else
                {
                    return Windows86.MSPUpload(dataName, param, dataID);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPUpload(dataName, param, dataID);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPUpload(dataName, param, dataID);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPUpload(dataName, param, dataID);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPUpload(dataName, param, dataID);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 下载用户特定数据
        /// 下载诸如用户配置等数据
        /// </summary>
        /// <param name="dataName">数据名称</param>
        /// <param name="param">关于要下载的数据的参数</param>
        /// <param name="statusCb">状态回调函数</param>
        /// <param name="resultCb">结果回调函数</param>
        /// <param name="userData">用户数据</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPDownload(string dataName, string param, DownloadStatusCB statusCb, DownloadResultCB resultCb, IntPtr userData)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPDownload(dataName, param, statusCb, resultCb, userData);
                }
                else
                {
                    return Windows86.MSPDownload(dataName, param, statusCb, resultCb, userData);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPDownload(dataName, param, statusCb, resultCb, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPDownload(dataName, param, statusCb, resultCb, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPDownload(dataName, param, statusCb, resultCb, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPDownload(dataName, param, statusCb, resultCb, userData);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 下载用户特定数据（宽字符版本）
        /// 下载诸如用户配置等数据
        /// </summary>
        /// <param name="dataName">数据名称（宽字符）</param>
        /// <param name="param">关于要下载的数据的参数（宽字符）</param>
        /// <param name="statusCb">状态回调函数</param>
        /// <param name="resultCb">结果回调函数</param>
        /// <param name="userData">用户数据</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPDownloadW(string dataName, string param, DownloadStatusCB statusCb, DownloadResultCB resultCb, IntPtr userData)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPDownloadW(dataName, param, statusCb, resultCb, userData);
                }
                else
                {
                    return Windows86.MSPDownloadW(dataName, param, statusCb, resultCb, userData);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPDownloadW(dataName, param, statusCb, resultCb, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPDownloadW(dataName, param, statusCb, resultCb, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPDownloadW(dataName, param, statusCb, resultCb, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPDownloadW(dataName, param, statusCb, resultCb, userData);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 追加数据
        /// 向MSC写入数据，如要上传的数据、搜索文本等
        /// </summary>
        /// <param name="data">数据缓冲区指针，数据可以是二进制</param>
        /// <param name="dataLen">数据长度</param>
        /// <param name="dataStatus">数据状态，2: 首次或连续，4: 最后</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPAppendData(IntPtr data, uint dataLen, uint dataStatus)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPAppendData(data, dataLen, dataStatus);
                }
                else
                {
                    return Windows86.MSPAppendData(data, dataLen, dataStatus);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPAppendData(data, dataLen, dataStatus);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPAppendData(data, dataLen, dataStatus);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPAppendData(data, dataLen, dataStatus);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPAppendData(data, dataLen, dataStatus);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 获取结果
        /// 获取上传、下载或搜索等操作的结果
        /// </summary>
        /// <param name="rsltLen">返回结果的长度（输出）</param>
        /// <param name="rsltStatus">返回结果的状态（输出）</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>上传、下载或搜索等操作的结果</returns>
        internal static IntPtr MSPGetResult(out uint rsltLen, out int rsltStatus, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPGetResult(out rsltLen, out rsltStatus, out errorCode);
                }
                else
                {
                    return Windows86.MSPGetResult(out rsltLen, out rsltStatus, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPGetResult(out rsltLen, out rsltStatus, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPGetResult(out rsltLen, out rsltStatus, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPGetResult(out rsltLen, out rsltStatus, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPGetResult(out rsltLen, out rsltStatus, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 设置MSC的参数
        /// 设置MSC的相关参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="paramValue">参数值</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPSetParam(string paramName, string paramValue)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPSetParam(paramName, paramValue);
                }
                else
                {
                    return Windows86.MSPSetParam(paramName, paramValue);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPSetParam(paramName, paramValue);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPSetParam(paramName, paramValue);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPSetParam(paramName, paramValue);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPSetParam(paramName, paramValue);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 获取MSC的参数
        /// 获取MSC的相关参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="paramValue">参数值（输出）</param>
        /// <param name="valueLen">参数值（缓冲区）长度（输入/输出）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        internal static MSPErrorCode MSPGetParam(string paramName, StringBuilder paramValue, ref uint valueLen)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPGetParam(paramName, paramValue, ref valueLen);
                }
                else
                {
                    return Windows86.MSPGetParam(paramName, paramValue, ref valueLen);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPGetParam(paramName, paramValue, ref valueLen);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPGetParam(paramName, paramValue, ref valueLen);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPGetParam(paramName, paramValue, ref valueLen);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPGetParam(paramName, paramValue, ref valueLen);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 上传用户特定数据
        /// 上传诸如用户配置、自定义语法等数据
        /// </summary>
        /// <param name="dataName">数据名称，应唯一以区分其他数据</param>
        /// <param name="data">数据缓冲区指针，数据可以是二进制</param>
        /// <param name="dataLen">数据长度</param>
        /// <param name="param">关于上传数据的参数</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>服务器返回的数据ID，用于特殊命令</returns>
        internal static IntPtr MSPUploadData(string dataName, IntPtr data, uint dataLen, string param, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPUploadData(dataName, data, dataLen, param, out errorCode);
                }
                else
                {
                    return Windows86.MSPUploadData(dataName, data, dataLen, param, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPUploadData(dataName, data, dataLen, param, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPUploadData(dataName, data, dataLen, param, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPUploadData(dataName, data, dataLen, param, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPUploadData(dataName, data, dataLen, param, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 下载用户特定数据
        /// 下载诸如用户配置等数据
        /// </summary>
        /// <param name="param">关于要下载的数据的参数</param>
        /// <param name="dataLen">接收数据的长度（输出）</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>接收数据的缓冲区指针，数据可以是二进制，失败或数据不存在时为NULL</returns>
        internal static IntPtr MSPDownloadData(string param, out uint dataLen, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPDownloadData(param, out dataLen, out errorCode);
                }
                else
                {
                    return Windows86.MSPDownloadData(param, out dataLen, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPDownloadData(param, out dataLen, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPDownloadData(param, out dataLen, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPDownloadData(param, out dataLen, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPDownloadData(param, out dataLen, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 下载用户特定数据（宽字符版本）
        /// 下载诸如用户配置等数据
        /// </summary>
        /// <param name="param">关于要下载的数据的参数（宽字符）</param>
        /// <param name="dataLen">接收数据的长度（输出）</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>接收数据的缓冲区指针，数据可以是二进制，失败或数据不存在时为NULL</returns>
        internal static IntPtr MSPDownloadDataW(string param, out uint dataLen, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPDownloadDataW(param, out dataLen, out errorCode);
                }
                else
                {
                    return Windows86.MSPDownloadDataW(param, out dataLen, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPDownloadDataW(param, out dataLen, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPDownloadDataW(param, out dataLen, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPDownloadDataW(param, out dataLen, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPDownloadDataW(param, out dataLen, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 搜索文本以获取结果
        /// 搜索文本内容，并获取文本结果
        /// </summary>
        /// <param name="param">关于要下载的数据的参数</param>
        /// <param name="text">文本内容</param>
        /// <param name="dataLen">接收数据的长度（输出）</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>接收数据的缓冲区指针，数据可以是二进制，失败或数据不存在时为NULL</returns>
        internal static IntPtr MSPSearch(string param, string text, out uint dataLen, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPSearch(param, text, out dataLen, out errorCode);
                }
                else
                {
                    return Windows86.MSPSearch(param, text, out dataLen, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPSearch(param, text, out dataLen, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPSearch(param, text, out dataLen, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPSearch(param, text, out dataLen, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPSearch(param, text, out dataLen, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// NLP搜索
        /// </summary>
        /// <param name="param">参数</param>
        /// <param name="text">文本</param>
        /// <param name="textLen">文本长度</param>
        /// <param name="errorCode">错误代码（输出）</param>
        /// <param name="callback">回调函数</param>
        /// <param name="userData">用户数据</param>
        /// <returns>会话ID</returns>
        internal static IntPtr MSPNlpSearch(string param, string text, uint textLen, out MSPErrorCode errorCode, NLPSearchCB callback, IntPtr userData)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPNlpSearch(param, text, textLen, out errorCode, callback, userData);
                }
                else
                {
                    return Windows86.MSPNlpSearch(param, text, textLen, out errorCode, callback, userData);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPNlpSearch(param, text, textLen, out errorCode, callback, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPNlpSearch(param, text, textLen, out errorCode, callback, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPNlpSearch(param, text, textLen, out errorCode, callback, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPNlpSearch(param, text, textLen, out errorCode, callback, userData);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 取消NLP搜索
        /// </summary>
        /// <param name="sessionID">会话ID</param>
        /// <param name="hints">提示信息</param>
        /// <returns>处理结果</returns>
        internal static MSPErrorCode MSPNlpSchCancel(IntPtr sessionID, string hints)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPNlpSchCancel(sessionID, hints);
                }
                else
                {
                    return Windows86.MSPNlpSchCancel(sessionID, hints);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPNlpSchCancel(sessionID, hints);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPNlpSchCancel(sessionID, hints);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPNlpSchCancel(sessionID, hints);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPNlpSchCancel(sessionID, hints);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 注册回调函数
        /// 注册一个回调函数用于接收通知
        /// </summary>
        /// <param name="statusCb">通知处理函数</param>
        /// <param name="userData">用户数据</param>
        /// <returns>处理结果</returns>
        internal static IntPtr MSPRegisterNotify(MSPStatusNtfHandler statusCb, IntPtr userData)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPRegisterNotify(statusCb, userData);
                }
                else
                {
                    return Windows86.MSPRegisterNotify(statusCb, userData);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPRegisterNotify(statusCb, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPRegisterNotify(statusCb, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPRegisterNotify(statusCb, userData);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPRegisterNotify(statusCb, userData);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }

        /// <summary>
        /// 获取MSC或本地引擎的版本
        /// 获取MSC或本地引擎的版本信息
        /// </summary>
        /// <param name="verName">版本名称，可以是"msc"、"aitalk"、"aisound"、"ivw"</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>成功时返回版本值，失败时返回NULL</returns>
        internal static IntPtr MSPGetVersion(string verName, out MSPErrorCode errorCode)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                if (IntPtr.Size == 8)
                {
                    return Windows64.MSPGetVersion(verName, out errorCode);
                }
                else
                {
                    return Windows86.MSPGetVersion(verName, out errorCode);
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
                {
                    return Linux86.MSPGetVersion(verName, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
                {
                    return Linux64.MSPGetVersion(verName, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm)
                {
                    return LinuxArm86.MSPGetVersion(verName, out errorCode);
                }
                else if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                {
                    return LinuxArm64.MSPGetVersion(verName, out errorCode);
                }
            }
            throw new NotSupportedException("当前系统还不支持!");
        }
    }
}
