using System;
using System.Linq;

namespace _8._04_2x2SquaresInMatrix
{
    public class SquaresInMatrix
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            string[][] matrix = new string[rows][];
            int counter = 0;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split();
            }

            for (int row = 0; row <= rows - 2; row++)
            {
                for (int col = 0; col <= cols - 2; col++)
                {
                    if (matrix[row][col] == matrix[row][col + 1] && 
                        matrix[row + 1][col] == matrix[row + 1][col + 1] && 
                        matrix[row][col] == matrix[row + 1][col])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}