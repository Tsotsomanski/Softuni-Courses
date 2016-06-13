using System;
namespace _2.LaptopShop
{
    class Laptop : Battery
    {
        private string model; //mandatory
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery batt;
        private double price; //mandatory


        // Constructors 

        public Laptop (string model, double price)
        {
            this.model = model;
            this.price = price;
        }

        public Laptop (string model, double price, Battery battery, string manufacturer) 
            : this(model, price)
        {
            this.batt = battery;
            this.manufacturer = manufacturer;
        }

        public Laptop(string model, double price, Battery battery, string manufacturer, string processor, int ram, string graphicsCard, string hdd, string screen)
            : this(model, price, battery, manufacturer)
        {
            this.processor = processor;
            this.ram = ram;
            this.graphicsCard = graphicsCard;
            this.hdd = hdd;
            this.screen = screen;
        }


        // Getters and Setters

        public string Model 
        {
            get{ return this.model; } 
            set
            { 
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Can nnot be empty !");
                this.model = value;
            }
        }

        public string Manufacturer 
        {
            get { return this.manufacturer; } 
            set { this.manufacturer = value; }
        }

        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Ram can't be negative number!");
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }

        public string Hdd 
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }

        public string Screen 
        {
            get { return this.screen; }
            set { this.screen = value; }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    throw new IndexOutOfRangeException("Price can't be negative !");
                this.price = value;
            }
        }

        public void addBattery(Battery battery)
        {
            this.batt = battery;
        }


        public override string ToString()
        {
            string output = "Model: " + this.model + "\n";
            if (!String.IsNullOrEmpty(this.manufacturer))
                output += "Model: " + this.manufacturer + "\n";
            if (!String.IsNullOrEmpty(this.processor))
                output += "Manufacturer: " + this.processor + "\n";
            if (this.ram != 0)
                output += "RAM: " + this.ram + " GB" + "\n";
            if (!String.IsNullOrEmpty(this.graphicsCard))
                output += "Graphic card: " + this.graphicsCard + "\n";
            if (!String.IsNullOrEmpty(this.hdd))
                output += "HDD: " + this.hdd + "\n";
            if (!String.IsNullOrEmpty(this.screen))
                output += "Screen: " + this.screen + "\n";
            output += batt + "\n";

            output+= "Price: "+ price + " lv.\n";

            return output;
        }

    }
}
