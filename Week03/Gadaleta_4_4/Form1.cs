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


            if (both("red"))
            {
                // both red
                this.BackColor = Color.Red;
            }
            else if (both("blue"))
            {
                // both blue
                this.BackColor = Color.Blue;
            }
            else if (both("yellow"))
            {
                // both yellow
                this.BackColor = Color.Yellow;
            }
            else if (one("red") && one("blue"))
            {
                // checks if one is red and one is blue
                this.BackColor = Color.Purple;
            }
            else if (one("red") && one("yellow"))
            {
                // checks if one is red and one is yellow
                this.BackColor = Color.OrangeRed;
            }
            else if (one("blue") && one("yellow"))
            {
                // checks if one is blue and one is yellow
                this.BackColor = Color.Green;
            }

        }

        public bool one(String test)
        {
            // or means either, so if a is color or if b is color it will work properly
            return this.a.Equals(test) || this.b.Equals(test);
        }


        public bool both(String test)
        {
            // add means that it requires both a + b to be equal to whatever color was passed
            return this.a.Equals(test) && this.b.Equals(test);
        }
    }
}
