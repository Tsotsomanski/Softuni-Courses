using System;

namespace ProgrammingFundamentalsSampleExamII
{
    public class SoftUniAirline
    {
        public static void Main()
        {
            int numberOfFlys = int.Parse(Console.ReadLine());
            decimal profit = 0;
            decimal bestProfit = 0;
            decimal averageProfit = 0;

            for (int i = 0; i < numberOfFlys; i++)
            {
                int adultPassengersCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthPassengersCount = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                decimal flightDuration = decimal.Parse(Console.ReadLine());

                decimal income = (adultPassengersCount * adultTicketPrice) + (youthPassengersCount * youthTicketPrice);
                decimal expenses = flightDuration * (fuelConsumptionPerHour * fuelPricePerHour);
                
                if (income >= expenses)
                {
                    profit = income - expenses;
                    Console.WriteLine("You are ahead with {0:0.000}$.", profit);

                    if (profit > bestProfit)
                    {
                        bestProfit = profit;
                    }

                    averageProfit += profit;
                }

                if (expenses > income)
                {
                    profit = income - expenses;
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:0.000}$.", profit);

                    if (profit > bestProfit)
                    {
                        bestProfit = profit;
                    }

                    averageProfit += profit;
                }
            }

            Console.WriteLine("Overall profit -> {0:0.000}$.", averageProfit);
            Console.WriteLine("Average profit -> {0:0.000}$.", averageProfit / numberOfFlys);
        }
    }
}