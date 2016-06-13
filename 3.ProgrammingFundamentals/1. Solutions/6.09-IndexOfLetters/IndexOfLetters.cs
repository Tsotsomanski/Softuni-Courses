using System;

namespace _6._09_IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                int indexOfLetter = alphabet.IndexOf(word[i]);
                Console.WriteLine("{0} -> {1}", word[i], indexOfLetter);
            }
        }
    }
}