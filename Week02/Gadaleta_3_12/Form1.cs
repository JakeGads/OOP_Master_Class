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

        /// <summary>
        /// Runs everytime text is changed in the gallon input
        /// checks to see if it is valid money before passing it to a general function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gallon_Cost_Input_TextChanged(object sender, EventArgs e)
        {
            if (check_valid_text(this.Gallon_Cost_Input.Text))
            {
                // if the text is valid move forward to calculate
                calculate();
            }
            else
            {
                // make the text valid and then 
                this.Gallon_Cost_Input.Text = "" + 1;
                calculate();
            }
        }

        /// <summary>
        /// Runs every time there is a text change to teh square footage input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Square_Footage_Input_TextChanged(object sender, EventArgs e)
        {
            // checks for validity
            if (check_valid_text(this.Square_Footage_Input.Text))
            {
                // reups the data
                calculate();
            }
            else
            {
                // force valid
                this.Square_Footage_Input.Text = "" + 1;
                // reups the data
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
            entry = entry.Replace("$", "").Replace(",", "");
            return entry.All(char.IsDigit) && entry.Length > 0;
        }

        private String ez_format(double x)
        {
            return String.Format("{0:0.00}", x);
        }

        private void calculate()
        {
            double gallon_cost, square_footage;

            // checking one more time (becuase it can reach this point by changing either value
            // also setting a default of 115 becuase you can't buy less than 1 gallon of paint
            if(check_valid_text(this.Square_Footage_Input.Text) && Double.Parse(this.Square_Footage_Input.Text) > 115)
            {
                square_footage = Double.Parse(this.Square_Footage_Input.Text);
            }
            else
            {
                square_footage = 115;
            }

            // checking one more time (becuase it can reach this point by changing either value
            if (check_valid_text(this.Gallon_Cost_Input.Text) && Double.Parse(this.Gallon_Cost_Input.Text.Replace("$", "").Replace(",", "")) > 0)
            {
                gallon_cost = Double.Parse(this.Gallon_Cost_Input.Text);
            }
            else
            {
                gallon_cost = 1;
            }

            // the math
            double required_gallon = square_footage / 115;
            double required_hours = required_gallon * 8;
            double paint_cost = required_gallon * gallon_cost;
            double labour_cost = required_hours * 20;
            double total = paint_cost + labour_cost;

            // Assignment
            this.paint_required_label.Text =  $" {ez_format(required_gallon)} Gallons";
            this.labour_hours_label.Text = $" {ez_format(required_hours)} Hours";
            this.paint_cost_label.Text = $"${ez_format(paint_cost)}";
            this.labour_cost_label.Text = $"${ez_format(labour_cost)}";
            this.total_cost_label.Text = $"${ez_format(total)}";
        }
    }
}
