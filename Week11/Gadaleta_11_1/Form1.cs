using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_11_1
{
    public partial class Form1 : Form
    {
        List<ProductionWorker> workers = new List<ProductionWorker>();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            
            workers.Add(new ProductionWorker("Jake Gadaleta", 0, 1, 100.50));
            workers.Add(new ProductionWorker("Nick Hertzog", 1, 2, 3));
            index += 2;

            this.dataGridView1.DataSource = workers;

            
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int shift = is_shift(this.Add_Shift.Text);

            if (this.Add_Name.Text.Equals("") || is_money(this.Add_Pay.Text) || shift == 0)
            {
                MessageBox.Show(String.Format("{0}\n{0}\n{0}", this.Add_Name.Text.Equals(""), is_money(this.Add_Pay.Text), shift == 0), "Not adding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            workers.Add(new ProductionWorker(this.Add_Name.Text, index, shift, double.Parse(this.Add_Pay.Text.Replace("$", "").Replace(",", ""))));
            // this is actually how Microsoft recommends that this is done
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = workers;

        }

        private bool is_money(String text)
        {
            if(double.TryParse(text.Replace("$", "").Replace(",",""), out _))
            {
                return false;
            }

            return true;
        }

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
