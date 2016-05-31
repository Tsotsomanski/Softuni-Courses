using System;

namespace _3._03_ExactSumOfRealNums
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (decimal i = 0; i < n; i++)
            {
                decimal nums = decimal.Parse(Console.ReadLine());
                sum += nums;
            }
            Console.WriteLine(sum);
        }
    }
}
