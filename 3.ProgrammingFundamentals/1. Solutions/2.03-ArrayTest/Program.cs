namespace Arrays
{
    using System;
    using System.Linq;

    public class ArraysMain
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();
            string command;

            while ((command = Console.ReadLine()) != "stop")
            {
                int[] args = new int[2];
                string[] stringParams = command.Split(ArgumentsDelimiter);

                if (stringParams[0].Equals("add") || stringParams[0].Equals("subtract") || stringParams[0].Equals("multiply"))
                {
                    command = stringParams[0];
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, command, args);
                    Console.WriteLine();
                }
                else
                {
                    PerformAction(array, command, args);
                    PrintArray(array);
                    Console.WriteLine();
                }
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr;
            int possition = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[possition - 1] *= value;
                    PrintArray(array);
                    break;
                case "add":
                    array[possition - 1] += value;
                    PrintArray(array);
                    break;
                case "subtract":
                    array[possition - 1] -= value;
                    PrintArray(array);
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i- 1];

                if (i == 1)
                {
                    array[0] = lastElement;
                }
            }
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstElement = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];

                if (i == array.Length - 2)
                {
                    array[array.Length - 1] = firstElement;
                }
            }
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}