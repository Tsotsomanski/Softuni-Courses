using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SoftUniCoffeeSupplies
{
    public class SoftUniCoffeeSupplies
    {
        public static void Main()
        {
            string[] keyWords = Console.ReadLine().Split();
            string firstDelimiter = keyWords[0];
            string secondDelimiter = keyWords[1];

            Dictionary<string, string> personCoffeeType = new Dictionary<string, string>();
            Dictionary<string, int> coffeeTypeQuantity = new Dictionary<string, int>();
            
            string orderInfo = "";

            while (orderInfo != "end of info")
            {
                orderInfo = Console.ReadLine();

                if (orderInfo.Contains(firstDelimiter + ""))
                {
                    string[] splitedNameCoffeeType = orderInfo.Split(new[] { firstDelimiter }, StringSplitOptions.RemoveEmptyEntries);
                    personCoffeeType.Add(splitedNameCoffeeType[0], splitedNameCoffeeType[1]);
                }
                if (orderInfo.Contains(secondDelimiter + ""))
                {
                    string[] splitedCoffeeTypeQuantity = orderInfo.Split(new[] { secondDelimiter }, StringSplitOptions.RemoveEmptyEntries);

                    if (coffeeTypeQuantity.ContainsKey(splitedCoffeeTypeQuantity[0]))
                    {
                        coffeeTypeQuantity[splitedCoffeeTypeQuantity[0]] += int.Parse(splitedCoffeeTypeQuantity[1]);
                    }
                    else
                    {
                        coffeeTypeQuantity.Add(splitedCoffeeTypeQuantity[0], int.Parse(splitedCoffeeTypeQuantity[1]));
                    }
                }
            }

            Dictionary<string, int> whoAndHowMuch = new Dictionary<string, int>();
            string quantityDrinksInfo = "";

            while (quantityDrinksInfo != "end of week")
            {
                quantityDrinksInfo = Console.ReadLine();

                if (quantityDrinksInfo == "end of week")
                {
                    break;
                }

                string[] splitedQuantityInfo = quantityDrinksInfo.Split();

                if (whoAndHowMuch.ContainsKey(splitedQuantityInfo[0]))
                {
                    whoAndHowMuch[splitedQuantityInfo[0]] += int.Parse(splitedQuantityInfo[1]);
                }
                else
                {
                    whoAndHowMuch.Add(splitedQuantityInfo[0], int.Parse(splitedQuantityInfo[1]));
                }

                //Console.WriteLine("Out of {0}", entry.Key);
            }
        }
    }
}