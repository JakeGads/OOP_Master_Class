using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        Panel[] all_Panels;
        public Form1()
        {
            InitializeComponent();
            this.BasicRadio.Select();
            all_Panels = new Panel[] { this.BasicPanel, this.AdvancedPanel, this.SuperPanel };

            foreach(var i in all_Panels)
            {
                clear_panel(i);
            }

            for(int i = 1; i < all_Panels.Length; i++)
            {
                hide_panels(all_Panels[i]);
            }

        }

        private void hide_panels(Panel panel)
        {
            panel.Visible = false;
            panel.Enabled = false;
        }

        private void clear_panel(Panel panel)
        {
            foreach(var i in panel.Controls.OfType<TextBox>())
            {
                i.Text = "";
            }

            panel.Controls.OfType<Panel>().ToArray()[0].Controls.OfType<RadioButton>().ToArray()[0].Checked = true;
        }
    }
}
