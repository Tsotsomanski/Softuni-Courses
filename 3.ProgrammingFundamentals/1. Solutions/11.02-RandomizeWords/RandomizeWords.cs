using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._02_RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine().Split().ToList();
            int count = words.Count;
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                int index = rnd.Next(0, words.Count);
                Console.WriteLine(words[index]);
                words.RemoveAt(index);
            }
        }
    }
}