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

        /// <summary>
        /// parses out the text_box information
        /// </summary>
        /// <param name="text">the contents of a text box</param>
        /// <returns>a double from the text box</returns>
        public double text_box_parser(String text)
        {
            double value = 0;
            Double.TryParse(text.Replace("$", "").Replace(",", "").Replace("_", ""), out value);
            return value;
        }

        /// <summary>
        /// Gets the value form the Day number feild and clacules the cost
        /// </summary>
        /// <returns>cost of stay</returns>
        public double CalcStayCharges()
        {
            // converts it to a double before multiplying
            return (double)this.Day_nf.Value * 350;
        }

        /// <summary>
        /// Gets the other data
        /// </summary>
        /// <returns>the misc charges</returns>
        public double CalcMiscCharges()
        {

            double total = 0;
            foreach (var i in this.Charges_Box.Controls.OfType<TextBox>()) // loops through
            {
                total += text_box_parser(i.Text); // parses and then returns it back
            }

            return total;            
        }

        /// <summary>
        /// Calculates all Charges
        /// </summary>
        /// <returns>a double of the total cost</returns>
        public double CalcTotalCharges()
        {
            return CalcStayCharges() + CalcMiscCharges();
        }

        /// <summary>
        /// Updates the display by formating and cacluating the feild
        /// </summary>
        public void Display()
        {
            this.Stay_Charges_tf.Text = String.Format("${0:N2}", CalcStayCharges());
            this.Additional_Fees_tf.Text = String.Format("${0:N2}", CalcMiscCharges());
            this.Total_tf.Text = String.Format("${0:N2}", CalcTotalCharges());
        }

        /// <summary>
        /// runs the display method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
