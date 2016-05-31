using System;
using System.Collections.Generic;

namespace _7._08_BuildAMatrixOfLetters
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                matrix[currentRow] = new char[cols];
            }

            char filler = 'A';

            for (int currentRow = 0; currentRow < matrix.Length; currentRow++)
            {
                for (int currentCol = 0; currentCol < matrix[currentRow].Length; currentCol++)
                {
                    matrix[currentRow][currentCol] = filler;
                    filler++;
                }
            }

            for (int currentRow = 0; currentRow < matrix.Length; currentRow++)
            {
                for (int currentCol = 0; currentCol < matrix[currentRow].Length; currentCol++)
                {
                    Console.Write("{0} ", matrix[currentRow][currentCol]);
                }
                Console.WriteLine();
            }

            //foreach (var row in matrix)
            //{
            //    foreach (var col in row)
            //    {
            //        Console.Write(col);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
