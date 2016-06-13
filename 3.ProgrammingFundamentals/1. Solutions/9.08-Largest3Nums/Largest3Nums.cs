using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._08_Largest3Nums
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sorted = numbers.OrderByDescending(a => a).ToList();
            List<int> biggestThree = sorted.Take(3).ToList();

            Console.WriteLine(String.Join(" ", biggestThree));
        }
    }
}