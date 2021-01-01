using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_11_2
{
    class Employee
    {
        public String name { get; set; }
        public int number { get; set; }

        public Employee(String name, int number)
        {
            this.name = name;
            this.number = number;
        }
    }
}
