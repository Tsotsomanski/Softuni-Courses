using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._08_LargestFrameInMatrix
{
    class LargestFrameInMatrix
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[][] matrix = new int[rows][];
            
            //Filling the Matrix:
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }


            long bestSum = long.MinValue;
            long tempSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            
        }
    }
}