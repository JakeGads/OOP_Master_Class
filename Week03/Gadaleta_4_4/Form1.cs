using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_4_4
{
    public partial class Form1 : Form
    {
        String a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Mixer_btn_Click(object sender, EventArgs e)
        {
            // text in both the clicked first and second boxes
            this.a = this.Primary_Box.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            this.b = this.Secondary_Box.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;


            if (check_color_full("red"))
            {
                // both red
                this.BackColor = Color.Red;
            }
            else if (check_color_full("blue"))
            {
                // both blue
                this.BackColor = Color.Blue;
            }
            else if (check_color_full("yellow"))
            {
                // both yellow
                this.BackColor = Color.Yellow;
            }
            else if (check_color("red") && check_color("blue"))
            {
                // checks if one is red and one is blue
                this.BackColor = Color.Purple;
            }
            else if (check_color("red") && check_color("yellow"))
            {
                // checks if one is red and one is yellow
                this.BackColor = Color.OrangeRed;
            }
            else if (check_color("blue") && check_color("yellow"))
            {
                // checks if one is blue and one is yellow
                this.BackColor = Color.Green;
            }

        }

        public bool check_color(String test)
        {
            // or means either, so if a is color or if b is color it will work properly
            return this.a.Equals(test) || this.b.Equals(test);
        }


        public bool check_color_full(String test)
        {
            // add means that it requires both a + b to be equal to whatever color was passed
            return this.a.Equals(test) && this.b.Equals(test);
        }
    }
}
