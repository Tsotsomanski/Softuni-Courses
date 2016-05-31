using System;

namespace _3.CompanyHierarchy
{
    class Sale
    {
        private string productName;
        private DateTime soldOn;
        private decimal price;

        public Sale(string productName, DateTime soldOn, decimal price)
        {
            this.ProductName = productName;
            this.SoldOn = soldOn;
            this.Price = price;
        }


        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product name cannot be empty !");
                }
                this.productName = value;
            }
        }
        public DateTime SoldOn { get; set; }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative number !");
                }
                this.price = value;
            }
        }


        public override string ToString()
        {
            return String.Format("Sale: " + this.ProductName + " Sold on: " + this.SoldOn.ToString() + " Price: " + this.Price);
        }
    }
}
