using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            ShowDebugInfo("my message");
        }

        [System.Diagnostics.Conditional("DEBUG")]
        static void ShowDebugInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
