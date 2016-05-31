using System;

namespace _4._17_DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            
            try
            {
                if (n > -128 && n < 127)
                {
                    Console.WriteLine("{0} can fit in: ", n);
                    Console.WriteLine("* byte");
                }

                else if (n > -32768 && n < 32727)
                {
                    Console.WriteLine("{0} can fit in: ", n);
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }

                else if (n > -2147483648 && n < 2147483647)
                {
                    Console.WriteLine("{0} can fit in: ", n);
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
            }
            catch (OverflowException)
            {
                if (n >= -9000000000000000000 && n >= 9000000000000000000)
                {
                    Console.WriteLine("{0} can't fit in any type", n);
                }
                throw;
            }
        }
    }
}