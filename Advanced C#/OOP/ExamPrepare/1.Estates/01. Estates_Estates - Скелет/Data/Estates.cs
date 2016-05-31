using System;
using Estates.Interfaces;

namespace Estates.Data
{
    public abstract class Estates : IEstate
    {
        private string name;
        private EstateType type;
        private double area;
        private string location;
        private bool isFurnished;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("Name cannot be less than 4 letters");
                }
                this.name = value;
            }
        }
        public double Area
        {
            get { return this.area; }
            set
            {
                if (value < 0 && value > 10000 )
                {
                    throw new ArgumentOutOfRangeException("The area cannot be less than 0 and more than 10000 square metres !");
                }
                this.area = value;
            }
        }

        public string Location
        {
            get { return this.location; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Location cannot be less than 5 letters !");
                }
                this.location = value;
            }
        }

        public bool IsFurnished { get; set; }
        public EstateType Type { get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}, Type: {1}, Area: {2}, Location: {3}, Furnished? {4}", 
                this.Name, this.Type, this.Area, this.Location, this.IsFurnished ? "Yes" : "No");
        }
    }
}
