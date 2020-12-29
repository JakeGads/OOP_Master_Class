using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_5_11
{
    public partial class Form1 : Form
    {
        int count = 0;
        int rand = 0;
        public Form1()
        {
            InitializeComponent();
            rand = new Random().Next(100);
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(this.Guess_box.Text);
            if(guess < rand)
            {
                this.Hint.Text = $"{guess} is too low";
                

            }
            else if (guess > rand)
            {
                this.Hint.Text = $"{guess} is too high";
              
            }
            else
            {
                this.Hint.Text = $"You got it right!!\nIt took {count} tries";
            }
            count += 1;
        }
    }
}
