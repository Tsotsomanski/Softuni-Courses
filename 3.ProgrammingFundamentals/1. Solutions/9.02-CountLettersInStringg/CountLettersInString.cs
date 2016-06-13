using System;
using System.Linq;

namespace _9._01_PrintStringLetters
{
    public class CountLettersInString
    {
        public static void Main()
        {
            string str = Console.ReadLine().ToLower();
            int[] count = new int[str.Max() + 1];

            foreach (char ch in str)
            {
                count[ch]++;
            }

            for (char ch = (char)0; ch < count.Length; ch++)
            {
                if (count[ch] != 0)
                {
                    Console.WriteLine($"{ch} -> {count[ch]}");
                }
            }
        }
    }
}