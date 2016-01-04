using System;
using _2.BankOfKurtovoKonare.Interfaces;

namespace _2.BankOfKurtovoKonare.Account
{
    class MortgageAcount : Account, IDeposite
    {
        public MortgageAcount(Custumer custumer, decimal balance, decimal interestRate)
            : base(custumer, balance, interestRate)
        {
            //
        }

        public override decimal CalculateInterest(int periodByMonth)
        {
            var halfInterestMonths = 0;
            switch (this.Custumer.GetType().Name)
            {
                case "IndividualCustomer":
                    halfInterestMonths = 6;
                    break;
                case "CompanyCustomer":
                    halfInterestMonths = 12;
                    break;
                default:
                    throw new NotImplementedException("This case is unknown.");
            }


            var fullInterestMonths = periodByMonth - halfInterestMonths;


            if (fullInterestMonths <= 0)
            {
                return base.CalculateInterest(halfInterestMonths)/2;
            }


            return base.CalculateInterest(halfInterestMonths)/2 + base.CalculateInterest(fullInterestMonths);
        }

    }
}
