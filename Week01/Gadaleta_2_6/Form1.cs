using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_2_6
{
    public partial class Form1 : Form
    {
        Label[] labels;
        
        public Form1()
        {
            InitializeComponent();
            // Auto setting the labels
            this.label1.Text = "Betelgeuse";
            this.label2.Text = "Meissa";
            this.label3.Text = "Alnitak";
            this.label4.Text = "Alnilam";
            this.label5.Text = "Mintaka";
            this.label6.Text = "Saiph";
            this.label7.Text = "Rigel";
            // assiging the labels as an array so that they can be later used in foreach loops
            labels = new Label[]{ this.label1, this.label2, this.label3, this.label4, this.label5, this.label6, this.label7};
        }

        private void Show_Click(object sender, EventArgs e)
        {
            // loops through all the labels and sets them as true hence making them visable
            foreach(var i in labels)
            {
                i.Visible = true;
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            // loops through and hides all the labels
            foreach (var i in labels)
            {
                i.Visible = false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // forces an exit
            Environment.Exit(0);
        }
    }
}
