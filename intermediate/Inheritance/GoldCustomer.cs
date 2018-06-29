using System;

namespace Inheritance
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true);
            
        }
    }
}