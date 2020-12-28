using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the first box is clicked, generates text and an active alert notifying the update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "One";
            MessageBox.Show("One", "One");
        }

        /// <summary>
        /// When the second box is clicked, generates text and an active alert notifying the update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Two";
            MessageBox.Show("Two", "Two");
        }

        /// <summary>
        /// When the third box is clicked, generates text and an active alert notifying the update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Three";
            MessageBox.Show("Three", "Three");
        }

        /// <summary>
        /// When the four box is clicked, generates text and an active alert notifying the update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Four";
            MessageBox.Show("Four", "Four");
        }

        /// <summary>
        /// When the 5th box is clicked, generates text and an active alert notifying the update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Five";
            MessageBox.Show("Five", "Five");
        }
    }
}
