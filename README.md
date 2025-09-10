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
    using (var tts = new TextSpeak("你的AppID"))
    {
        while (true)
        {
            tts.Speak("这是一个语音示例程序!");
            Console.WriteLine("播放已完成!");
        }
    }
}

# 常见问题

1. **Windows环境下的X86环境报错**
   - 如果报MSVCR100.dll找不到的错误, 请在项目根路径下的libs文件夹安装C++库。(如果是64位系统优先安装64位的库, 之后再安装32位的。如果是32位的系统则直接安装32位的库, 无需安装64位的库)

2. **Linux环境中找不到libasound.so**
   - 使用sudo apt-get install libasound-dev 或者使用源码安装, 源码在libs文件夹
```bash
# 安装编译工具
sudo apt install build-essential
# 解压并编译安装
tar -xjvf alsa-lib-1.2.10.tar.bz2
cd alsa-lib-1.2.10
./configure
make
sudo make install
