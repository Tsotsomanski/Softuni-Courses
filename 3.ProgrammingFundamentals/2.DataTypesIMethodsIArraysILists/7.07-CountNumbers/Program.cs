using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._07_CountNumbers
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();

            int counter = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", numbers[i], counter);
                        counter = 1;
                    }
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", numbers[i], counter);
                }
            }

            //List<int> numbers = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .OrderBy(number => number)
            //    .ToList();

            //int prevElement = numbers[0];
            //int counter = 1;

            //for (int current = 1; current < numbers.Count; current++)
            //{
            //    if (prevElement == numbers[current])
            //    {
            //        counter++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} -> {1}", prevElement, counter);
            //        prevElement = numbers[current];
            //        counter = 1;
            //    }
            //}

            //Console.WriteLine("{0} -> {1}", prevElement, counter);
        }
    }
}