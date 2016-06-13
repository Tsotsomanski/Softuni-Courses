using System;
using System.Linq;

namespace _8._02_MatrixOfPalindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[][] matrix = new int[rows][];
            char sideLetter = 'a';
            char middleLetter = 'a';

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(sideLetter + "" + middleLetter + "" + sideLetter + " ");
                    middleLetter++;
                }

                sideLetter++;
                middleLetter = sideLetter;
                Console.WriteLine();
            }
        }
    }
}