using System;
using _2.BankOfKurtovoKonare.Account;

namespace _2.BankOfKurtovoKonare
{
    class Program
    {
        static void Main()
        {
            Custumer peter = new IndividualCustumer("Peter", "9006052990");
            Custumer softUni = new CompanyCustumer("SoftUni", "BG92813412");
            Account.Account petterDeposiAccount = new DepositAcount(peter, 15000, 7);
            Account.Account softUniLoanAccount = new LoanAcount(softUni, 50000, 3);

            Console.WriteLine(petterDeposiAccount.CalculateInterest(12).ToString("f2"));
            Console.WriteLine();
            Console.WriteLine(softUniLoanAccount.CalculateInterest(4).ToString("f2"));
        }
    }
}
