# 这是一个科大讯飞的TTS库。支持以下系统及CPU架构
  1：Windows (x86、x64)
  2: Linux (x86、x64、arm、arm64)

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
