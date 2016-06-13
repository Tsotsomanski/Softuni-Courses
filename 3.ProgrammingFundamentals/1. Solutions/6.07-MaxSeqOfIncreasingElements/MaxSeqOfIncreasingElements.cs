using System;
using System.Linq;

namespace _6._07_MaxSeqOfIncreasingElements
{
    public class MaxSeqOfIncreasingElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestCounter = 1;
            int bestPossition = 0;
            int counter = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestPossition = i + 1;
                }
            }

            int endCount = bestPossition + 1 - bestCounter;
            int[] maxSequence = new int[bestCounter];

            for (int i = bestPossition, j = 0; i >= endCount; i--, j++)
            {
                maxSequence[j] = array[i];
            }

            Console.WriteLine(String.Join(" ", maxSequence.Reverse()));
        }
    }
}