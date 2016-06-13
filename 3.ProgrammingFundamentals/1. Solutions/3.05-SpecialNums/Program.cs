using System;

namespace _3._05_SpecialNums
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int firstDigit = i/10;
                int lastDigit = i%10;
                bool isSpecial = firstDigit + lastDigit == 5 || firstDigit + lastDigit == 7 ||
                                 firstDigit + lastDigit == 11;

                Console.WriteLine(i + " -> " + isSpecial);
            }
        }

    }
}