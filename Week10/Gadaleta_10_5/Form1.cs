using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_10_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // assigns the data source to a new array
            this.dataGridView1.DataSource = new RetailItem[]
            {
                new RetailItem("Jacket", 12, 59.95),
                new RetailItem("Jeans", 40, 34.95),
                new RetailItem("Shirt", 20, 24.95)
            };

            this.dataGridView1.AutoResizeColumns();
        }

        
    }
}
