using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_10_4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            // assigns to the data source of an employee array 

            this.dataGridView1.DataSource = new Employee[]
                {
                    new Employee("Susan Meyers", 47899, "Accounting", "Vice President"),
                    new Employee("Mark Jones", 39199, "IT", "Programmer" ),
                    new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer")
                };
        }
    }
}
