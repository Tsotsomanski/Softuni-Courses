using System;

namespace _3._10_FilledSquare
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                if (i == 1 || i == size)
                {
                    PrintHeaderRow(size);
                }
                else
                {
                    PrintMiddleRow(size);
                }
            }
        }

        static void PrintHeaderRow(int n)
        {
            string headerRow = new string('-', n * 2);
            Console.WriteLine(headerRow);
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n- 1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
    }
}
