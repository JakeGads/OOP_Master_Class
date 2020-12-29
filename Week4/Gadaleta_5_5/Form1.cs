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
            calc();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calc();
            calc();
        }

        private void calc()
        {
            double[] monnies = new double[(int)this.numericUpDown1.Value];
            
            this.label1.Text = monnies.Length + "";
            
            for (int i = 0; i < monnies.Length; i++)
            {
                // this.label1.Text += " " + i;
                if(i == 0)
                {
                    monnies[i] = 1;
                }
                else
                {
                    monnies[i] = monnies[i - 1] * 2;
                }
                
            }
            this.Answer_label.Text = $"${String.Format("{0:N2}", monnies.Sum() / 100)}";
        }

        private void Answer_label_Click(object sender, EventArgs e)
        {

        }
    }
}
