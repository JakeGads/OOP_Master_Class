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

        private void in_tf_TextChanged(object sender, EventArgs e)
        {
            string[] split = Regex.Split(this.in_tf.Text, @"(?<!^)(?=[A-Z])");
            this.out_tf.Text = split[0];

            for(int i = 1; i < split.Length; i++)
            {
                this.out_tf.Text += " " + split[i].ToLower();
            }

        }
    }
}
