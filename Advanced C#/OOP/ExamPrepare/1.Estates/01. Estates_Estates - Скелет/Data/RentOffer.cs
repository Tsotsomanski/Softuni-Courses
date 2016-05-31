using System;
using Estates.Interfaces;

namespace Estates.Data
{
    class RentOffer : Offer, IRentOffer
    {
        private decimal pricePerMonth;

        public RentOffer()
        {
            base.Type = OfferType.Rent;
        }

        public decimal PricePerMonth
        {
            get { return this.pricePerMonth; }
            set
            {
                if (pricePerMonth <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price per month cannot be equal or less than 0");
                }
                this.pricePerMonth = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+ string.Format(", Prise per monh = {0}",  this.pricePerMonth);
        }
    }
}
