using System;

namespace _9._05_ForbiddenSubstrings
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');

            foreach (var word in words)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}