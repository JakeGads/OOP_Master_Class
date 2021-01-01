 using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_10_4
{
    class Employee
    {
        public String Name { get; set; }
        public int ID { get; set; } 
        public String Department { get; set; }
        public String Position { get; set; }

        public Employee(String full_name, int id, String dept, String position)
        {
            this.Name = full_name;
            this.ID = id;
            this.Department = dept;
            this.Position = position;
        }

        public Employee()
        {
            this.Name = "";
            this.ID = 0;
            this.Department = "";
        }
    }
}
