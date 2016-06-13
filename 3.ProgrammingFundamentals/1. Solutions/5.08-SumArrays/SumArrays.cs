using System;
using System.Linq;

namespace _5._08_SumArrays
{
    class SumArrays
    {
        static void Main()
        {
            int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arrayOne.Length == arrayTwo.Length)
            {
                SumTheArrays(arrayOne, arrayTwo);
            }

            else if (arrayOne.Length > arrayTwo.Length)
            {
                SumDifferentArrays(arrayOne, arrayTwo);
            }

            else if (arrayTwo.Length > arrayOne.Length)
            {
                SumDifferentArrays(arrayTwo, arrayOne);
            }
        }

        public static void SumTheArrays(int[] arrayOne, int[] arrayTwo)
        {
            int[] resultArray = new int[arrayOne.Length];

            for (int i = 0; i < arrayOne.Length && i < arrayTwo.Length; i++)
            {
                resultArray[i] = arrayOne[i] + arrayTwo[i];
            }

            Console.Write(String.Join(" ", resultArray));
        }

        public static void SumDifferentArrays(int[] arrayOne, int[] arrayTwo)
        {
            int[] resultArray = new int[] { };

            resultArray = new int[arrayOne.Length];
            int startRepeatIndex = 0;
            int endRepeatIndex = arrayTwo.Length;

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i < arrayTwo.Length)
                {
                    resultArray[i] = arrayTwo[i];
                }
                else
                {
                    if (startRepeatIndex < endRepeatIndex)
                    {
                        resultArray[i] = arrayTwo[startRepeatIndex];
                        startRepeatIndex++;
                    }

                    if (startRepeatIndex == endRepeatIndex)
                    {
                        startRepeatIndex = 0;
                    }
                }
            }

            SumTheArrays(arrayOne, resultArray);
        }
    }
}



//var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//var n = Math.Max(arr1.Length, arr2.Length);
//var sumArr = new int[n];

//            for (int i = 0; i<n; i++)
//            {
//                sumArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
//            }

//            Console.WriteLine(string.Join(" ", sumArr));