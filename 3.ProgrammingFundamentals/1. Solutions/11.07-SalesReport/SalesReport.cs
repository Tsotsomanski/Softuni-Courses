using System;
using System.Collections.Generic;

namespace _10._07_SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            int numOfSales = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>(numOfSales);

            for (int i = 0; i < numOfSales; i++)
            {
                var sale = ReadSale();
                sales.Add(sale);
            }
            
            var towns = new SortedSet<string>();
            var sums = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                towns.Add(sale.Town);
                sums[sale.Town] = 0;
            }

            foreach (var sale in sales)
            {
                sums[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var t in towns)
            {
                Console.WriteLine("{0} -> {1:f2}", t, sums[t]);
            }
        }

        public static Sale ReadSale()
        {
            var tokens = Console.ReadLine().Split(' ');
            string town = tokens[0];
            string product = tokens[1];
            decimal price = decimal.Parse(tokens[2]);
            decimal quantity = decimal.Parse(tokens[3]);

            Sale currentSale = new Sale() { Town = town, Product = product, Price = price, Quantity = quantity };
            return currentSale;
        }
    }
}

public class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}