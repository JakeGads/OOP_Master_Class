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

        public Form1()
        {
            InitializeComponent();
        }

        private void Gallon_Cost_Input_TextChanged(object sender, EventArgs e)
        {
            if (check_valid_text(this.Gallon_Cost_Input.Text))
            {
                calculate();
            }
            else
            {
                this.Gallon_Cost_Input.Text = "" + 1;
                calculate();
            }
        }

        private void Square_Footage_Input_TextChanged(object sender, EventArgs e)
        {
            if (check_valid_text(this.Square_Footage_Input.Text))
            {
                calculate();
            }
            else
            {
                this.Square_Footage_Input.Text = "" + 1;
                calculate();
            }
        }
        
        /// <summary>
        /// checks if all the characters in a String are numeric
        /// </summary>
        /// <param name="entry">
        /// the string should be Textbox.Text
        /// </param>
        /// <returns>
        /// booelan ednoting if the regex is matched
        /// </returns>
        private bool check_valid_text(String entry)
        {
            return entry.All(char.IsDigit) && entry.Length > 0;
        }

        private String ez_format(double x)
        {
            return String.Format("{0:0.00}", x);
        }

        private void calculate()
        {
            double gallon_cost, square_footage;

            if(check_valid_text(this.Square_Footage_Input.Text) && Double.Parse(this.Square_Footage_Input.Text) > 115)
            {
                square_footage = Double.Parse(this.Square_Footage_Input.Text);
            }
            else
            {
                square_footage = 115;
            }

            if (check_valid_text(this.Gallon_Cost_Input.Text) && Double.Parse(this.Gallon_Cost_Input.Text) > 0)
            {
                gallon_cost = Double.Parse(this.Gallon_Cost_Input.Text);
            }
            else
            {
                gallon_cost = 1;
            }

            double required_gallon = square_footage / 115;
            double required_hours = required_gallon * 8;
            double paint_cost = required_gallon * gallon_cost;
            double labour_cost = required_hours * 20;
            double total = paint_cost + labour_cost;

            this.paint_required_label.Text =  $" {ez_format(required_gallon)} Gallons";
            this.labour_hours_label.Text = $" {ez_format(required_hours)} Hours";
            this.paint_cost_label.Text = $"${ez_format(paint_cost)}";
            this.labour_cost_label.Text = $"${ez_format(labour_cost)}";
            this.total_cost_label.Text = $"${ez_format(total)}";
        }
    }
}
