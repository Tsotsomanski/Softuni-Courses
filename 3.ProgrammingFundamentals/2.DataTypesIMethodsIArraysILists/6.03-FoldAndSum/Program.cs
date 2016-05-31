using System;
using System.Linq;

namespace _6._03_FoldAndSum
{
    class Program
    {
        static void Main()
        {
            //Input the Array:
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int devidedArraySize = array.Length / 2;
            int sidePart = devidedArraySize / 2;


            // Create arrays:
            int[] upperArray = new int[devidedArraySize];
            int[] upperLeft = new int[devidedArraySize / 2];
            int[] upperRight = new int[devidedArraySize / 2];
            int[] foldedArray = new int[devidedArraySize];
            int[] arraySum = new int[devidedArraySize];

            int leftIndex = 0;
            int foldIndex = 0;
            int rightIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < sidePart)
                {
                    upperLeft[leftIndex] = array[i];
                    leftIndex += 1;
                }

                else if (i >= sidePart && i < devidedArraySize + sidePart)
                {
                    foldedArray[foldIndex] = array[i];
                    foldIndex += 1;
                }

                else if (i >= devidedArraySize + sidePart)
                {
                    upperRight[rightIndex] = array[i];
                    rightIndex += 1;
                }
            }

            
            // Revercing the upper array
            upperLeft = upperLeft.Reverse().ToArray();
            upperRight = upperRight.Reverse().ToArray();

            for (int i = 0; i < upperLeft.Length; i++)
            {
                upperArray[i] = upperLeft[i];
            }

            for (int i = upperLeft.Length, j = 0; j < upperRight.Length; i++, j++)
            {
                upperArray[i] = upperRight[j];
            }


            // Sum arrays:
            for (int i = 0; i < upperArray.Length && i < foldedArray.Length; i++)
            {
                arraySum[i] = upperArray[i] + foldedArray[i];
            }

            Console.WriteLine(String.Join(" ", arraySum));
        }
    }
}







 /*
using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = array.Length / 4;

            int[] left = new int[k];
            int[] right = new int[k];
            int[] bottom = new int[2*k];
            int[] upper = new int[2*k];

            for (int i = 0; i < k; i++)
            {
                left[i] = array[i];
            }

            left = left.Reverse().ToArray();

            for (int i = 3*k, j = 0; j < right.Length; i++, j++)
            {
                right[j] = array[i];
            }

            right = right.Reverse().ToArray();

            for (int i = k, j = 0; j < bottom.Length; i++, j++)
            {
                bottom[j] = array[i];
            }

            for (int i = 0; i < left.Length; i++)
            {
                upper[i] = left[i];
            }

            for (int i = left.Length, j = 0; j < right.Length; i++, j++)
            {
                upper[i] = right[j];
            }

            for (int i = 0; i < upper.Length; i++)
            {
                Console.Write(upper[i] + bottom[i] + " ");
            }
        }
    }
}
*/