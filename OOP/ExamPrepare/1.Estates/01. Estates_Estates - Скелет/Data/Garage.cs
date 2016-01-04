using System;
using Estates.Engine;
using Estates.Interfaces;

namespace Estates.Data
{
    class Garage : Estates, IGarage
    {
        private int width;
        private int height;

        public Garage()
        {
            base.Type = EstateType.Garage;
        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value < 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException("Width should be in the interval from 0 to 500 !");
                }
                this.width = value;
            }
            
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                if (value < 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException("Height should be in the interval from 0 to 500 !");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Width: {0}, Height: {1}", this.Width, this.Height);
        }
    }
}
