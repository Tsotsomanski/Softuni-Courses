using System;
using System.Linq;

namespace _5._06_RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] realNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            RoundReadNumbersAwayFromZero(realNumbers);

        }

        static void RoundReadNumbersAwayFromZero(double[] realNumbers)
        {
            foreach (double realNumber in realNumbers)
            {
                Console.WriteLine("{0} => {1:f3}", realNumber ,Math.Round(realNumber, MidpointRounding.AwayFromZero));
            }
        }
    }
}
