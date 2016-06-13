using System;
using System.Linq;

namespace _8._03_DiagonalDifference
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];
            int primeDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < size; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col)
                    {
                        primeDiagonal += matrix[row][col];
                    }

                    if (col == size - 1 - row)
                    {
                        secondaryDiagonal += matrix[row][col];
                    }
                }
            }

            long result = Math.Abs(primeDiagonal - secondaryDiagonal);
            Console.WriteLine(result);
        }
    }
}