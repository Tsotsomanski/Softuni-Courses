namespace ProspectInHospitality
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter amount of builders: ");
            int buildersAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of receptionists: ");
            int receptionistsAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of chambermaids: ");
            int chambermaidsAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of technicans: ");
            int techniciansAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of other stuff: ");
            int otherStufAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Nicki's salary in dollars: ");
            decimal nickisSalaryInDollars = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the current currency rate: ");
            float currencyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your salary: ");
            decimal mySalary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the available budget: ");
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal buildersSalaryInLeva = 1500.4m;
            decimal receptionistSalaryInLeva = 2102.10m;
            decimal chambermaidsSalaryInLeva = 1465.46m;
            decimal technicansSalaryInLeva = 2053.33m;
            decimal othersStaffSalaryInLeva = 3010.98m;
            decimal nickisSalaryInLeva = nickisSalaryInDollars * (decimal)currencyRate;

            decimal salarySum = buildersAmount*buildersSalaryInLeva +
                              receptionistsAmount*receptionistSalaryInLeva +
                              chambermaidsAmount*chambermaidsSalaryInLeva +
                              techniciansAmount*technicansSalaryInLeva +
                              otherStufAmount*othersStaffSalaryInLeva +
                              nickisSalaryInLeva + mySalary;

            Console.WriteLine();
            Console.WriteLine("The amount is: {0:0.00} lv.", salarySum);

            decimal leftAmount = budget - salarySum;
            decimal needAmount = salarySum - budget;

            if (budget > salarySum)
            {
                Console.WriteLine(@"YES \ Left: {0:0.00} lv.", leftAmount);
            }

            else
            {
                Console.WriteLine(@"NO \ Need more: {0:0.00} lv.", needAmount);
            }
        }
    }
}
