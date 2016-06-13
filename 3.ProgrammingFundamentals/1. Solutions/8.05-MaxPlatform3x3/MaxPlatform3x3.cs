using System;
using System.Linq;

namespace _8._05_MaxPlatform3x3
{
    public class Program
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[][] matrix = new int[rows][];
            long bestSum = long.MinValue;
            long tempSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            //Filling the Matrix:
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            //Finding the sum of the best 3x3 square in the Matrix:
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    tempSum = (long) matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                              matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                              matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (tempSum > bestSum)
                    {
                        bestRow = row;
                        bestCol = col;
                        bestSum = tempSum;
                    }
                }
            }

            Console.WriteLine(bestSum);

            //Printing the best 3x3 square Matrix
            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}