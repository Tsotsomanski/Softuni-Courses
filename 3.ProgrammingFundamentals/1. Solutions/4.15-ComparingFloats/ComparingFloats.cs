using System;

namespace _4._15_ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal eps = 0.000001m;

            if (Math.Abs(a - b) < eps)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}