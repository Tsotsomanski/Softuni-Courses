using System;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(string firstName, string lastName, string id, decimal netPurchaseAmount) 
            : base(firstName, lastName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Net purchase amount must be possitive number !");
                }
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Custumer: " + this.FirstName + "" + this.LastName + "\nID: " + this.Id + "\nSpent: " + this.NetPurchaseAmount + " BGN");
        }
    }
}
