using System;

namespace _4._21_NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            string num = Console.ReadLine();

            ReverseTheDigits(num);
        }

        public static void ReverseTheDigits(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i]);
            }
        }

//public static void ReverseTheDigits(decimal a)
        //{
        //    int lastDigit = 0;
        //    int secondDigit = 0;
        //    int firstDigit = 0;

        //    if (a >= 10 && a <= 99)
        //    {
        //        firstDigit = ((int)a % 100) / 10;
        //        lastDigit = (int)a % 10;

        //        Console.WriteLine(lastDigit + "" + firstDigit);
        //    }

        //    if (a >= 100 && a <= 999)
        //    {
        //        firstDigit = ((int)a % 1000) / 100;
        //        secondDigit = ((int)a % 100) / 10;
        //        lastDigit = (int)a % 10;

        //        Console.WriteLine(lastDigit + "" + secondDigit + "" + firstDigit);
        //    }
        
    }
}