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
        Dictionary<String, Dictionary<string, Object>> sodas = new Dictionary<string, Dictionary<string, object>>();
        double total = 0;
        public Form1()
        {
            InitializeComponent();
            //String key, String img, Panel panel, double cost = 1, int amount = 20
            add_key("cola", "Cola.bmp", panel1);
            add_key("root", "RootBeer.bmp", panel2);
            add_key("lemon", "LemonLime.bmp", panel3);
            add_key("grape", "GrapeSoda.bmp", panel4, 1.5);
            add_key("cream", "CreamSoda.bmp", panel5, 1.5);

        }

        public void add_key(String key, String img, Panel panel, double cost = 1, int amount = 20)
        {
           
            sodas[key] = new Dictionary<string, Object>();
            sodas[key]["img"] = ("..\\..\\..\\" + img);
            sodas[key]["cost"] = cost;
            sodas[key]["amount"] = amount;
            sodas[key]["panel"] = panel;

            void OnClick(object sender, EventArgs e)
            {
                sodas[key]["amount"] = ((int)sodas[key]["amount"]) - 1;
                ((Panel)sodas[key]["panel"]).Controls.OfType<TextBox>().ToArray()[0].Text = "" + sodas[key]["amount"];
                this.total += (double)sodas[key]["cost"];
                this.Value_Box.Text = String.Format("${0:N2}", total);
            }


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


            ((Panel)sodas[key]["panel"]).Click += new EventHandler(OnClick);

        }

    }
}
