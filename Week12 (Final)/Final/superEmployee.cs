using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    enum permission_level { low, meduim, high }
    class superEmployee: advancedEmployee
    {
        public permission_level Permission_Level { get; set; }
        private string enum_as_string;
        // used as a string becuase I can't do math to it
        // also to allow for weird office numbers like B23 (basment 23)
        public string Office_Number { get; set; }

        public superEmployee(string Name, string Email, string Address, double Hourly_Rate, double Hours_Worked, permission_level permission_Level, string Office_Number):base(Name, Email, Address, Hourly_Rate, Hours_Worked)
        {
            this.Permission_Level = Permission_Level;
            if(this.Permission_Level == permission_level.high)
            {
                this.enum_as_string = "high";
            }
            else if (this.Permission_Level == permission_level.meduim)
            {
                this.enum_as_string = "meduim";
            }
            else
            {
                this.enum_as_string = "low"; 
            }
            this.Office_Number = Office_Number;
        }

        public superEmployee(): base()
        {
            this.Permission_Level = permission_level.low;
            this.Office_Number = "0";
        }

        public override string ToString()
        {
            return $"{base.ToString()}|{this.enum_as_string}|{this.Office_Number}";
        }
    }
}
