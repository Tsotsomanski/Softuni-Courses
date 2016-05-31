using System;
using System.Linq;

namespace _5._03_SumMinMaxFirsLastAverage
{
    class Program
    {
        static void Main()
        {
            int numOfNumbers = int.Parse(Console.ReadLine());
            int[] array = new int[numOfNumbers];

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            Console.WriteLine("sum = " + sum);
            Console.WriteLine("min = " + array.Min());
            Console.WriteLine("max = " + array.Max());
            Console.WriteLine("first = " + array.First());
            Console.WriteLine("last = " + array.Last());
            Console.WriteLine("average = " + array.Average());
        }
    }
}
