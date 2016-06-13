using System;

namespace PCCatalog
{
    class Components
    {

        private string name;
        private string details;
        private double price;

        public Components(string name, string details, double price)
        {
            this.details = details;
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(" The name of the computer is mandatory ");
                }
                this.name = value;
            }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(" There is no details! ");
                }
                this.details = value;
            }
        }
        public double Price
        {
            get { return this.price; }

            set
            {
                if (price <= 0)
                    throw new IndexOutOfRangeException(" The price can not be missing or smaller than 1! ");
                this.price = value;
            }
        }

        public override string ToString()
        {
            string output = "component name: " + this.details;
            if (!String.IsNullOrEmpty(this.details))
            {
                output += " details: " + this.details + "\n";
            }
            else
            {
                output += " {Details are not specified !} \n ";
                output += " Component price: " + this.price + "BG\n\n ";
            }
            return output;
        }

    }
}