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

        private void Entry_TextChanged(object sender, EventArgs e)
        {
            double entry = clean_entry(this.Entry.Text);
            this.Output.Text = $"${String.Format("{0:N2}", entry)} ÷ 100 × 0.64 = {String.Format("{0:N2}", entry / 100 * .64)}";
        }

        private double clean_entry(string text)
        {
            text = text.Replace("$", "").Replace(",", "").Replace("_", "");
            if (double.TryParse(text, out _) && text.Length > 0)
            {
                return Double.Parse(text);
            }
            return 0;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
