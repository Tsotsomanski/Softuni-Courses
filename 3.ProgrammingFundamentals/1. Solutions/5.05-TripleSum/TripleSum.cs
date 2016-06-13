using System;
using System.Linq;

namespace _5._05_TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool contains = ContainsTripleSums(numbers);

            if (!contains)
            {
                Console.WriteLine("No");
            }
        }

        static bool ContainsTripleSums(int[] numbers)
        {
            bool containTriples = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                        containTriples = true;
                    }
                }
            }
            return containTriples;
        }
    }
}