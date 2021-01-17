using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_4_12
{
    class Workshop
    {
        public String Name { get; set; }
        public int Length { get; set; }
        public double Fee { get; set; }

        public Workshop(String name, int length, double fee)
        {
            this.Name = name;
            this.Length = length;
            this.Fee = fee;
        }

        public double get_cost(double city_cost)
        {
            return this.Fee + (city_cost * this.Fee);
        }
    }
}
