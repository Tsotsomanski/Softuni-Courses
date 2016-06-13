using System;
using System.Linq;

namespace _6._08_MostFreqNum
{
    public class MostFreqNum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int tempCount;
            int popular = array[0];
            int temp = 0;

            for (int i = 0; i < (array.Length - 1); i++)
            {
                temp = array[i];
                tempCount = 0;

                for (int j = 1; j < array.Length; j++)
                {
                    if (temp == array[j])
                        tempCount++;
                }

                if (tempCount > count)
                {
                    popular = temp;
                    count = tempCount;
                }
            }

            Console.WriteLine(popular);
        }
    }
}