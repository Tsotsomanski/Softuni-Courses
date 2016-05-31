using System;

namespace _4._19_MaxMethod
{
    class MaxMethod
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int firstMax = GetMax(numOne, numTwo);
            int lastMax = GetMax(firstMax, numThree);

            Console.WriteLine(lastMax);
        }

        public static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);
            return max;
        }
    }
}
