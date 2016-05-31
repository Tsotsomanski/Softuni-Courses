using System;

namespace _5._07_7.ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split();
            string[] reversedNames = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                reversedNames[i] = text[text.Length - 1 - i];
            }

            Console.WriteLine(String.Join(" ", reversedNames));
        }
    }
}