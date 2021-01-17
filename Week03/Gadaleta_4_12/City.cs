using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_4_12
{
    class City
    {
        public String Name { get; set; }
        public double Fee { get; set; }

        public City(String name, double fee)
        {
            this.Name = name;
            this.Fee = fee;
        }
    }
}
