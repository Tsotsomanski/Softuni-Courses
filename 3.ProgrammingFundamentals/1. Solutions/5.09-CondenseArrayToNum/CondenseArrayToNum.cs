using System;
using System.Linq;

namespace _5._09_CondenseArrayToNum
{
    public class CondenseArrayToNum
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[] {};

            while (nums.Length >= 1)
            {
                condensed = new int[nums.Length - 1];
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }

                if (nums.Length == 1)
                {
                    Console.WriteLine(String.Join("", nums));
                }
                nums = condensed;
            }
        }
    }
}