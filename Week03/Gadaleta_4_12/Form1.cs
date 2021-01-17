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
            GenerateDataGridView();
        }

        private void GenerateDataGridView()
        {
            this.WorkshopDataGrid.DataSource = workshops;
            this.CityDataGrid.DataSource = cities;

            this.WorkshopDataGrid.Columns["fee"].DefaultCellStyle.Format = "c";
            this.WorkshopDataGrid.Columns["Name"].Width += 20;
            this.CityDataGrid.Columns["fee"].DefaultCellStyle.Format = "c";
        }

        private void calc_total()
        {
            var city = cities[0];
            var workshop = workshops[0];

            try
            {
                city = cities[CityDataGrid.CurrentCell.RowIndex];
                workshop = workshops[WorkshopDataGrid.CurrentCell.RowIndex];
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            
            this.CityFeeTB.Text = String.Format("${0:N2}", city.Fee);
            this.WorkshopCostTB.Text = String.Format("${0:N2}", workshop.Fee);
            this.TotalTB.Text = String.Format("${0:N2}", workshop.Fee);
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            calc_total();
        }
    }
}
