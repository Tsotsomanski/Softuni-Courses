using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._04_ExtractSentencesByKeyword
{
    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            char[] delimeters = ".!?".ToCharArray();
            List<string> sentences = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToList();

            char[] wordSplitters = ". ,;:[])('\"/{}-|=-_".ToCharArray();
            foreach (var sentence in sentences)
            {
                List<string> words = sentence.Split(wordSplitters).ToList();

                if (words.Contains(word))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}