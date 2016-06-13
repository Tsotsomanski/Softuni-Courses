using System;
using System.Linq;

namespace _9._10_FoldAndSum
{
    public class Program
    {
        public static void Main()
        {

            var array = Console.ReadLine().Split().Select(int.Parse);

            int takeSide = (array.Count() / 2) / 2;
            int takeMiddle = (array.Count() /2);

            var leftReverse = array.Take(takeSide).Reverse();
            var rightReverse = array.Reverse().Take(takeSide);

            int[] firstArray = leftReverse.Concat(rightReverse).ToArray();
            int[] middle = array.Skip(takeSide).Take(takeMiddle).ToArray();

            int sum = 0;

            for (int i = 0; i < firstArray.Count(); i++)
            {
                sum = firstArray[i] + middle[i];
                Console.Write(sum + " ");
            }
        }
    }
}