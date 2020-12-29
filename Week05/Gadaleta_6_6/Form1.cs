using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_6_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double text_box_parser(String text)
        {
            double value = 0;
            Double.TryParse(text.Replace("$", "").Replace(",", ""), out value);
            return value;
        }

        public double CalcStayCharges()
        {
            return (double)this.Day_nf.Value * 350;
        }

        public double CalcMiscCharges()
        {
            double total = 0;
            foreach (var i in this.Charges_Box.Controls.OfType<TextBox>())
            {
                total += text_box_parser(i.Text);
            }

            return total;            
        }

        public double CalcTotalCharges()
        {
            return CalcStayCharges() + CalcMiscCharges();
        }

        public void Display()
        {
            this.Stay_Charges_tf.Text = String.Format("${0:N2}", CalcStayCharges());
            this.Additional_Fees_tf.Text = String.Format("${0:N2}", CalcMiscCharges());
            this.Total_tf.Text = String.Format("${0:N2}", CalcTotalCharges());
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
