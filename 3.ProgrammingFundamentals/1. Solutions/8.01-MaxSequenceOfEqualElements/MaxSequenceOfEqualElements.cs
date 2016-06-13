using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._01_MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sequenceLength = 1;
            int bestLength = 0;
            int bestStart = 0;
            int startOccur = 0;

            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i - 1] == sequence[i])
                {
                    sequenceLength++;

                    if (sequenceLength == 2)
                    {
                        startOccur = i - 1; // i - 1
                    }
                }
                else
                {
                    sequenceLength = 1;
                }

                if (sequenceLength > bestLength)
                {
                    bestLength = sequenceLength;
                    bestStart = startOccur;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(sequence[i]+ " ");
            }
        }
    }
}