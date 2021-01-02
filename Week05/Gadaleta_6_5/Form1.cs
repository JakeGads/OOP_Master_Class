using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// takes a labels text and returns the part that is the money
        /// </summary>
        /// <param name="text">the text stored within the label</param>
        /// <returns>the numeric value stored withing</returns>
        public double label_parser(String text)
        {
            if (text.Contains("("))
            {
                // looks between the '(' and the ')' and removes `$`,`,` and `_` characters
                return Double.Parse(text.Substring(text.IndexOf("(") + 1, text.IndexOf(")") - (text.IndexOf("(") + 1)).Replace("$", "").Replace(",", "").Replace("_", ""));
            }
            // if the text is invlaid return none
            return 0;
        }

        /// <summary>
        /// takes a value from the text box and converts it to a double
        /// </summary>
        /// <param name="text">the raw text from a texbox</param>
        /// <returns>a double representing the values ina  text box</returns>
        public double text_box_parser(String text)
        {
            double value = 0;
            // if the parse works successfully it stores the value if it does not it will return 0
            Double.TryParse(text.Replace("$", "").Replace(",", "").Replace("_", ""), out value);
            return value;
        }

        /// <summary>
        /// gets the total from the oil group
        /// </summary>
        /// <returns>The total </returns>
        public double OilLubeCharges()
        {
            double total = 0; // holds the total
            // loops through every checkbox
            foreach(var i in this.Oil_Group.Controls.OfType<CheckBox>())
            {
                // if its selected
                if (i.Checked)
                {
                    // add by passing it to the label parser
                    total += label_parser(i.Text);
                }
            }
            return total;
        }

        /// <summary>
        /// gets the total from the Flush group
        /// </summary>
        /// <returns>the total from the flush group</returns>
        public double FlushCharges()
        {
            // see OilLube charges
            double total = 0;
            foreach (var i in this.Flushes_Group.Controls.OfType<CheckBox>())
            {
                if (i.Checked)
                {
                    total += label_parser(i.Text);
                }
            }
            return total;
        }

        /// <summary>
        /// The total from the misc charges
        /// </summary>
        /// <returns>a double the total misc charges</returns>
        public double MiscCharges()
        {
            double total = 0;
            foreach (var i in this.Misc_Group.Controls.OfType<CheckBox>())
            {
                if (i.Checked)
                {
                    total += label_parser(i.Text);
                }
            }
            return total;
        }

        /// <summary>
        /// the total from the other chargers
        /// </summary>
        /// <returns>the total from the other charges</returns>
        public double OtherCharges()
        {
            double total = 0;
            foreach (var i in this.Misc_Group.Controls.OfType<TextBox>())
            {
                if (!i.Text.Equals(""))
                {
                    total += text_box_parser(i.Text);
                }
            }
            return total;
        }

        /// <summary>
        /// calculates the tax on the parts
        /// </summary>
        /// <returns></returns>
        public double TaxCharges()
        {
            // parses the text box and calculates the tax
            return text_box_parser(this.Parts_tf.Text) * .06;
        }

        /// <summary>
        /// calcualtes the total for any given groupbox
        /// </summary>
        /// <param name="gb"></param>
        /// <returns></returns>
        public double GeneralCharges(GroupBox gb)
        {
            double total = 0; // starts at zero so I can +=
            foreach (var i in gb.Controls.OfType<TextBox>()) // loops through every text box
            {
                if (!i.Text.Equals("")) // excludes the empty ones
                {
                    total += text_box_parser(i.Text);
                }
            }

            foreach (var i in gb.Controls.OfType<CheckBox>()) // loops through all of the checkbox
            {
                if (i.Checked)
                {
                    total += label_parser(i.Text);
                }
            }
            return total;
        }

        /// <summary>
        /// calculates the total charges
        /// </summary>
        /// <returns>total charges</returns>
        public double TotalCharges()
        {
            double total = 0;
            // loops through each group box in order to get the charges
            foreach(var i in new GroupBox[] { this.Oil_Group, this.Flushes_Group, this.Misc_Group, this.Parts_Labour_Group })
            {
                total += GeneralCharges(i); // add the general charge back
            }
            
            return total + TaxCharges(); // return alongside the toal charges
        }
    
        /// <summary>
        /// Clears all entries in oil
        /// </summary>
        public void ClearOilLube()
        {
            foreach (var i in this.Oil_Group.Controls.OfType<CheckBox>())
            {
                i.Checked = false;
            }
        }

        /// <summary>
        /// Clears all entries in Flushes
        /// </summary>
        public void ClearFlushes()
        {
            foreach (var i in this.Flushes_Group.Controls.OfType<CheckBox>())
            {
                i.Checked = false;
            }
        }

        /// <summary>
        /// Clears all entries in Misc
        /// </summary>
        public void ClearMisc()
        {
            foreach (var i in this.Misc_Group.Controls.OfType<CheckBox>())
            {
                i.Checked = false;
            }
        }


        /// <summary>
        /// Clears all entries in Other
        /// </summary>
        public void ClearOther()
        {
            foreach (var i in this.Parts_Labour_Group.Controls.OfType<TextBox>())
            {
                i.Text = "";
            }
        }


        /// <summary>
        /// Clears all entries in Fees
        /// </summary>
        public void ClearFees()
        {
            foreach (var i in this.Parts_Labour_Group.Controls.OfType<TextBox>())
            {
                i.Text = "";
            }
        }

        /// <summary>
        /// clears the inputs in any group box
        /// </summary>
        /// <param name="gb">the targeting group box</param>
        public void GeneralClear(GroupBox gb)
        {
            foreach (var i in gb.Controls.OfType<TextBox>())
            {
                i.Text = "";
            }
            foreach (var i in gb.Controls.OfType<CheckBox>())
            {
                i.Checked = false;
            }
        }

        /// <summary>
        /// Formats and calculate all fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            this.Service_Labour_Cost_tf.Text = String.Format("${0:N2}", (GeneralCharges(this.Oil_Group) + GeneralCharges(this.Flushes_Group) + GeneralCharges(this.Misc_Group) + text_box_parser(this.Labour_tf.Text)));
            this.Parts_Cost_tf.Text = String.Format("${0:N2}", (text_box_parser(this.Parts_tf.Text)));
            this.Parts_Tax_tf.Text = String.Format("${0:N2}", TaxCharges());
            this.Total_tf.Text = String.Format("${0:N2}", TotalCharges());
        }

        /// <summary>
        /// Clear everythings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            foreach(var i in new GroupBox[] { this.Oil_Group, this.Flushes_Group, this.Misc_Group, this.Parts_Labour_Group, this.Summary_Group })
            {
                GeneralClear(i);
            }
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
