using System;

namespace _5._04_LastKNumSumSeq
{
    class LastKNumSumSeq
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;

            SumLastKNum(array, k);
        }

        static void SumLastKNum(long[] array, int k)
        {
            for (int currentElement = 1; currentElement < array.Length; currentElement++)
            {
                int startIndex = Math.Max(0, currentElement - k);
                int endIndex = currentElement - 1;
                long sum = 0;

                for (long i = startIndex; i <= endIndex; i++)
                {
                    sum += array[i];
                }

                array[currentElement] = sum;
            }

            PrintArray(array);
        }

        private static void PrintArray(long[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}