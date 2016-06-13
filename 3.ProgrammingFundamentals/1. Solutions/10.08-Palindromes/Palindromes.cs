using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._08_Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            char[] delimeters = " ,.?!".ToCharArray();
            string[] text = Console.ReadLine().Split(delimeters);
            List<string> palindromes = new List<string>();

            foreach (var word in text)
            {
                var reversedWord = word.Reverse().ToArray();
                int count = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == reversedWord[i])
                    {
                        count++;

                        if (count == word.Length)
                        {
                            palindromes.Add(word);
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(", ", palindromes.OrderBy(x => x).Distinct()));
        }
    }
}