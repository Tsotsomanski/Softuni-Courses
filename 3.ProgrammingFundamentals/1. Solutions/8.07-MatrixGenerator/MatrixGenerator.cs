using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._07_MatrixGenerator
{
    public class Program
    {
        public static void Main()
        {
            List<string> command = Console.ReadLine().Split(' ').ToList();
            string matrixType = command[0];
            int rows = int.Parse(command[1]);
            int cols = int.Parse(command[2]);
            int[,] matrix = new int[rows, cols];

            switch (matrixType)
            {
                case "A":
                    GenerateMatrixTypeA(matrix);
                    break;
                case "B":
                    GenerateMatrixTypeB(matrix);
                    break;
                case "C":
                    GenerateMatrixTypeC(matrix);
                    break;
                case "D":
                    GenerateMatrixTypeD(matrix);
                    break;
            }
        }

        public static void GenerateMatrixTypeD(int[,] matrix)
        {
            int filler = 1;
            int lastEl = matrix.GetLength(0) * matrix.GetLength(1);

            for (int row = 1; row <= matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    Console.Write(filler + " ");
                    filler++;
                }

                Console.WriteLine();
            }
        }

        public static void GenerateMatrixTypeC(int[,] matrix)
        {
            int filler = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = filler++;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        public static void GenerateMatrixTypeB(int[,] matrix)
        {
            int filler = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = filler++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = filler++;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        public static void GenerateMatrixTypeA(int[,] matrix)
        {
            int filler = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = filler;
                    filler++;
                }
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}