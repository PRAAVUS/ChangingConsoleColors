using System;

namespace ChangingConsoleColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        }
    }
}
