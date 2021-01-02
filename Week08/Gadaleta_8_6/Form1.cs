using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_8_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// splits on capitals and assigns the new string to teh out text feild
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void in_tf_TextChanged(object sender, EventArgs e)
        {
            // regex was tested here https://regex101.com/r/JbDXps/2
            // splits on capital 
            string[] split = Regex.Split(this.in_tf.Text, @"(?<!^)(?=[A-Z])");
            // seperated so it pulls out the first w/ the capital
            this.out_tf.Text = split[0];

            // loops through the remainder
            for(int i = 1; i < split.Length; i++)
            {
                // adds a space and lowercases the answer
                this.out_tf.Text += " " + split[i].ToLower();
            }

        }
    }
}
