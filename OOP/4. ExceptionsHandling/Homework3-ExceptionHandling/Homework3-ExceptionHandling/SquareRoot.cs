using System;
using System.Linq;

namespace Homework3_ExceptionHandling
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    throw new FormatException("You have to enter a possitive integer !");
                }

                double sqrt = Math.Sqrt(number);

                Console.WriteLine("The square root of {0} = {1}", number, sqrt);
            }
            catch (ArgumentOutOfRangeException)
            {
                    Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye !");
            }
        }
    }
}
