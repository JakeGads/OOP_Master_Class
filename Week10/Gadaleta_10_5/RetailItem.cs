using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_10_5
{
    class RetailItem
    {
        // members as defined by the question
        public String Description { get; set; }
        public int UnitsOnHand { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// A constructor as outlined
        /// </summary>
        /// <param name="Description">the name of the item</param>
        /// <param name="UnitsOnHand">the units available</param>
        /// <param name="Price">the price</param>
        public RetailItem(String Description, int UnitsOnHand, double Price)
        {
            this.Description = Description;
            this.UnitsOnHand = UnitsOnHand;
            this.Price = Price;
        }
    }
}
