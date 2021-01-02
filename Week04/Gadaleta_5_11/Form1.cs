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
        int count = 0; // holds how many times an answer was attempted
        int rand = 0; // holds the randomized value
        public Form1()
        {
            InitializeComponent();
            rand = new Random().Next(100); // makes a random number
        }

        /// <summary>
        /// Fires when cliked checks to see how accurate the guess was
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            // parsing out the guess
            int guess = int.Parse(this.Guess_box.Text);
            count += 1;
            // adjusting the hint
            if (guess < rand)
            {
                this.Hint.Text = $"{guess} is too low";
            }
            else if (guess > rand)
            {
                this.Hint.Text = $"{guess} is too high";
              
            }
            else
            {
                // notifing when the use is correct
                this.Hint.Text = $"You got it right!!\nIt took {count} tries";
            }
            // checking how many entires were attempted
            
        }
    }
}
