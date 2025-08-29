using System.Runtime.InteropServices;
using System.Text;

namespace MscSpeak.Msc
{
    internal static class Linux64
    {
        /// <summary>
        /// 开始一个TTS会话
        /// 创建一个用于合成数据的TTS会话
        /// </summary>
        /// <param name="param">创建会话时的参数</param>
        /// <param name="errorCode">错误代码，成功时为0</param>
        /// <returns>成功时返回新会话ID，否则返回NULL和错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern nint QTTSSessionBegin(string param, out MSPErrorCode errorCode);

        /// <summary>
        /// 开始一个TTS会话（宽字符版本）
        /// 创建一个用于合成数据的TTS会话
        /// </summary>
        /// <param name="param">创建会话时的参数（宽字符）</param>
        /// <param name="errorCode">错误代码，成功时为0</param>
        /// <returns>成功时返回新会话ID，否则返回NULL和错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern nint QTTSSessionBeginW(string param, out MSPErrorCode errorCode);

        /// <summary>
        /// 向TTS会话输入文本缓冲区
        /// 将文本字符串写入合成器
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID</param>
        /// <param name="textString">文本缓冲区</param>
        /// <param name="textLen">文本字节大小</param>
        /// <param name="param">参数</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode QTTSTextPut(nint sessionID, string textString, uint textLen, string param);

        /// <summary>
        /// 向TTS会话输入文本缓冲区（宽字符版本）
        /// 将文本字符串写入合成器
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID（宽字符）</param>
        /// <param name="textString">文本缓冲区（宽字符）</param>
        /// <param name="textLen">文本字节大小</param>
        /// <param name="param">参数（宽字符）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern MSPErrorCode QTTSTextPutW(nint sessionID, string textString, uint textLen, string param);

        /// <summary>
        /// 将文本合成为音频
        /// 合成文本为音频，并返回音频信息
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID</param>
        /// <param name="audioLen">合成的音频字节大小（输出）</param>
        /// <param name="synthStatus">合成状态（输出）</param>
        /// <param name="errorCode">错误代码，成功时为0（输出）</param>
        /// <returns>当前合成的音频数据缓冲区，大小由QTTSTextSynth返回</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern nint QTTSAudioGet(nint sessionID, out uint audioLen, out TSynthesisFlags synthStatus, out MSPErrorCode errorCode);

        /// <summary>
        /// 将文本合成为音频（宽字符版本）
        /// 合成文本为音频，并返回音频信息
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID（宽字符）</param>
        /// <param name="audioLen">合成的音频字节大小（输出）</param>
        /// <param name="synthStatus">合成状态（输出）</param>
        /// <param name="errorCode">错误代码，成功时为0（输出）</param>
        /// <returns>当前合成的音频数据缓冲区，大小由QTTSTextSynth返回</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern nint QTTSAudioGetW(nint sessionID, out uint audioLen, out int synthStatus, out MSPErrorCode errorCode);

        /// <summary>
        /// 获取合成的音频信息
        /// 获取合成音频数据的信息
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID</param>
        /// <returns>返回音频信息字符串</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern nint QTTSAudioInfo(nint sessionID);

        /// <summary>
        /// 获取合成的音频信息（宽字符版本）
        /// 获取合成音频数据的信息
        /// </summary>
        /// <param name="sessionID">会话开始时返回的会话ID（宽字符）</param>
        /// <returns>返回音频信息字符串（宽字符）</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern nint QTTSAudioInfoW(nint sessionID);

        /// <summary>
        /// 结束识别器会话
        /// 结束识别器会话，释放所有资源
        /// </summary>
        /// <param name="sessionID">要结束的会话ID字符串</param>
        /// <param name="hints">结束会话的用户提示，提示将被记录到CallLog</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode QTTSSessionEnd(nint sessionID, string hints);

        /// <summary>
        /// 结束识别器会话（宽字符版本）
        /// 结束识别器会话，释放所有资源
        /// </summary>
        /// <param name="sessionID">要结束的会话ID字符串（宽字符）</param>
        /// <param name="hints">结束会话的用户提示（宽字符），提示将被记录到CallLog</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern MSPErrorCode QTTSSessionEndW(nint sessionID, string hints);

        /// <summary>
        /// 获取与MSC相关的参数
        /// 参数可以是本地或服务器参数，目前仅支持网络流量参数"upflow"和"downflow"
        /// </summary>
        /// <param name="sessionID">相关参数的会话ID，设置为NULL以获取全局参数</param>
        /// <param name="paramName">参数名称，可以传递多个参数，用','、';'或'\n'分隔</param>
        /// <param name="paramValue">参数值缓冲区，由用户分配</param>
        /// <param name="valueLen">输入值缓冲区的长度，并返回值字符串的长度（输入/输出）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode QTTSGetParam(nint sessionID, string paramName, StringBuilder paramValue, ref uint valueLen);

        /// <summary>
        /// 获取与MSC相关的参数（宽字符版本）
        /// 参数可以是本地或服务器参数，目前仅支持网络流量参数"upflow"和"downflow"
        /// </summary>
        /// <param name="sessionID">相关参数的会话ID（宽字符），设置为NULL以获取全局参数</param>
        /// <param name="paramName">参数名称（宽字符），可以传递多个参数，用','、';'或'\n'分隔</param>
        /// <param name="paramValue">参数值缓冲区（宽字符），由用户分配</param>
        /// <param name="valueLen">输入值缓冲区的长度，并返回值字符串的长度（输入/输出）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern MSPErrorCode QTTSGetParamW(nint sessionID, string paramName, StringBuilder paramValue, ref uint valueLen);

        /// <summary>
        /// 设置与MSC相关的参数
        /// 参数可以是本地或服务器参数，目前仅支持网络流量参数"upflow"和"downflow"
        /// </summary>
        /// <param name="sessionID">相关参数的会话ID，设置为NULL以设置全局参数</param>
        /// <param name="paramName">参数名称，可以传递多个参数，用','、';'或'\n'分隔</param>
        /// <param name="paramValue">参数值缓冲区，由用户分配</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode QTTSSetParam(nint sessionID, string paramName, string paramValue);

        /// <summary>
        /// 设置与MSC相关的参数（宽字符版本）
        /// 参数可以是本地或服务器参数，目前仅支持网络流量参数"upflow"和"downflow"
        /// </summary>
        /// <param name="sessionID">相关参数的会话ID（宽字符），设置为NULL以设置全局参数</param>
        /// <param name="paramName">参数名称（宽字符），可以传递多个参数，用','、';'或'\n'分隔</param>
        /// <param name="paramValue">参数值缓冲区（宽字符），由用户分配</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern MSPErrorCode QTTSSetParamW(nint sessionID, string paramName, string paramValue);

        /// <summary>
        /// 宽字符转多字节
        /// </summary>
        /// <param name="wcstr">以空结尾的源字符串（wchar_t *）</param>
        /// <returns>转换后的多字节字符串</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern nint Wchar2Mbytes(string wcstr);

        /// <summary>
        /// 多字节转宽字符
        /// </summary>
        /// <param name="mbstr">以空结尾的源字符串（char *）</param>
        /// <returns>转换后的宽字符字符串</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern nint Mbytes2Wchar(string mbstr);

        /// <summary>
        /// 用户登录接口
        /// 用于用户登录系统
        /// </summary>
        /// <param name="usr">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="param">用户登录时的参数</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode MSPLogin(string usr, string pwd, string param);

        /// <summary>
        /// 用户登录接口（宽字符版本）
        /// 用于用户登录系统
        /// </summary>
        /// <param name="usr">用户名（宽字符）</param>
        /// <param name="pwd">密码（宽字符）</param>
        /// <param name="param">用户登录时的参数（宽字符）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern MSPErrorCode MSPLoginW(string usr, string pwd, string param);

        /// <summary>
        /// 用户登出接口
        /// 用于用户登出系统
        /// </summary>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall)]
        internal static extern MSPErrorCode MSPLogout();

        /// <summary>
        /// 用户登出接口（宽字符版本）
        /// 用于用户登出系统
        /// </summary>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall)]
        internal static extern MSPErrorCode MSPLogoutW();

        /// <summary>
        /// 上传用户特定数据
        /// 上传诸如用户配置、自定义语法等数据
        /// </summary>
        /// <param name="dataName">数据名称，应唯一以区分其他数据</param>
        /// <param name="param">关于上传数据的参数</param>
        /// <param name="dataID">要操作的数据的ID</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode MSPUpload(string dataName, string param, string dataID);

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
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode MSPDownload(string dataName, string param, DownloadStatusCB statusCb, DownloadResultCB resultCb, nint userData);

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
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern MSPErrorCode MSPDownloadW(string dataName, string param, DownloadStatusCB statusCb, DownloadResultCB resultCb, nint userData);

        /// <summary>
        /// 追加数据
        /// 向MSC写入数据，如要上传的数据、搜索文本等
        /// </summary>
        /// <param name="data">数据缓冲区指针，数据可以是二进制</param>
        /// <param name="dataLen">数据长度</param>
        /// <param name="dataStatus">数据状态，2: 首次或连续，4: 最后</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall)]
        internal static extern MSPErrorCode MSPAppendData(nint data, uint dataLen, uint dataStatus);

        /// <summary>
        /// 获取结果
        /// 获取上传、下载或搜索等操作的结果
        /// </summary>
        /// <param name="rsltLen">返回结果的长度（输出）</param>
        /// <param name="rsltStatus">返回结果的状态（输出）</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>上传、下载或搜索等操作的结果</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern nint MSPGetResult(out uint rsltLen, out int rsltStatus, out MSPErrorCode errorCode);

        /// <summary>
        /// 设置MSC的参数
        /// 设置MSC的相关参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="paramValue">参数值</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode MSPSetParam(string paramName, string paramValue);

        /// <summary>
        /// 获取MSC的参数
        /// 获取MSC的相关参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="paramValue">参数值（输出）</param>
        /// <param name="valueLen">参数值（缓冲区）长度（输入/输出）</param>
        /// <returns>成功时返回0，否则返回错误代码</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode MSPGetParam(string paramName, StringBuilder paramValue, ref uint valueLen);

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
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern nint MSPUploadData(string dataName, nint data, uint dataLen, string param, out MSPErrorCode errorCode);

        /// <summary>
        /// 下载用户特定数据
        /// 下载诸如用户配置等数据
        /// </summary>
        /// <param name="param">关于要下载的数据的参数</param>
        /// <param name="dataLen">接收数据的长度（输出）</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>接收数据的缓冲区指针，数据可以是二进制，失败或数据不存在时为NULL</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern nint MSPDownloadData(string param, out uint dataLen, out MSPErrorCode errorCode);

        /// <summary>
        /// 下载用户特定数据（宽字符版本）
        /// 下载诸如用户配置等数据
        /// </summary>
        /// <param name="param">关于要下载的数据的参数（宽字符）</param>
        /// <param name="dataLen">接收数据的长度（输出）</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>接收数据的缓冲区指针，数据可以是二进制，失败或数据不存在时为NULL</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        internal static extern nint MSPDownloadDataW(string param, out uint dataLen, out MSPErrorCode errorCode);

        /// <summary>
        /// 搜索文本以获取结果
        /// 搜索文本内容，并获取文本结果
        /// </summary>
        /// <param name="param">关于要下载的数据的参数</param>
        /// <param name="text">文本内容</param>
        /// <param name="dataLen">接收数据的长度（输出）</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>接收数据的缓冲区指针，数据可以是二进制，失败或数据不存在时为NULL</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern nint MSPSearch(string param, string text, out uint dataLen, out MSPErrorCode errorCode);

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
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern nint MSPNlpSearch(string param, string text, uint textLen, out MSPErrorCode errorCode, NLPSearchCB callback, nint userData);

        /// <summary>
        /// 取消NLP搜索
        /// </summary>
        /// <param name="sessionID">会话ID</param>
        /// <param name="hints">提示信息</param>
        /// <returns>处理结果</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern MSPErrorCode MSPNlpSchCancel(nint sessionID, string hints);

        /// <summary>
        /// 注册回调函数
        /// 注册一个回调函数用于接收通知
        /// </summary>
        /// <param name="statusCb">通知处理函数</param>
        /// <param name="userData">用户数据</param>
        /// <returns>处理结果</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall)]
        internal static extern nint MSPRegisterNotify(MSPStatusNtfHandler statusCb, nint userData);

        /// <summary>
        /// 获取MSC或本地引擎的版本
        /// 获取MSC或本地引擎的版本信息
        /// </summary>
        /// <param name="verName">版本名称，可以是"msc"、"aitalk"、"aisound"、"ivw"</param>
        /// <param name="errorCode">成功时返回0，否则返回错误代码（输出）</param>
        /// <returns>成功时返回版本值，失败时返回NULL</returns>
        [DllImport("libmsc_64", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        internal static extern nint MSPGetVersion(string verName, out MSPErrorCode errorCode);
    }
}
