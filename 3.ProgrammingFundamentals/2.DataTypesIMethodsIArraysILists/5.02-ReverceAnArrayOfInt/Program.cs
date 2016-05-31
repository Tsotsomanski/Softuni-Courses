using System;

namespace _5._02_ReverceAnArrayOfInt
{
    class Program
    {
        static void Main()
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                int integer = int.Parse(Console.ReadLine());
                arr[i] = integer;
            }

            Console.WriteLine();

            for (int j = arr.Length; j >= 1; j--)
            {
                Console.Write(arr[j - 1] + " ");
            }
        }
    }
}
