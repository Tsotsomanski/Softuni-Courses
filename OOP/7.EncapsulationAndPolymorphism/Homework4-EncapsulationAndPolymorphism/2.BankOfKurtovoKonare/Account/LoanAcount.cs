using System;
using _2.BankOfKurtovoKonare.Interfaces;
using _2.BankOfKurtovoKonare.Account;

namespace _2.BankOfKurtovoKonare.Account
{
    class LoanAcount : Account, IDeposite
    {
        public static double interest;

        public LoanAcount(Custumer custumer, decimal balance, decimal interestRate)
            : base(custumer, balance, interestRate)
        {
            //
        }

        public override decimal CalculateInterest(int periodInMonth)
        {
            var monthInterestFree = 0;
            switch (this.Custumer.GetType().Name)
            {
                case "IndividualCustumer":
                    monthInterestFree = 3;
                    break;
                case "CompanyCustumer":
                    monthInterestFree = 2;
                    break;
                default:
                    throw new NotImplementedException("This case is unknown");
            }
            if (periodInMonth <= monthInterestFree)
            {
                return 0m;
            }
            return base.CalculateInterest(periodInMonth - monthInterestFree);
        }
    }
}
