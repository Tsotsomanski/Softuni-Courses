using System;

namespace _4._13_VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] vowelLetters = {"a", "e", "i", "o", "u", "y"};
            int a;
            bool isVowel = false;
            bool isDigit = int.TryParse(input, out a);

            if (isDigit)
            {
                Console.WriteLine("digit");
            }

            else
            {
                for (int i = 0; i < vowelLetters.Length; i++)
                {
                    if (input.Contains(vowelLetters[i]))
                    {
                        isVowel = true;
                    }
                }

                if (isVowel)
                {
                    Console.WriteLine("vowel");
                }

                if (!isVowel)
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}