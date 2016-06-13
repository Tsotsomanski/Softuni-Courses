using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._03_PrintAReceipt
{
    public class Program
    {
        public static void Main()
        {
            List<double> prices = Console.ReadLine().Split().Select(double.Parse).ToList();
            double sum = 0;


            Console.WriteLine("/----------------------\\");

            for (int i = 0; i < prices.Count; i++)
            {
                sum += prices[i];
                Console.WriteLine("| {0,20:f2} |", prices[i]);
            }

            Console.WriteLine("|----------------------|");
            Console.WriteLine("| Total: {0,13:f2} |", sum);
            Console.WriteLine("\\----------------------/");
        }
    }
}