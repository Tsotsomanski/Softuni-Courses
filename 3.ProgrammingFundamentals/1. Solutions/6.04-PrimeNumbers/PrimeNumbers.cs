using System;

namespace _6._04_PrimeNumbers
{
    public class PrimeNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            primes[0] = primes[1] = false;

            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    for (int j = i + i; j < primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}