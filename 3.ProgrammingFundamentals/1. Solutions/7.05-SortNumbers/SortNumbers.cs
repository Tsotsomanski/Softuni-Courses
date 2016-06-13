using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._05_SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count - 1)
                {
                    Console.Write("{0} <= ", numbers[i]);
                }
                else
                {
                    Console.Write("{0}", numbers[i]);
                }
            }
        }
    }
}