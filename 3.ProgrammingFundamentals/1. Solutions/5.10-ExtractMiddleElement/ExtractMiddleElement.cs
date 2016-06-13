using System;
using System.Diagnostics;
using System.Linq;

namespace _5._10_ExtractMiddleElement
{
    public class ExtractMiddleElement
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (nums.Length == 1)
            {
                ExtractOneFromTheMiddle(nums);
            }

            else if (nums.Length % 2 == 0)
            {
                ExtractTwoFromTheMiddle(nums);
            }

            else if (nums.Length % 2 == 1)
            {
                 ExtractThreeFromTheMiddle(nums);
            }
        }

        public static void ExtractOneFromTheMiddle(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write("{ ");
                Console.Write($"{num}");
                Console.WriteLine(" }");
            }
        }

        public static void ExtractTwoFromTheMiddle(int[] array)
        {
            int startIndex = array.Length / 2 - 1;
            int endIndex = array.Length / 2;
            int[] result = new int[2];
            int counter = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                result[counter] = array[i];
                counter++;
            }

            Console.Write("{ ");
            Console.Write(String.Join(", ", result));
            Console.Write(" }");
        }

        public static void ExtractThreeFromTheMiddle(int[] array)
        {
            int startIndex = array.Length / 2 - 1;
            int endIndex = array.Length / 2 + 1;
            int[] result = new int[3];
            int counter = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                result[counter] = array[i];
                counter++;
            }

            Console.Write("{ ");
            Console.Write(String.Join(", ", result));
            Console.Write(" }");
        }
    }
}