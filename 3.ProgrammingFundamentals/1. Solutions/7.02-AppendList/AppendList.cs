using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            List<string> lists = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();
            List<int> result = new List<int>();

            foreach (var list in lists)
            {
                List<int> currentList = list.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                result.AddRange(currentList);
            }
        }
    }
}