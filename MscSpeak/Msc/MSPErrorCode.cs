namespace MscSpeak.Msc
{
    /// <summary>
    /// MSP错误代码枚举
    /// 包含所有可能的错误返回值
    /// </summary>
    internal enum MSPErrorCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        MSP_SUCCESS = 0,
        /// <summary>
        /// 失败
        /// </summary>
        MSP_ERROR_FAIL = -1,
        /// <summary>
        /// 异常
        /// </summary>
        MSP_ERROR_EXCEPTION = -2,

        // 通用错误 10100(0x2774)
        /// <summary>
        /// 通用错误
        /// </summary>
        MSP_ERROR_GENERAL = 10100,
        /// <summary>
        /// 内存不足
        /// </summary>
        MSP_ERROR_OUT_OF_MEMORY = 10101,
        /// <summary>
        /// 文件未找到
        /// </summary>
        MSP_ERROR_FILE_NOT_FOUND = 10102,
        /// <summary>
        /// 不支持
        /// </summary>
        MSP_ERROR_NOT_SUPPORT = 10103,
        /// <summary>
        /// 未实现
        /// </summary>
        MSP_ERROR_NOT_IMPLEMENT = 10104,
        /// <summary>
        /// 访问错误
        /// </summary>
        MSP_ERROR_ACCESS = 10105,
        /// <summary>
        /// 参数无效（缺少参数）
        /// </summary>
        MSP_ERROR_INVALID_PARA = 10106,
        /// <summary>
        /// 参数值无效
        /// </summary>
        MSP_ERROR_INVALID_PARA_VALUE = 10107,
        /// <summary>
        /// 句柄无效
        /// </summary>
        MSP_ERROR_INVALID_HANDLE = 10108,
        /// <summary>
        /// 数据无效
        /// </summary>
        MSP_ERROR_INVALID_DATA = 10109,
        /// <summary>
        /// 无许可证
        /// </summary>
        MSP_ERROR_NO_LICENSE = 10110,
        /// <summary>
        /// 未初始化
        /// </summary>
        MSP_ERROR_NOT_INIT = 10111,
        /// <summary>
        /// 空句柄
        /// </summary>
        MSP_ERROR_NULL_HANDLE = 10112,
        /// <summary>
        /// 溢出
        /// </summary>
        MSP_ERROR_OVERFLOW = 10113,
        /// <summary>
        /// 超时
        /// </summary>
        MSP_ERROR_TIME_OUT = 10114,
        /// <summary>
        /// 打开文件错误
        /// </summary>
        MSP_ERROR_OPEN_FILE = 10115,
        /// <summary>
        /// 未找到（数据库或模型不存在）
        /// </summary>
        MSP_ERROR_NOT_FOUND = 10116,
        /// <summary>
        /// 缓冲区不足
        /// </summary>
        MSP_ERROR_NO_ENOUGH_BUFFER = 10117,
        /// <summary>
        /// 无数据
        /// </summary>
        MSP_ERROR_NO_DATA = 10118,
        /// <summary>
        /// 无更多数据
        /// </summary>
        MSP_ERROR_NO_MORE_DATA = 10119,
        /// <summary>
        /// 无响应数据
        /// </summary>
        MSP_ERROR_NO_RESPONSE_DATA = 10120,
        /// <summary>
        /// 已存在（数据库或模型已存在）
        /// </summary>
        MSP_ERROR_ALREADY_EXIST = 10121,
        /// <summary>
        /// 加载模块错误
        /// </summary>
        MSP_ERROR_LOAD_MODULE = 10122,
        /// <summary>
        /// 忙碌
        /// </summary>
        MSP_ERROR_BUSY = 10123,
        /// <summary>
        /// 配置无效
        /// </summary>
        MSP_ERROR_INVALID_CONFIG = 10124,
        /// <summary>
        /// 版本检查错误
        /// </summary>
        MSP_ERROR_VERSION_CHECK = 10125,
        /// <summary>
        /// 已取消
        /// </summary>
        MSP_ERROR_CANCELED = 10126,
        /// <summary>
        /// 媒体类型无效
        /// </summary>
        MSP_ERROR_INVALID_MEDIA_TYPE = 10127,
        /// <summary>
        /// 配置初始化错误
        /// </summary>
        MSP_ERROR_CONFIG_INITIALIZE = 10128,
        /// <summary>
        /// 创建句柄错误
        /// </summary>
        MSP_ERROR_CREATE_HANDLE = 10129,
        /// <summary>
        /// 编码库未加载
        /// </summary>
        MSP_ERROR_CODING_LIB_NOT_LOAD = 10130,
        /// <summary>
        /// 用户已取消
        /// </summary>
        MSP_ERROR_USER_CANCELLED = 10131,
        /// <summary>
        /// 操作无效
        /// </summary>
        MSP_ERROR_INVALID_OPERATION = 10132,
        /// <summary>
        /// 消息不完整
        /// </summary>
        MSP_ERROR_MESSAGE_NOT_COMPLETE = 10133,
        /// <summary>
        /// 无EID
        /// </summary>
        MSP_ERROR_NO_EID = 10134,
        /// <summary>
        /// 请求过多
        /// </summary>
        MSP_ERROE_OVER_REQ = 10135,
        /// <summary>
        /// 用户主动中止
        /// </summary>
        MSP_ERROR_USER_ACTIVE_ABORT = 10136,
        /// <summary>
        /// 正在构建语法，忙碌中
        /// </summary>
        MSP_ERROR_BUSY_GRMBUILDING = 10137,
        /// <summary>
        /// 正在更新词典，忙碌中
        /// </summary>
        MSP_ERROR_BUSY_LEXUPDATING = 10138,
        /// <summary>
        /// 会话重置
        /// </summary>
        MSP_ERROR_SESSION_RESET = 10139,
        /// <summary>
        /// VAD前端超时
        /// </summary>
        MSP_ERROR_BOS_TIMEOUT = 10140,
        /// <summary>
        /// 流过滤错误
        /// </summary>
        MSP_ERROR_STREAM_FILTER = 10141,
        /// <summary>
        /// 流清除错误
        /// </summary>
        MSP_ERROR_STREAM_CLEAR = 10142,

        // 网络错误 10200(0x27D8)
        /// <summary>
        /// 网络通用错误
        /// </summary>
        MSP_ERROR_NET_GENERAL = 10200,
        /// <summary>
        /// 打开套接字错误
        /// </summary>
        MSP_ERROR_NET_OPENSOCK = 10201,
        /// <summary>
        /// 连接套接字错误
        /// </summary>
        MSP_ERROR_NET_CONNECTSOCK = 10202,
        /// <summary>
        /// 接受套接字错误
        /// </summary>
        MSP_ERROR_NET_ACCEPTSOCK = 10203,
        /// <summary>
        /// 发送套接字数据错误
        /// </summary>
        MSP_ERROR_NET_SENDSOCK = 10204,
        /// <summary>
        /// 接收套接字数据错误
        /// </summary>
        MSP_ERROR_NET_RECVSOCK = 10205,
        /// <summary>
        /// 无效的套接字句柄
        /// </summary>
        MSP_ERROR_NET_INVALIDSOCK = 10206,
        /// <summary>
        /// 错误的网络地址
        /// </summary>
        MSP_ERROR_NET_BADADDRESS = 10207,
        /// <summary>
        /// 监听/连接后绑定错误
        /// </summary>
        MSP_ERROR_NET_BINDSEQUENCE = 10208,
        /// <summary>
        /// 套接字未打开
        /// </summary>
        MSP_ERROR_NET_NOTOPENSOCK = 10209,
        /// <summary>
        /// 套接字未绑定到地址
        /// </summary>
        MSP_ERROR_NET_NOTBIND = 10210,
        /// <summary>
        /// 套接字未监听
        /// </summary>
        MSP_ERROR_NET_NOTLISTEN = 10211,
        /// <summary>
        /// 连接的另一端已关闭
        /// </summary>
        MSP_ERROR_NET_CONNECTCLOSE = 10212,
        /// <summary>
        /// 套接字不是数据报类型
        /// </summary>
        MSP_ERROR_NET_NOTDGRAMSOCK = 10213,
        /// <summary>
        /// DNS错误
        /// </summary>
        MSP_ERROR_NET_DNS = 10214,
        /// <summary>
        /// 网络初始化错误
        /// </summary>
        MSP_ERROR_NET_INIT = 10215,

        // 其他错误（省略部分重复或过长的错误码注释）
        MSP_ERROR_NFL_INNER_ERROR = 10216,
        MSP_ERROR_MSS_TIME_OUT = 10217,
        MSP_ERROT_CLIENT_TIME_OUT = 10218,
        MSP_ERROR_CLIENT_CLOSE = 10219,
        MSP_ERROR_CLIENT_AREA_CHANGE = 10220,
        MSP_ERROR_NET_SSL_HANDSHAKE = 10221,
        MSP_ERROR_NET_INVALID_ROOT_CERT = 10222,
        MSP_ERROR_NET_INVALID_CLIENT_CERT = 10223,
        MSP_ERROR_NET_INVALID_SERVER_CERT = 10224,
        MSP_ERROR_NET_INVALID_KEY = 10225,
        MSP_ERROR_NET_CERT_VERIFY_FAILED = 10226,
        MSP_ERROR_NET_WOULDBLOCK = 10227,
        MSP_ERROR_NET_NOTBLOCK = 10228,

        // 消息错误 10300(0x283C)
        MSP_ERROR_MSG_GENERAL = 10300,
        MSP_ERROR_MSG_PARSE_ERROR = 10301,
        MSP_ERROR_MSG_BUILD_ERROR = 10302,
        MSP_ERROR_MSG_PARAM_ERROR = 10303,
        MSP_ERROR_MSG_CONTENT_EMPTY = 10304,
        MSP_ERROR_MSG_INVALID_CONTENT_TYPE = 10305,
        MSP_ERROR_MSG_INVALID_CONTENT_LENGTH = 10306,
        MSP_ERROR_MSG_INVALID_CONTENT_ENCODE = 10307,
        MSP_ERROR_MSG_INVALID_KEY = 10308,
        MSP_ERROR_MSG_KEY_EMPTY = 10309,
        MSP_ERROR_MSG_SESSION_ID_EMPTY = 10310,
        MSP_ERROR_MSG_LOGIN_ID_EMPTY = 10311,
        MSP_ERROR_MSG_SYNC_ID_EMPTY = 10312,
        MSP_ERROR_MSG_APP_ID_EMPTY = 10313,
        MSP_ERROR_MSG_EXTERN_ID_EMPTY = 10314,
        MSP_ERROR_MSG_INVALID_CMD = 10315,
        MSP_ERROR_MSG_INVALID_SUBJECT = 10316,
        MSP_ERROR_MSG_INVALID_VERSION = 10317,
        MSP_ERROR_MSG_NO_CMD = 10318,
        MSP_ERROR_MSG_NO_SUBJECT = 10319,
        MSP_ERROR_MSG_NO_VERSION = 10320,
        MSP_ERROR_MSG_MSSP_EMPTY = 10321,
        MSP_ERROR_MSG_NEW_RESPONSE = 10322,
        MSP_ERROR_MSG_NEW_CONTENT = 10323,
        MSP_ERROR_MSG_INVALID_SESSION_ID = 10324,
        MSP_ERROR_MSG_INVALID_CONTENT = 10325,

        // 数据库错误 10400(0x28A0)
        MSP_ERROR_DB_GENERAL = 10400,
        MSP_ERROR_DB_EXCEPTION = 10401,
        MSP_ERROR_DB_NO_RESULT = 10402,
        MSP_ERROR_DB_INVALID_USER = 10403,
        MSP_ERROR_DB_INVALID_PWD = 10404,
        MSP_ERROR_DB_CONNECT = 10405,
        MSP_ERROR_DB_INVALID_SQL = 10406,
        MSP_ERROR_DB_INVALID_APPID = 10407,
        MSP_ERROR_DB_NO_UID = 10408,

        // 资源错误 10500(0x2904)
        MSP_ERROR_RES_GENERAL = 10500,
        MSP_ERROR_RES_LOAD = 10501,
        MSP_ERROR_RES_FREE = 10502,
        MSP_ERROR_RES_MISSING = 10503,
        MSP_ERROR_RES_INVALID_NAME = 10504,
        MSP_ERROR_RES_INVALID_ID = 10505,
        MSP_ERROR_RES_INVALID_IMG = 10506,
        MSP_ERROR_RES_WRITE = 10507,
        MSP_ERROR_RES_LEAK = 10508,
        MSP_ERROR_RES_HEAD = 10509,
        MSP_ERROR_RES_DATA = 10510,
        MSP_ERROR_RES_SKIP = 10511,

        // TTS错误 10600(0x2968)
        MSP_ERROR_TTS_GENERAL = 10600,
        MSP_ERROR_TTS_TEXTEND = 10601,
        MSP_ERROR_TTS_TEXT_EMPTY = 10602,
        MSP_ERROR_TTS_LTTS_ERROR = 10603,

        // 识别器错误 10700(0x29CC)
        MSP_ERROR_REC_GENERAL = 10700,
        MSP_ERROR_REC_INACTIVE = 10701,
        MSP_ERROR_REC_GRAMMAR_ERROR = 10702,
        MSP_ERROR_REC_NO_ACTIVE_GRAMMARS = 10703,
        MSP_ERROR_REC_DUPLICATE_GRAMMAR = 10704,
        MSP_ERROR_REC_INVALID_MEDIA_TYPE = 10705,
        MSP_ERROR_REC_INVALID_LANGUAGE = 10706,
        MSP_ERROR_REC_URI_NOT_FOUND = 10707,
        MSP_ERROR_REC_URI_TIMEOUT = 10708,
        MSP_ERROR_REC_URI_FETCH_ERROR = 10709,
        MSP_ERROR_REC_PROC_MOD = 10710,

        // 语音检测器错误 10800(0x2A30)
        MSP_ERROR_EP_GENERAL = 10800,
        MSP_ERROR_EP_NO_SESSION_NAME = 10801,
        MSP_ERROR_EP_INACTIVE = 10802,
        MSP_ERROR_EP_INITIALIZED = 10803,

        // TUV错误
        MSP_ERROR_TUV_GENERAL = 10900,
        MSP_ERROR_TUV_GETHIDPARAM = 10901,
        MSP_ERROR_TUV_TOKEN = 10902,
        MSP_ERROR_TUV_CFGFILE = 10903,
        MSP_ERROR_TUV_RECV_CONTENT = 10904,
        MSP_ERROR_TUV_VERFAIL = 10905,

        // IMTV错误
        MSP_ERROR_LOGIN_SUCCESS = 11000,
        MSP_ERROR_LOGIN_NO_LICENSE = 11001,
        MSP_ERROR_LOGIN_SESSIONID_INVALID = 11002,
        MSP_ERROR_LOGIN_SESSIONID_ERROR = 11003,
        MSP_ERROR_LOGIN_UNLOGIN = 11004,
        MSP_ERROR_LOGIN_INVALID_USER = 11005,
        MSP_ERROR_LOGIN_INVALID_PWD = 11006,
        MSP_ERROR_LOGIN_SYSTEM_ERROR = 11099,

        // HCR错误
        MSP_ERROR_HCR_GENERAL = 11100,
        MSP_ERROR_HCR_RESOURCE_NOT_EXIST = 11101,
        MSP_ERROR_HCR_CREATE = 11102,
        MSP_ERROR_HCR_DESTROY = 11103,
        MSP_ERROR_HCR_START = 11104,
        MSP_ERROR_HCR_APPEND_STROKES = 11105,
        MSP_ERROR_HCR_INIT = 11106,
        MSP_ERROR_HCR_POINT_DECODE = 11107,
        MSP_ERROR_HCR_DISPATCH = 11108,
        MSP_ERROR_HCR_GETRESULT = 11109,
        MSP_ERROR_HCR_RESOURCE = 11110,

        // 本地引擎错误
        MSP_ERROR_AUTH_NO_LICENSE = 11200,
        MSP_ERROR_AUTH_NO_ENOUGH_LICENSE = 11201,
        MSP_ERROR_AUTH_INVALID_LICENSE = 11202,
        MSP_ERROR_AUTH_LICENSE_EXPIRED = 11203,
        MSP_ERROR_AUTH_NEED_MORE_DATA = 11204,
        MSP_ERROR_AUTH_LICENSE_TO_BE_EXPIRED = 11205,
        MSP_ERROR_AUTH_INVALID_MACHINE_ID = 11206,
        MSP_ERROR_AUTH_LOCAL_ASR_FORBIDDEN = 11207
    }
}
