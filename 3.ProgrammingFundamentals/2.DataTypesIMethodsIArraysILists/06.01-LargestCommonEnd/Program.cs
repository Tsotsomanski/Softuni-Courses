using System;

namespace _06._01_LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            int leftLength = 0;
            int rightLength = 0;
            int minLengths = Math.Min(array1.Length, array2.Length);

            for (int i = 0; i < minLengths; i++)
            {
                if (array1[i] == array2[i])
                {
                    leftLength++;
                }
                else
                {
                    break;
                }
            }

            for (int i = array1.Length - 1, j = array2.Length - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (array1[i] == array2[j])
                {
                    rightLength++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(leftLength, rightLength));
        }
    }
}
