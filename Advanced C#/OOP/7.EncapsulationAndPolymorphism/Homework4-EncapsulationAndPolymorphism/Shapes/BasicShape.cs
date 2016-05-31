using System;
namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private int width;
        private int height;

        public BasicShape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }


        public int Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative number !");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative number !");
                }
                this.height = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
