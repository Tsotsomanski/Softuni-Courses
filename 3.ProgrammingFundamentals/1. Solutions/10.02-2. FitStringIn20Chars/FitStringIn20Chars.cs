using System;

namespace _10._02_2.FitStringIn20Chars
{
    public class FitStringIn20Chars
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int length = 20;
            int difference = length - input.Length;
            
            if (input.Length == length)
            {
                Console.WriteLine(input);
            }

            if (input.Length > 20)
            {
                string substr = input.Substring(0, 20);
                Console.WriteLine(substr);
            }

            if (input.Length < 20)
            {
                string filledString = new string('*', difference);
                Console.WriteLine(input + filledString);
            }
            Console.WriteLine();
        }
    }
}