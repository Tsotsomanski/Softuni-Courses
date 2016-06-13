using System;
using System.Collections.Generic;
using System.Linq;

public class Numbers
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        long sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        long average = sum / numbers.Length;

        List<int> result = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
             if (numbers[i] > average)
            {
                result.Add(numbers[i]);
            }
        }

        int endIndex = result.Count - 5;

        if (result.Count == 0)
        {
            Console.WriteLine("No");
        }

        if (result.Count > 5)
        {
            result.Sort();

            for (int i = result.Count - 1; i >= endIndex; i--)
            {
                if (result[i] == endIndex)
                {
                    Console.WriteLine(result[i]);
                }
                else
                {
                    Console.Write(result[i] + " ");
                }
            }
        }
        else
        {
            Console.WriteLine(String.Join(" ", result.OrderByDescending(x => x)));
        }
    }
}
