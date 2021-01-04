using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        List<String> costs = new List<string>();
        public Form1()
        {
            InitializeComponent();
            this.Month_cb.SelectedIndex = 0;
            
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            this.Setup_Box.Enabled = false;          
            costs.Add("Misc Costs");
            this.label1.Text = "";

            for (int i = 0; i < costs.Count; i++)
            {
                // Create a GroupBox and add a TextBox to it.
                Panel panel = new Panel();
                Label label = new Label();
                TextBox textBox = new TextBox();

                textBox.Text = "$0.00";
                label.Text = this.costs[i];

                panel.Location = new Point(15, 30);
                label.Location = new Point(0, 0);
                textBox.Location = new Point(label.Text.Length + 150, 0);

                panel.Width = textBox.Width * 3;

                panel.Controls.Add(label);
                panel.Controls.Add(textBox);

                
                panel.Show();

                this.groupBox2.Controls.Add(panel);
                
                




                //textBox.Location = new Point(15, 15);
                //groupBox.Controls.Add(textBox);

                //// Set the Text and Dock properties of the GroupBox.
                //groupBox.Text = "MyGroupBox";
                //groupBox.Dock = DockStyle.Top;

                //// Disable the GroupBox (which disables all its child controls)
                //groupBox.Enabled = true;

                //// Add the Groupbox to the form.
                //this.Controls.Add(groupBox);
                //this.groupBox2.Controls.Add(groupBox);
            }

            
        }

        private void Add_Bill_Btn_Click(object sender, EventArgs e)
        {
            costs.Add(this.Add_Cost_Tf.Text);
            this.Add_Cost_Tf.Text = "";
        }
    }
}
