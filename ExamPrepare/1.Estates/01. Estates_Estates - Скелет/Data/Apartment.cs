using System;
using Estates.Interfaces;

namespace Estates.Data
{
    class Apartment : BuildingEstate, IApartment
    {
        public Apartment()
        {
            base.Type = EstateType.Apartment;
        }
    }
}
