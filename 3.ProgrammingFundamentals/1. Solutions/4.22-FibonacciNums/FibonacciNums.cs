using System;

namespace _4._22_FibonacciNums
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 1; i <= n; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    int fibNum = 1 + array[i];
                }
                else
                {
                    
                }
            }
            Fib(n);
        }

        static void Fib(int n)
        {
            int fibNum = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (i == 0)
                {
                    fibNum += i + (i + 1);
                }

                fibNum += i + (i + 1);
                Console.WriteLine(fibNum);
            }
        }
    }
}