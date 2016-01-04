using System;
using Estates.Interfaces;

namespace Estates.Data
{
    class Offise : BuildingEstate, IOffice
    {

        public Offise()
        {
            base.Type = EstateType.Office;
        }
    }
}
