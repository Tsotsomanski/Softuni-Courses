using System;

namespace Shapes
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius 
        {
            get { return this.radius; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative number !");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI*(this.Radius * this.Radius);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
        
    }
}
