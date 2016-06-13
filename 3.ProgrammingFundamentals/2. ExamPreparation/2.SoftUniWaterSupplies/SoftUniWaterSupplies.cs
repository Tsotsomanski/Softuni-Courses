using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SoftUniWaterSupplies
{
    public class SoftUniWaterSupplies
    {
        static void Main()
        {
            long totalAmount = long.Parse(Console.ReadLine());
            decimal[] bottlesToFill = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            long eachbottleCapacity = long.Parse(Console.ReadLine());
            List<decimal> emptyBottles = new List<decimal>();

            if (totalAmount % 2 == 0)
            {
                for (int i = 0; i < bottlesToFill.Length; i++)
                {
                    if (bottlesToFill[i] == eachbottleCapacity)
                    {
                        continue;
                    }

                    if (bottlesToFill[i] < eachbottleCapacity)
                    {
                        decimal littersToSubstract = eachbottleCapacity - bottlesToFill[i];
                        bottlesToFill[i] += littersToSubstract;
                        totalAmount -= (long)littersToSubstract;

                        if (totalAmount < 0 || bottlesToFill[i] < eachbottleCapacity)
                        {
                            emptyBottles.Add(i);
                        }
                    }
                }

                if (totalAmount > 0)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", totalAmount);
                }
                else
                {
                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", emptyBottles.Count);
                    Console.WriteLine("With indexes: {0}", String.Join(", ", emptyBottles));
                    totalAmount = totalAmount - totalAmount - totalAmount;
                    Console.WriteLine("We need {0} more liters!", totalAmount);
                }
            }
            else
            {
                for (int i = bottlesToFill.Length - 1; i >= 0; i--)
                {
                    if (bottlesToFill[i] == eachbottleCapacity)
                    {
                        continue;
                    }

                    if (bottlesToFill[i] < eachbottleCapacity)
                    {
                        decimal littersToSubstract = eachbottleCapacity - bottlesToFill[i];
                        bottlesToFill[i] += littersToSubstract;
                        totalAmount -= (long)littersToSubstract;

                        if (totalAmount < 0 || bottlesToFill[i] < eachbottleCapacity)
                        {
                            emptyBottles.Add(i);
                        }
                    }
                }

                if (totalAmount > 0)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", totalAmount);
                }
                else
                {
                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", emptyBottles.Count);
                    Console.WriteLine("With indexes: {0}", String.Join(", ", emptyBottles));
                    totalAmount = totalAmount - totalAmount - totalAmount;
                    Console.WriteLine("We need {0} more liters!", totalAmount);
                }
            }
        }
    }
}