 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_3_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Runs everytime text is changed, cleans the text and pastes it back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entry_TextChanged(object sender, EventArgs e)
        {
            double entry = clean_entry(this.Entry.Text);
            // formats the entire equation
            this.Output.Text = $"${String.Format("{0:N2}", entry)} ÷ 100 × 0.64 = {String.Format("{0:N2}", entry / 100 * .64)}";
        }

        private double clean_entry(string text)
        {
            // replace the money non-digit characters with empty space
            text = text.Replace("$", "").Replace(",", "").Replace("_", "");
            // Try Parse returns a boolean, we also make sure that there is some text to avoid empty stuff
            if (double.TryParse(text, out _) && text.Length > 0)
            {
                // returns the parsed double
                return Double.Parse(text);
            }
            // if its an error it just returns a 0
            return 0;
            
        }
    }
}
