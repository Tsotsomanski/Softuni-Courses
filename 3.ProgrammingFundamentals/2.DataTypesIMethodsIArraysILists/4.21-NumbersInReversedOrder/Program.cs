using System;

namespace _4._21_NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            
            ReverseTheDigits(a);
        }

        public static void ReverseTheDigits(double a)
        {
            int lastDigit = 0;
            int secondDigit = 0;
            int firstDigit = 0;
            int thirdDigit = 0;

            if (a >= 10 && a <= 99)
            {
                firstDigit = ((int)a % 100) / 10;
                lastDigit = (int)a % 10;

                Console.WriteLine(lastDigit + "" + firstDigit);
            }

            if (a >= 100 && a <= 999)
            {
                firstDigit = ((int)a % 1000) / 100;
                secondDigit = ((int)a % 100) / 10;
                lastDigit = (int)a % 10;

                Console.WriteLine(lastDigit + "" + secondDigit + "" + firstDigit);
            }

            //if (a >= 1000 && a <= 9999)
            //{
            //    firstDigit = (a % 10000) / 1000;
            //    secondDigit = (a % 1000) / 100;
            //    thirdDigit = (a % 100) / 10;
            //    lastDigit = a % 10;

            //    Console.WriteLine(lastDigit + "" + thirdDigit + "" + secondDigit + "" + firstDigit);
            //}
        }
    }
}
