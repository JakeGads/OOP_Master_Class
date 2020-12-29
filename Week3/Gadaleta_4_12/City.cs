using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_4_12
{
    class City
    {
        public String name { get; set; }
        public double fee { get; set; }

        public City(String name, double fee)
        {
            this.name = name;
            this.fee = fee;
        }
    }
}
