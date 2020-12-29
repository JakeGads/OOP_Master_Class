using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_4_12
{
    public partial class Form1 : Form
    {
        Workshop[] workshops = new Workshop[] { new Workshop("Handling Stress", 3, 1000), new Workshop("Time Management", 3, 800), new Workshop("Supervision Skills", 3, 1500), new Workshop("How to Interview", 1, 500) };
        City[] cities = new City[] { new City("Austin", 150), new City("Chicago", 225), new City("Dallas", 175), new City("Orlando", 300), new City("Phoenix", 175), new City("Raleigh", 150) };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void create_workshop_chart(DataGridView dg, Workshop[] workshops)
        {
            for (int i = 0; i < workshops.Length; i++)
            {
                var bttn = new DataGridViewButtonCell();
                dg.Rows[i].Cells[0] = bttn;
                dg.Rows[i].Cells[1].Tag = workshops[i].name;
                dg.Rows[i].Cells[2].Tag = workshops[i].length;
                dg.Rows[i].Cells[3].Tag = workshops[i].fee;
            }
        }
    }
}
