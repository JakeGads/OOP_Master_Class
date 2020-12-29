using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_4_12
{
    class Workshop
    {
        public String name { get; set; }
        public int length { get; set; }
        public double fee { get; set; }

        public Workshop(String name, int length, double fee)
        {
            this.name = name;
            this.length = length;
            this.fee = fee;
        }

        public double get_cost(double city_cost)
        {
            return this.fee + (city_cost * this.fee);
        }
    }
}
