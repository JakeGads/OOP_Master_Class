using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_10_5
{
    class RetailItem
    {
        public String Description { get; set; }
        public int UnitsOnHand { get; set; }
        public double Price { get; set; }

        public RetailItem(String Description, int UnitsoOnHand, double Price)
        {
            this.Description = Description;
            this.UnitsOnHand = UnitsOnHand;
            this.Price = Price;
        }
    }
}
