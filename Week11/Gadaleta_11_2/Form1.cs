using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_11_2
{
    public partial class Form1 : Form
    {
        // Dynamic sized array to hold the workers
        List<ShiftSupervisor> workers = new List<ShiftSupervisor>();
        int index = 0; // worker index
        public Form1()
        {
            InitializeComponent();

            // adds two workers and increases the array
            workers.Add(new ShiftSupervisor("Jake Gadaleta", 0, 1, 1000000, 50));
            workers.Add(new ShiftSupervisor("Nick Hertzog", 1, 2, 10, 5));
            index += 2;

            // sets the datagrid source
            this.dataGridView1.DataSource = workers;

            
            
        }

        /// <summary>
        /// Adds a new worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Submit_Click(object sender, EventArgs e)
        {
            int shift = is_shift(this.Add_Shift.Text);

            // checks if all fields are valid

            if (this.Add_Name.Text.Equals("") || is_money(this.Add_Pay.Text) || is_money(this.Add_Bonus.Text)|| shift == 0)
            {
                // debug message
                // MessageBox.Show(String.Format("{0}\n{0}\n{0}", this.Add_Name.Text.Equals(""), is_money(this.Add_Pay.Text), shift == 0), "Not adding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // adds a new production worker
            workers.Add(new ShiftSupervisor(this.Add_Name.Text, index, shift, double.Parse(this.Add_Pay.Text.Replace("$", "").Replace(",", "")), double.Parse(this.Add_Bonus.Text.Replace("$", "").Replace(",", ""))));
            
            // reups the data source
            // this is actually how Microsoft recommends that this is done
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = workers;

        }

        /// <summary>
        /// Verifys that it is valid money being entered
        /// </summary>
        /// <param name="text"></param>
        /// <returns>the validity</returns>
        private bool is_money(String text)
        {
            if(double.TryParse(text.Replace("$", "").Replace(",",""), out _))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// tests to see if the text is shift
        /// </summary>
        /// <param name="text">the inner text from the text feild</param>
        /// <returns>the validity</returns>
        private int is_shift(String text)
        {
            if(int.TryParse(text, out _))
            {
                return int.Parse(text);
            }

            if (text.ToLower().Equals("day"))
            {
                return 1;
            }
            else if (text.ToLower().Equals("night"))
            {
                return 2;
            }

            return 0;

        }
    }
}
