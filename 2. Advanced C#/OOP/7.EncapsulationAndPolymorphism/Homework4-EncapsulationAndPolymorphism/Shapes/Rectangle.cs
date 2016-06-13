using System;

namespace Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(int width, int height) : base(width, height) { }

        public override double CalculateArea()
        {
            return (this.Width * this.Height);
        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.Width + this.Height);
        }

        public override string ToString()
        {
            return String.Format("Rectangle area: {0}; Rectangle perimeter: {1}", this.CalculateArea(), this.CalculatePerimeter());
        }
    }
}
