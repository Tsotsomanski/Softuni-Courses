using System;
using System.Linq;

namespace _5._05_CompareCharArrays
{
    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] arrayOne = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arrayTwo = Console.ReadLine().Split().Select(char.Parse).ToArray();

            if (arrayOne.Length > arrayTwo.Length)
            {
                Console.WriteLine(String.Join("", arrayTwo));
                Console.WriteLine(String.Join("", arrayOne));
            }

            else if (arrayOne.Length < arrayTwo.Length)
            {
                Console.WriteLine(String.Join("", arrayOne));
                Console.WriteLine(String.Join("", arrayTwo));
            }
            else if (arrayOne.Length == arrayTwo.Length)
            {
                for (int i = 0; i < Math.Min(arrayOne.Length, arrayTwo.Length); i++)
                {
                    if (arrayOne[i] > arrayTwo[i])
                    {
                        Console.WriteLine(String.Join("", arrayTwo));
                        Console.WriteLine(String.Join("", arrayOne));
                        break;
                    }

                    if (arrayOne[i] < arrayTwo[i])
                    {
                        Console.WriteLine(String.Join("", arrayOne));
                        Console.WriteLine(String.Join("", arrayTwo));
                        break;
                    }

                    if (arrayOne[i] == arrayTwo[i])
                    {
                        Console.WriteLine(String.Join("", arrayOne));
                        Console.WriteLine(String.Join("", arrayTwo));
                        break;
                    }
                }
            }
        }
    }
}