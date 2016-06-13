using System;
using System.Numerics;

namespace _11._03_BigFactorial
{
    public class BigFactorial
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger fact = 1;

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}