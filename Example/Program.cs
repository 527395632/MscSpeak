using MscSpeak;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var tts = new TextSpeak("你的AppID"))
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