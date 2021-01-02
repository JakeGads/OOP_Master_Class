using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadaleta_9_2
{
    

    public partial class Form1 : Form
    {
        // instead of an array I used an Dictionary of Dictionary (of objects) so I can store more things in them
        Dictionary<String, Dictionary<string, Object>> sodas = new Dictionary<string, Dictionary<string, object>>();
        // the total cost
        double total = 0;
        public Form1()
        {
            InitializeComponent();
            
            // goes through and adds keys and data to the array, the reason that they keys exist is becuase it will keep the inner function active
            add_key("cola", "Cola.bmp", panel1);
            add_key("root", "RootBeer.bmp", panel2);
            add_key("lemon", "LemonLime.bmp", panel3);
            add_key("grape", "GrapeSoda.bmp", panel4, 1.5);
            add_key("cream", "CreamSoda.bmp", panel5, 1.5);

        }

        /// <summary>
        /// adds a new key and assings a function to it
        /// </summary>
        /// <param name="key">the name of the soda</param>
        /// <param name="img">the img that needs to be linked to it</param>
        /// <param name="panel">the panel in which these imgs reside in</param>
        /// <param name="cost">the cost</param>
        /// <param name="amount">the amount</param>
        public void add_key(String key, String img, Panel panel, double cost = 1, int amount = 20)
        {

            // makes the dictonary and assigns the data
            sodas[key] = new Dictionary<string, Object>();
            sodas[key]["img"] = ("..\\..\\..\\" + img);
            sodas[key]["cost"] = cost;
            sodas[key]["amount"] = amount;
            sodas[key]["panel"] = panel;


            /// <summary>
            /// subtracts one from the amount, adds the cost to the total, updates the gui, if they are out of stock the gui reflects this and the method is unregistered
            /// </summary>
            void OnClick(object sender, EventArgs e)
            {
                // updating the amount
                sodas[key]["amount"] = ((int)sodas[key]["amount"]) - 1;
                // updating the amount GUI
                ((Panel)sodas[key]["panel"]).Controls.OfType<TextBox>().ToArray()[0].Text = "" + sodas[key]["amount"];
                // updating the total and reflecting that in the gui
                this.total += (double)sodas[key]["cost"];
                this.Value_Box.Text = String.Format("${0:N2}", total);

                // unregistering click
                if ((int)sodas[key]["amount"] == 0)
                {
                    ((Panel)sodas[key]["panel"]).Controls.OfType<PictureBox>().ToArray()[0].Click -= OnClick;
                    ((Panel)sodas[key]["panel"]).Controls.OfType<TextBox>().ToArray()[0].Click -= OnClick;
                    ((Panel)sodas[key]["panel"]).Click -= OnClick;
                    ((Panel)sodas[key]["panel"]).BackColor = Color.Red;
                    foreach (var i in ((Panel)sodas[key]["panel"]).Controls.OfType<Label>())
                    {
                        i.Click -= OnClick;
                    }
                }
            }


            // updating gui and assigning the clicker
            ((Panel)sodas[key]["panel"]).Controls.OfType<PictureBox>().ToArray()[0].Load((String)sodas[key]["img"]);
            ((Panel)sodas[key]["panel"]).Controls.OfType<PictureBox>().ToArray()[0].Click += OnClick;
            ((Panel)sodas[key]["panel"]).Controls.OfType<TextBox>().ToArray()[0].Text = "" + sodas[key]["amount"];
            ((Panel)sodas[key]["panel"]).Controls.OfType<TextBox>().ToArray()[0].Click += OnClick;

            foreach (var i in ((Panel)sodas[key]["panel"]).Controls.OfType<Label>())
            {
                i.Click += OnClick;
                if (i.Text.Contains('$'))
                {
                    i.Text = String.Format("${0:N2}", sodas[key]["cost"]);
                }

            }


            ((Panel)sodas[key]["panel"]).Click += OnClick;

        }

    }
}
