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
        
        Dictionary<String, double> monthly_values = new Dictionary<string, double>();
        public Form1()
        {
            InitializeComponent();
            this.Month_cb.SelectedIndex = 0;
            
            //for size testing
            //foreach(var i in "abcdefghijklmnopqrstuvwxyz")
            //{
            //    costs.Add(i.ToString());
            //}


        }

        /// <summary>
        /// parses text as money
        /// </summary>
        /// <param name="text">the text of the textbox</param>
        /// <returns>the text as a monitary value</returns>
        private double tb_parser(string text)
        {
            // removes all the chars that are normally inclueded in numbers
            text = text.Replace("$", "").Replace(",", "").Replace("_", "");
            // default values
            double val = 0;
            // attemptted parse
            Double.TryParse(text, out val);
            return val;
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            // clears a group box so data can be redisplayed and re formated
            clear_gb(this.Data_gb);
            if(this.Data_gb.Controls.Count > 0)
            {
                 var x = 1;
            }
            // disables setup and enables data
            this.Data_gb.Enabled = true;
            this.Setup_gb.Enabled = false;
            // holds the values
            this.monthly_values[this.Month_cb.Text] = 0;

            // deleates misc cost so that it can become the last the 
            if(costs.Contains("Misc Costs"))
            {
                costs.Remove("Misc Costs");
            }

            // if the user left a cost to add grab that as well
            if (this.Add_Cost_Tf.Text.Length != 0)
            {
                costs.Add(this.Add_Cost_Tf.Text);
                this.Add_Cost_Tf.Text = "";
            }

            // add misc
            // remove any more than 15 becuase guis can only be so large
            if (costs.Count < 15)
            {
                costs.Add("Misc Costs");
            }
            else
            {
                // show an error message
                MessageBox.Show(
                $"You had too many bills to display so we combined {costs[13]}-{costs[costs.Count - 1]} into \"Misc Costs\"",
                "Info"
                ); 
                costs = costs.GetRange(0, 14);
                costs.Add("Misc Costs");
                
            }

            // a set to remove any duplicates
            var temp_set = new HashSet<string>(this.costs);
            // returns it back to the orginal list
            this.costs = temp_set.ToList<string>();

            // grabs the length of the longest string to use in the buffer calc
            int buffer = costs.OrderByDescending(entry => entry.Length).First().Length + 150;

            // y loc (increased at the end of each loop
            int dy = 25;

            // loop through the cosrts
            for (int i = 0; i < costs.Count; i++)
            {
                // Create a GroupBox and add a TextBox to it.
                Panel panel = new Panel();
                Label label = new Label();
                TextBox textBox = new TextBox();

                // populate fields
                textBox.Text = "$0.00";
                label.Text = this.costs[i];

                // sets all my locations
                panel.Location = new Point(15, dy);
                panel.Height = textBox.Height + 5;
                label.Location = new Point(0, 0);
                // adjusted the size
                textBox.Location = new Point(buffer, 0);

                // setting the values
                panel.Width = textBox.Width * 3;

                panel.Controls.Add(label);
                panel.Controls.Add(textBox);

                // Inner functions: unique to each text box becuase its nested in the for loop
                // fires every time there is a change in a text box
                void tb_change(object sender, EventArgs e)
                {
                    double value = 0;

                    // becuase of how its placed I need to access the panels before editing the textboxes 
                    foreach(var panel in this.Data_gb.Controls.OfType<Panel>())
                    {
                        foreach(var i in panel.Controls.OfType<TextBox>())
                        {
                            value += tb_parser(i.Text);
                        }
                    }

                    // save the value and update teh final data
                    this.monthly_values[this.Month_cb.Text] = value;
                    update_final();
                }

                // register the new function
                textBox.TextChanged += new EventHandler(tb_change);
                // safe show
                panel.Show();
                // add panels
                this.Data_gb.Controls.Add(panel);


                // update the location of dy
                dy += textBox.Height * 2;
            }

            
        }


        /// <summary>
        /// changing the ouput box
        /// </summary>
        private void update_final()
        {
            // clearing in case there is new data to present
            clear_gb(this.Output_gb);

            // deep copy the dictonary
            // so they are sorted chronologically 
            Dictionary<string, double> sorted_months = new Dictionary<string, double>();

            // loops through every month
            foreach(var i in new String[] { "January","February","March","April","May","June","July","August","September","October","November","December"})
            {
                // if the key is there
                if (monthly_values.ContainsKey(i))
                {
                    // add it to the new sorted list
                    sorted_months[i] = monthly_values[i];
                }
            }

            // keeps the total from everything up to this point
            double cuml_total = 0;
            // longest string for as a buffer so everything is lined up
            int buffer = sorted_months.Keys.OrderByDescending(entry => entry.Length).First().Length + 150;
            // to hold the change of the y axis
            int dy = 25;
            
            
            // adding annual to months as the final key
            sorted_months["Annual"] = cuml_total;
            // casted to an array so modifying of teh dictonary is allowed
            var arr = sorted_months.Keys.ToArray();

            // looping though the key
            foreach(var key in arr)
            {
                // don't double annual by adding it back
                if (!key.Equals("Annual"))
                {
                    cuml_total += sorted_months[key];
                }
                // setting the new value 
                sorted_months["Annual"] = cuml_total;

                // prepping the box
                Panel panel = new Panel();
                Label label = new Label();
                TextBox textBox = new TextBox();

                // disabling editing
                textBox.ReadOnly = true;

                // formating text
                textBox.Text = String.Format("${0:N2}", sorted_months[key]);
                label.Text = key;

                // formatiing location
                panel.Location = new Point(15, dy);
                panel.Height = textBox.Height + 5;
                label.Location = new Point(0, 0);
                textBox.Location = new Point(buffer, 0);

                // finalizing
                panel.Width = textBox.Width * 3;

                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
                panel.Show();

                this.Output_gb.Controls.Add(panel);
                
                // updating y
                dy += textBox.Height * 2;
            }
        }

        private void Add_Bill_Btn_Click(object sender, EventArgs e)
        {
            // checks if someone entered something
            if (this.Add_Cost_Tf.Text.Length != 0)
            {
                // add the text, reset the tf
                costs.Add(this.Add_Cost_Tf.Text);
                this.Add_Cost_Tf.Text = "";
            }
        }

        private void Finalize_btn_Click(object sender, EventArgs e)
        {
            // allow another month to be entered
            this.Data_gb.Enabled = false;
            this.Setup_gb.Enabled = true;
            
            update_final();
        }

        private void clear_gb(GroupBox gb)
        {
            gb.Controls.Clear();
        }

        private void finalize_btn_Click_1(object sender, EventArgs e)
        {
            clear_gb(this.Data_gb);
            // allow to setup an additional month
            this.Data_gb.Enabled = false;
            this.Setup_gb.Enabled = true;
            
            // update the output gb
            update_final();
        }
    }
}
