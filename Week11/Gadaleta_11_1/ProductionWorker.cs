using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_11_1
{
    class ProductionWorker: Employee
    {
        public int shift_number { get; set; }
        public double payrate { get; set; }

        public ProductionWorker(String name, int number, int shift_number, double payrate): base(name, number)
        {
            this.shift_number = shift_number;
            this.payrate = payrate;
        }
    }
}
