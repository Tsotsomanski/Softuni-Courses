using System;
using System.Linq;

namespace _5._08_SumArrays
{
    class Program
    {
        static void Main()
        {
            int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long arraySum = 0;

            if (arrayOne.Length == arrayTwo.Length)
            {
                for (int i = 0; i < arrayOne.Length && i < arrayTwo.Length; i++)
                {
                    arraySum = arrayOne[i] + arrayTwo[i];
                    Console.Write(arraySum + " ");
                }
            }
            if (arrayOne.Length > arrayTwo.Length)
            {
                
            }
        }
    }
}
