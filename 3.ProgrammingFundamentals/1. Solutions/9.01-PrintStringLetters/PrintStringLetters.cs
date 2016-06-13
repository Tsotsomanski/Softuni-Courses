using System;

namespace _9._01_PrintStringLetters
{
    public class Program
    {
        public static void Main()
        {
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"str[{i}] -> '{str[i]}'");
            }
        }
    }
}