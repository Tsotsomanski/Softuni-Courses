using System;
using System.Collections.Generic;

namespace PCCatalog
{
    class Computer
    {
        private string name;
        private double price = 0.0;
        List<Components> components;


        //Constructors !
        public Computer(string name, List<Components> components)
        {
            this.name = name;
            this.components = components;
        }


        //Getters and Setters !
        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can not be missing!");
                }
                this.name = value;
            }
        }

        //CalcPrice method;
        public double CalcPrice()
        {
            foreach (var component in components)
            {
                this.price += component.Price;
            }
            return this.price;
        }

        public List<Components> Components
        {
            get { return this.components; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException(" You have to add at least one component !");
                }
                this.components = value;
            }
        }
        
        
        //Methods !
        public override string ToString()
        {
            string output = "Computer name: " + this.name + "\n\n";
            foreach (var component in this.components)
            {
                output += component.ToString();
            }
            double prc = CalcPrice();
            output += "Computer pricce: " + prc + "BG\n ------------------------------------------------\n";
            return output;
        }
    }
}