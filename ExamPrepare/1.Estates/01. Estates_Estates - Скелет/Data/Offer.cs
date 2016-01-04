using System;
using Estates.Interfaces;

namespace Estates.Data
{
    public abstract class Offer : IOffer
    {
        public OfferType Type { get; set; }
        public IEstate Estate { get; set; }

        public override string ToString()
        {
            return String.Format("Offer type: {0}, Estate type: {1}, Location: {2}", this.Type, this.Estate.Name, this.Estate.Location);
        }
    }
}
