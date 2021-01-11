using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    class advancedEmployee: baseEmployee
    {
        public double Hourly_Rate { get; set; }
        public double Hours_Worked { get; set; }

        public advancedEmployee(string Name, string Email, string Address, double Hourly_Rate, double Hours_Worked): base(Name, Email, Address)
        {
            this.Hourly_Rate = Hourly_Rate;
            this.Hours_Worked = Hours_Worked;
        }

        public advancedEmployee(): base()
        {
            this.Hourly_Rate = 0;
            this.Hours_Worked = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()}|{this.Hourly_Rate:N2}|{this.Hours_Worked:N2}";
        }
    }
}
