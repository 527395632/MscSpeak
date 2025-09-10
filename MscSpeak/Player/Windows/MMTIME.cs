using System.Runtime.InteropServices;

namespace MscSpeak.Player
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct MMTIME
    {
        public MMTIME()
        {
            wType = 1;
        }

        public uint wType; // 时间类型，1表示字节数
        public uint cb;    // 字节数
        public int unused; // 预留
    }
}
