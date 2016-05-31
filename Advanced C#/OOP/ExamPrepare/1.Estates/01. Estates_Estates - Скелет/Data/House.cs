using System;
using Estates.Interfaces;

namespace Estates.Data
{
    class House : Estates, IHouse
    {
        private int floors;

        public House()
        {
            base.Type = EstateType.House;
        }

        public int Floors
        {
            get { return this.floors; }
            set
            {
                if (value < 0 && value > 10)
                {
                    throw new ArgumentOutOfRangeException("The number of floors should be in the interval from 0 to 10 !");
                }
                this.floors = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Floors: {0}", this.floors);
        }
    }
}
