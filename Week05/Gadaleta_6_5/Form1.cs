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

        public double label_parser(String text)
        {
            if (text.Contains("("))
            {
                return Double.Parse(text.Substring(text.IndexOf("(") + 1, text.IndexOf(")") - (text.IndexOf("(") + 1)).Replace("$", ""));
            }

            return 0;
        }

        public double text_box_parser(String text)
        {
            double value = 0;
            Double.TryParse(text.Replace("$", "").Replace(",", ""), out value);
            return value;
        }

        public double OilLubeCharges()
        {
            double total = 0;
            foreach(var i in this.Oil_Group.Controls.OfType<CheckBox>())
            {
                if (i.Checked)
                {
                    total += label_parser(i.Text);
                }
            }
            return total;
        }

        public double FlushCharges()
        {
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

        public double TaxCharges()
        {
            return text_box_parser(this.Parts_tf.Text) * .06;
        }

        public double GeneralCharges(GroupBox gb)
        {
            double total = 0;
            foreach (var i in gb.Controls.OfType<TextBox>())
            {
                if (!i.Text.Equals(""))
                {
                    total += text_box_parser(i.Text);
                }
            }

            foreach (var i in gb.Controls.OfType<CheckBox>())
            {
                if (i.Checked)
                {
                    total += label_parser(i.Text);
                }
            }
            return total;
        }

        public double TotalCharges()
        {
            double total = 0;
            foreach(var i in new GroupBox[] { this.Oil_Group, this.Flushes_Group, this.Misc_Group, this.Parts_Labour_Group })
            {
                total += GeneralCharges(i);
            }
            
            return total + TaxCharges();
        }
    
        public void ClearOilLube()
        {
            foreach (var i in this.Oil_Group.Controls.OfType<CheckBox>())
            {
                i.Checked = false;
            }
        }

        public void ClearFlushes()
        {
            foreach (var i in this.Flushes_Group.Controls.OfType<CheckBox>())
            {
                i.Checked = false;
            }
        }

        public void ClearMisc()
        {
            foreach (var i in this.Misc_Group.Controls.OfType<CheckBox>())
            {
                i.Checked = false;
            }
        }

        public void ClearOther()
        {
            foreach (var i in this.Parts_Labour_Group.Controls.OfType<TextBox>())
            {
                i.Text = "";
            }
        }

        public void ClearFees()
        {
            foreach (var i in this.Parts_Labour_Group.Controls.OfType<TextBox>())
            {
                i.Text = "";
            }
        }

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

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            this.Service_Labour_Cost_tf.Text = String.Format("${0:N2}", (GeneralCharges(this.Oil_Group) + GeneralCharges(this.Flushes_Group) + GeneralCharges(this.Misc_Group) + text_box_parser(this.Labour_tf.Text)));
            this.Parts_Cost_tf.Text = String.Format("${0:N2}", (text_box_parser(this.Parts_tf.Text)));
            this.Parts_Tax_tf.Text = String.Format("${0:N2}", TaxCharges());
            this.Total_tf.Text = String.Format("${0:N2}", TotalCharges());
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            foreach(var i in new GroupBox[] { this.Oil_Group, this.Flushes_Group, this.Misc_Group, this.Parts_Labour_Group, this.Summary_Group })
            {
                GeneralClear(i);
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
