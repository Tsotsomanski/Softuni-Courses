using System;
using Estates.Interfaces;

namespace Estates.Data
{
    class SaleOffer : Offer, ISaleOffer
    {

        private decimal price;

        public SaleOffer()
        {
            base.Type = OfferType.Sale;
            this.Price = price;
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (price <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be equal or less than 0");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Price = {0}", this.price);
        }
    }
}
