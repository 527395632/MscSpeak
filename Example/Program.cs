using MscSpeak;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 如果X86环境下报MSVCR100.dll找不到的错误, 请在项目根路径下的libs文件夹安装C++库。
            // 如果是64位系统优先安装64位的库, 之后再安装32位的。如果是32位的系统则直接安装32位的库, 无需安装64位的库
            using (var tts = new MSPAudio("你的APPID"))
            {
                while (true)
                {
                    tts.Speak("这是一个语音示例程序!");

                    Console.WriteLine("播放完成!");
                }
            }
        }
    }
}