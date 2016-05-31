using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._06_SquareNumbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int square = (int)Math.Sqrt(numbers[i]);

                if (square * square == numbers[i])
                {
                    squareNumbers.Add(numbers[i]);
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(" ", squareNumbers));
        }
    }
}