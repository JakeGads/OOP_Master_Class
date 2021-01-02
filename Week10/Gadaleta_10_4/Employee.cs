 using System;
using System.Collections.Generic;
using System.Text;

namespace Gadaleta_10_4
{
    class Employee
    {
        // make members and allow them to get set
        public String Name { get; set; }
        public int ID { get; set; } 
        public String Department { get; set; }
        public String Position { get; set; }

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="full_name">the name of the employee</param>
        /// <param name="id">the employee id</param>
        /// <param name="dept">the department</param>
        /// <param name="position">the postion the employee is working in</param>
        public Employee(String full_name, int id, String dept, String position)
        {
            // assignment
            this.Name = full_name;
            this.ID = id;
            this.Department = dept;
            this.Position = position;
        }

        /// <summary>
        /// an empty constructor cause the question demanded it
        /// </summary>
        public Employee()
        {
            // assignment 
            this.Name = "";
            this.ID = 0;
            this.Department = "";
        }
    }
}
