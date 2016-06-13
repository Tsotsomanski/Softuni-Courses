using System;
using System.Linq;

public class TrifonsQuest
{
    public static void Main()
    {
        long healthPoints = long.Parse(Console.ReadLine());
        int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = dimensions[0];
        int cols = dimensions[1];
        char[][] matrix = new char[rows][];
        long turns = 0;
        long diedRow = 0;
        long diedCol = 0;

        for (long row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().ToUpper().ToCharArray();
        }

        if (healthPoints == 0)
        {
            Console.WriteLine("Died at: [0, 0]");
        }
        else
        {
            for (long col = 0; col < cols; col++)
            {
                if (col % 2 == 0)
                {
                    for (long row = 0; row < rows; row++)
                    {
                        if (matrix[row][col] == 'F')
                        {
                            healthPoints -= (turns / 2);
                            turns += 1;

                            if (healthPoints <= 0)
                            {
                                diedRow = row;
                                diedCol = col;
                                break;
                            }
                        }

                        if (matrix[row][col] == 'H')
                        {
                            healthPoints += (turns / 3);
                            turns += 1;
                        }

                        if (matrix[row][col] == 'T')
                        {
                            turns += 2;
                            turns++;
                        }

                        if (matrix[row][col] == 'E')
                        {
                            turns += 1;
                        }
                    }
                }
                else
                {
                    for (long row = rows - 1; row >= 0; row--)
                    {
                        if (matrix[row][col] == 'F')
                        {
                            healthPoints -= (turns / 2);
                            turns += 1;

                            if (healthPoints <= 0)
                            {
                                diedRow = row;
                                diedCol = col;
                                break;
                            }
                        }

                        if (matrix[row][col] == 'H')
                        {
                            healthPoints += (turns / 3);
                            turns += 1;
                        }

                        if (matrix[row][col] == 'T')
                        {
                            turns += 2;
                            turns++;
                        }

                        if (matrix[row][col] == 'E')
                        {
                            turns += 1;
                        }
                    }
                }
            }

            if (healthPoints > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine("Health: " + healthPoints);
                Console.WriteLine("Turns: " + turns);
            }
            else
            {
                Console.WriteLine("Died at: [{0}, {1}]", diedRow, diedCol);
            }
        }
    }
}