using System;
using System.Globalization;

public class SoftUniCoffeeOrders
{
    public static void Main()
    {
        int numOfOrders = int.Parse(Console.ReadLine());
        decimal priceAfterDiscount = 0;
        decimal total = 0;

        for (int i = 0; i < numOfOrders; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            decimal capsulesCount = decimal.Parse(Console.ReadLine());
            decimal daysInMonth = System.DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
            priceAfterDiscount = (daysInMonth * capsulesCount) * pricePerCapsule;
            total += priceAfterDiscount;
            Console.WriteLine("The price for the coffee is: ${0:f2}", priceAfterDiscount);
        }

        Console.WriteLine("Total: ${0:f2}", total);
    }
}