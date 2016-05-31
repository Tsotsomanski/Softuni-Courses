using System;
using Estates.Interfaces;

namespace Estates.Data
{
    public abstract class BuildingEstate : Estates, IBuildingEstate
    {
        private int rooms;
        private bool hasElevator;

        public int Rooms
        {
            get { return this.rooms; }
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("The number of rooms should be in the interval from 0 to 20 !");
                }
                this.rooms = value;
            }
        }

        //
        public bool HasElevator { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Rooms: {0}, Elevator: {1}", this.Rooms, this.HasElevator ? "Yes" : "No");
        }
    }
}
