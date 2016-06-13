using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._06_CountRealNumbers
{
    public class Program
    {
        public static void Main()
        {
            List<decimal> realNumbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            SortedDictionary<decimal, int> counts = new SortedDictionary<decimal, int>();

            foreach (var num in realNumbers)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }   
            }

            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }
        }
    }
}