using System;
using System.Diagnostics.CodeAnalysis;
using _2.BankOfKurtovoKonare.Interfaces;

namespace _2.BankOfKurtovoKonare.Account
{
    class DepositAcount : Account,IDeposite, IWithdraw
    {
        public static double interest;
        public DepositAcount(Custumer custumer, decimal balance, decimal interestRate)
            : base(custumer, balance, interestRate)
        {
            //
        }

        public void WithDrawSum(decimal sum)
        {
            if (this.Balance < sum)
            {
                throw new ArithmeticException("Insufficient amount.");
            }
            this.Balance = -sum;
        }

        public override decimal CalculateInterest(int periodInMonth)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            
            return base.CalculateInterest(periodInMonth);
        }
    }
}
