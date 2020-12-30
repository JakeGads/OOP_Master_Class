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
        double[][] array;
        double[] cuml_array;
        public Form1()
        {
            InitializeComponent();
            array = new double[][] { 
                Read_File("..\\..\\..\\Section1.txt"),
                Read_File("..\\..\\..\\Section2.txt"),
                Read_File("..\\..\\..\\Section3.txt") 
            };

            set_list_box(this.listBox1, array[0]);
            set_list_box(this.listBox2, array[1]);
            set_list_box(this.listBox3, array[2]);

            this.one_avg_label.Text += String.Format(" {0:N3}", array[0].Average());
            this.two_avg_label.Text += String.Format(" {0:N3}", array[1].Average());
            this.three_avg_label.Text += String.Format(" {0:N3}", array[2].Average());

            cuml_array = array[0].Concat(array[1]).Concat(array[2]).ToArray();

            this.cuml_avg_label.Text += String.Format(" {0:N3}",cuml_array.Average());
            Array.Sort(cuml_array);
            this.lowest_label.Text += String.Format(" {0:N3}", cuml_array[0]);
            Array.Reverse(cuml_array);
            this.highest_label.Text += String.Format(" {0:N3}", cuml_array[0]);
        }

        private void set_list_box(ListBox listBox, double[] vs)
        {
            for(int i = 0; i < vs.Length; i++)
            {
                listBox.Items.Insert(i, vs[i]);
            }
        }

        public double[] Read_File(String file_name)
        {
            using (var sr = new StreamReader(file_name))
            {
                return sr.ReadToEnd().Trim().Split('\n').Select(p => Double.Parse(p)).ToArray();
            }
        }
    }
}
