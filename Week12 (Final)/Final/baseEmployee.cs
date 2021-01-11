using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    class baseEmployee
    {
        public string Name { get; set;}
        public string Email { get; set; }
        public string Address { get; set; }

        public baseEmployee(string Name, string Email, string Address)
        {
            this.Name = Name;
            this.Email = Email;
            this.Address = Address;
        }

        public baseEmployee()
        {
            this.Name = "";
            this.Email = "";
            this.Address = "";
        }

        public override string ToString()
        {
            return $"{this.Name}|{this.Email}|{this.Address}";
        }
    }
}
