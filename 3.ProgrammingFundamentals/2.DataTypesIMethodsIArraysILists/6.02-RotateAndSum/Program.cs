using System;
using System.Linq;

namespace _6._02_RotateAndSum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];

            for (int i = 0; i < k; i++)
            {
                int last = array[array.Length - 1];

                for (int j = array.Length - 1; j > 0 ; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = last;

                //sum
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = sum[j] + array[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
