using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_7_7_Real
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // creates a list of the years class for anayalisis
            List<Year> years = getList();

            // gets the average change adn stores it
            AnnualChangeTB.Text =String.Format("{0:N2}", get_annual_change(years));
            get_max_min(years);
           

        }

        private void get_max_min(List<Year> years)
        {
            // holds the minimum number
            double max = Double.MinValue;
            // holds the max
            double min = Double.MaxValue;

            // loops
            foreach (Year year in years)
            {
                // checks if its larger
                if (year.Population > max)
                {
                    // updates the max for the if
                    max = year.Population;
                    // writes out the data
                    this.MinTB.Text = String.Format("{0} : {1:N0}", year.AD, year.Population);
                }

                //  checks if its smaller than the smallest
                else if (year.Population < min & year.Population != 0) // excludes 1950 (because its value will be zero)
                {
                    // updates the min for the if
                    min = year.Population;
                    // writes out the data
                    this.MaxTB.Text = String.Format("{0} : {1:N0}", year.AD, year.Population);
                }
            }
        }

        private double get_annual_change(List<Year> years)
        {
            double avg = 0;
            foreach (Year year in years)
            {
                avg += year.Population;
            }

            return avg / years.Count;
        }

        private List<Year> getList()
        {
            double[] values;
            using (var sr = new StreamReader("..\\..\\..\\USPopulation.txt"))
            {
                // read the entire contents into a string.
                // split that string by new line characters ,
                // take those substring and cast them as doubles,  
                // finnally convert that List to an array  and send it back
                values = sr.ReadToEnd().Trim().Split('\n').Select(entry => Double.Parse(entry)).ToArray();
            }

            List<Year> years = new List<Year>();

            for(int i = 0; i < values.Length; i++)
            {
                if(i == 0)
                {
                    years.Add(new Year(1950, 0));
                    continue;
                }

                years.Add(new Year(1950 + i, values[i] - values[i - 1]));
            }

            return years;
        }
    }
}
