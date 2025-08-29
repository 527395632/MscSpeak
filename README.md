# 科大讯飞的TTS库。同时支持Window (x86和x64), Linux的 (x86、x64、Arm、Arm64) 版
# 示例
```csharp
static void Main(string[] args)
{
    using (var tts = new TextSpeak("808134bd"))
    {
        while (true)
        {
            tts.Speak("这是一个语音示例程序!");
            Console.WriteLine("播放已完成!");
        }
    }
}
