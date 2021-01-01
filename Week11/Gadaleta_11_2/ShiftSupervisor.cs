using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_11_2
{
    class ShiftSupervisor: Employee
    {
        public int shift_number { get; set; }
        public double salary { get; set; }
        public double bonus { get; set; }

        public ShiftSupervisor(String name, int number, int shift_number, double salary, double bonus): base(name, number)
        {
            this.shift_number = shift_number;
            this.salary = salary;
            this.bonus = bonus;
        }
    }
}
