using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Gadaleta_3_12
{
    public partial class Form1 : Form
    {
        double paint_cost = 1;
        double square_footage = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Gallon_Cost_Input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(this.Gallon_Cost_Input.Text) > 0)
                {
                    paint_cost = Convert.ToDouble(this.Gallon_Cost_Input.Text);
                }
                else
                {
                    MessageBox.Show("ERROR", "Gallon must be a number greater than 0");
                }
            } catch (Exception err)
            {
                MessageBox.Show("ERROR", "Gallon must be a number greater than 0");
                this.Gallon_Cost_Input.Text = "" + 1;
                paint_cost = Convert.ToDouble(this.Gallon_Cost_Input.Text);
            }

            this.calculate();
        }

        private void Square_Footage_Input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(this.Square_Footage_Input.Text) > 0)
                {
                    square_footage = Convert.ToDouble(this.Square_Footage_Input.Text);
                }
                else
                {
                    MessageBox.Show("ERROR", "Square Footage must be a number greater than 0");
                    this.Square_Footage_Input.Text = "" + 1;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR", "Square Footage must be a number greater than 0");
                this.Square_Footage_Input.Text = "" + 1;
                square_footage = Convert.ToDouble(this.Square_Footage_Input.Text);
            }

            this.calculate();
        }

        private void calculate()
        {
            if(this.square_footage < 115)
            {
                this.square_footage = 115; // makes sure that at least one is required
            }

            double gallons = this.square_footage / 115;
            double labor = gallons * 8;
            this.paint_required_label.Text = $"{gallons} Gallons";
            this.labour_hours_label.Text = $"{labor} Hours";
            this.paint_cost_label.Text = $"${gallons * this.paint_cost}";
            this.labour_cost_label.Text = $"${labor * 20}";
            this.total_cost_label.Text = $"${String.Format("{0:0.00}", Convert.ToDouble(this.paint_cost_label.Text) + Convert.ToDouble(this.labour_cost_label.Text))}";
        }

    }
}
