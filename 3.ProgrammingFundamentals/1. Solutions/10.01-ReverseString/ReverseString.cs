using System;
using System.Linq;

namespace _10._01_ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            var array = input.ToCharArray();
            var result = input.Reverse();
            Console.WriteLine(String.Join("", result));
        }
    }
}
