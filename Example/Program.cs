using MscSpeak;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var tts = new TextSpeak("808134bd"))
            {
                while (true)
                {
                    tts.Speak(Console.ReadLine());

                    Console.WriteLine("---");
                }
            }
        }
    }
}