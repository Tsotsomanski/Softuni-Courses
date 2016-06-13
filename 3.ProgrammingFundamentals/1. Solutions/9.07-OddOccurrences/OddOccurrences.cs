using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._07_OddOccurrences
{
    public class Program
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine().ToLower().Split().ToList();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in text)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            List<string> result = new List<string>();

            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 1)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}