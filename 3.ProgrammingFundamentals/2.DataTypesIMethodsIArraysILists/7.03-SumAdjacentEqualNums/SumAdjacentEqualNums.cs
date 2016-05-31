using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._03_SumAdjacentEqualNums
{
    public class SumAdjacentEqualNums
    {
        public static void Main()
        {
            List<double> realNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            bool hasAdjacentEqualNumbers = true;

            while (hasAdjacentEqualNumbers)
            {
                hasAdjacentEqualNumbers = false;

                for (int currentEl = 0; currentEl < realNumbers.Count - 1; currentEl++)
                {
                    if (realNumbers[currentEl] == realNumbers[currentEl + 1])
                    {
                        realNumbers[currentEl] *= 2;
                        realNumbers.RemoveAt(currentEl + 1);
                        hasAdjacentEqualNumbers = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", realNumbers));
        }
    }
}