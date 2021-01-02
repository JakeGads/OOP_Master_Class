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

namespace Gadaleta_7_7
{
    public partial class Form1 : Form
    {
        private double[][] array; // to store the jagged array
        private double[] cuml_array; // to store an array that combines all other arrays
        public Form1()
        {
            InitializeComponent();
            // converts the contents of the files to their own arrays
            array = new double[][] { 
                Read_File("..\\..\\..\\Section1.txt"),
                Read_File("..\\..\\..\\Section2.txt"),
                Read_File("..\\..\\..\\Section3.txt") 
            };
            // takes the jagged array and combines them, converts that list to the array
            cuml_array = array[0].Concat(array[1]).Concat(array[2]).ToArray();

            // sets all setbox
            set_list_box(this.listBox1, array[0]);
            set_list_box(this.listBox2, array[1]);
            set_list_box(this.listBox3, array[2]);

            // formats and claculates teh average for each of teh jagged arary
            this.one_avg_label.Text += String.Format(" {0:N3}", array[0].Average());
            this.two_avg_label.Text += String.Format(" {0:N3}", array[1].Average());
            this.three_avg_label.Text += String.Format(" {0:N3}", array[2].Average());

            
            // formats and calcualtes the average for the cuml array
            this.cuml_avg_label.Text += String.Format(" {0:N3}",cuml_array.Average());
            // sorts (desc by default) and assigns the first entrie to the lowest score spot
            Array.Sort(cuml_array);
            this.lowest_label.Text += String.Format(" {0:N3}", cuml_array[0]);

            // reverses the cuml array and does the same thing for the highest
            Array.Reverse(cuml_array);
            this.highest_label.Text += String.Format(" {0:N3}", cuml_array[0]);
        }

        /// <summary>
        /// Inserts the contents of an array into a listbox
        /// </summary>
        /// <param name="listBox">the targeted listbox</param>
        /// <param name="scores">the students scores</param>
        private void set_list_box(ListBox listBox, double[] scores)
        {
            //loops through the array and adds the score to the list box
            for(int i = 0; i < scores.Length; i++)
            {
                // inserts it
                listBox.Items.Insert(i, scores[i]);
            }
        }

        /// <summary>
        /// opens a file and casts its content to an array of doubles
        /// </summary>
        /// <param name="file_name">the name of the file, if in the same folder as the .cs files it requires `..\\..\\..\\`</param>
        /// <returns>an array however large of scores</returns>
        public double[] Read_File(String file_name)
        {
            // opens the files and 
            using (var sr = new StreamReader(file_name))
            {
                // read the entire contents into a string.
                // split that string by new line characters ,
                // take those substring and cast them as doubles,  
                // finnally convert that List to an array  and send it back
                return sr.ReadToEnd().Trim().Split('\n').Select(entry => Double.Parse(entry)).ToArray();
            }
        }
    }
}
