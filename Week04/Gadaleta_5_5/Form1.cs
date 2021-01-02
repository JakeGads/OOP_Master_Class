using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // jumps to calc right away to check the intial
            calc();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // uses this secondary function so that the constructor can have access to it as well
            calc();
        }

        private void calc()
        {
            // an array to store the values per day, everything is stored in terms of pennies
            double[] daily_gains = new double[(int)this.numericUpDown1.Value];


            // loops through and does some math
            for (int i = 0; i < daily_gains.Length; i++)
            {
                // if this is the intial run
                if (i == 0)
                {
                    // set the default value to one, becuase we can't reach back
                    daily_gains[i] = 1;
                }
                else
                {
                    // reaches to the previous value and double it
                    daily_gains[i] = daily_gains[i - 1] * 2;
                }

            }
            // sums and then divdes by zero becuase it penny to $
            this.Answer_label.Text = $"${String.Format("{0:N2}", daily_gains.Sum() / 100)}";
        }

    }
}
