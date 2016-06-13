using System;
using System.Linq;
using System.Xml;

namespace _6._06_MaxSeqOfEqualElements
{
    public class MaxSeqOfEqualElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestCounter = 1;
            int bestPossition = 0;
            int counter = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
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

            for (int i = bestPossition; i >= endCount; i--)
            {
                if (i != endCount)
                {
                    Console.Write(array[i] + " ");
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
        }
    }
}