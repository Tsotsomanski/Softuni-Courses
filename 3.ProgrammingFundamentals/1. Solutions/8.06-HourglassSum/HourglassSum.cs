using System;
using System.Linq;

namespace _8._06_HourglassSum
{
    public class HourglassSum
    {
        public static void Main()
        {
            int size = 6;
            int[][] matrix = new int[size][];
            long bestSum = long.MinValue;
            long tempSum = 0;

            for (int row = 0; row < size; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            for (int row = 0; row < size - 2; row++)
            {
                for (int col = 0; col < size - 2; col++)
                {
                    tempSum = (long)matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                                                    matrix[row + 1][col + 1] +
                              matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (tempSum > bestSum)
                    {
                        bestSum = tempSum;
                    }
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
