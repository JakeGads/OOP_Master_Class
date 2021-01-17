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
        // Arrays to hold class information for the datagrids
        Workshop[] workshops = new Workshop[] { new Workshop("Handling Stress", 3, 1000), new Workshop("Time Management", 3, 800), new Workshop("Supervision Skills", 3, 1500), new Workshop("How to Interview", 1, 500) };
        City[] cities = new City[] { new City("Austin", 150), new City("Chicago", 225), new City("Dallas", 175), new City("Orlando", 300), new City("Phoenix", 175), new City("Raleigh", 150) };
        public Form1()
        {
            InitializeComponent();
            GenerateDataGridView();
        }

        /// <summary>
        /// sets up and formats cells in the data grid
        /// </summary>
        private void GenerateDataGridView()
        {
            // assigns the sources
            this.WorkshopDataGrid.DataSource = workshops;
            this.CityDataGrid.DataSource = cities;

            // formats them to they are properly readable
            this.WorkshopDataGrid.Columns["fee"].DefaultCellStyle.Format = "c";
            this.WorkshopDataGrid.Columns["Name"].Width += 20; // done on the fly becuase the data has to exist first
            this.CityDataGrid.Columns["fee"].DefaultCellStyle.Format = "c";
        }

        /// <summary>
        /// fires each time the selection in either text box changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // grabs the first city as a defaulted value
            var city = cities[0];
            var workshop = workshops[0];

            // attempts to assing by checking which cell is currently clicked
            // if it fails to locate it will then default to the first city
            try
            {
                city = cities[CityDataGrid.CurrentCell.RowIndex];
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine(err);
            }

            try
            {
                workshop = workshops[WorkshopDataGrid.CurrentCell.RowIndex];
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine(err);
            }


            // update the text boxes
            this.CityFeeTB.Text = String.Format("${0:N2}", city.Fee);
            this.WorkshopCostTB.Text = String.Format("${0:N2}", workshop.Fee);
            this.TotalTB.Text = String.Format("${0:N2}", workshop.Fee);
        }
    }
}
