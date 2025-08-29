# 科大讯飞 TTS 库支持说明
该 TTS 库支持以下系统及对应的 CPU 架构：

1. **Windows 系统**
   - 支持的 CPU 架构：x86、x64

2. **Linux 系统**
   - 支持的 CPU 架构：x86、x64、arm、arm64


# 使用示例
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
