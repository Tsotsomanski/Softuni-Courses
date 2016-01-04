using System;

namespace _2.BankOfKurtovoKonare.Account
{
    abstract class Account
    {
        private Custumer custumer;
        private decimal balance;
        private decimal interestRate;

        public Account(Custumer custumer, decimal balance, decimal interestRate)
        {
            this.Custumer = custumer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Custumer Custumer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }


        public virtual decimal CalculateInterest(int periodInMonth)
        {
            var interest = this.balance*(1 + this.interestRate*periodInMonth);
            return interest;
        }

        public void DepositeSum(decimal sum)
        {
            this.Balance += sum;
        }
    }
}
