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
        String primary, secondary;
        public Form1()
        {
            InitializeComponent();
        }

        private void Mixer_btn_Click(object sender, EventArgs e)
        {
            this.primary = this.Primary_Box.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            this.secondary = this.Secondary_Box.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

            if (check_color_full("red"))
            {
                this.BackColor = Color.Red;
            }
            else if (check_color_full("blue"))
            {
                this.BackColor = Color.Blue;
            }
            else if (check_color_full("yellow"))
            {
                this.BackColor = Color.Yellow;
            }
            else if (check_color("red") && check_color("blue"))
            {
                this.BackColor = Color.Purple;
            }
            else if (check_color("red") && check_color("yellow"))
            {
                this.BackColor = Color.OrangeRed;
            }
            else if (check_color("blue") && check_color("yellow"))
            {
                this.BackColor = Color.Green;
            }

        }

        public bool check_color(String test)
        {
            return this.primary.Equals(test) || this.secondary.Equals(test);
        }


        public bool check_color_full(String test)
        {
            return this.primary.Equals(test) && this.secondary.Equals(test);
        }
    }
}
