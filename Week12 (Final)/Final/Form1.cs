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
        List<object> Emps = new List<object>();
        

        public Form1()
        {
            InitializeComponent();
            this.setup_dialouges();
            all_Panels = new Panel[] { this.BasicPanel, this.AdvancedPanel, this.SuperPanel };
            this.BasicRadio.Select();
            this.basic_panel_setup();
        }

        private void setup_dialouges()
        {
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Load Files";
            this.openFileDialog.Multiselect = false;

            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save File";
        }

        private double tb_parser(string text)
        {
            text = text.Replace("$", "").Replace(",", "").Replace("_", "").Trim();
            double value = 0;
            Double.TryParse(text, out value);
            return value;
        }

        private void hide_panel(Panel panel)
        {
            panel.Visible = false;
            panel.Enabled = false;
        }

        private void show_panel(Panel panel)
        {
            panel.Visible = true;
            panel.Enabled = true;
        }

        private void clear_panel(Panel panel)
        {
            foreach(var i in panel.Controls.OfType<TextBox>())
            {
                i.Text = "";
            }
            try
            {
                panel.Controls.OfType<Panel>().ToArray()[0].Controls.OfType<RadioButton>().ToArray()[0].Checked = true;
            } catch(System.IndexOutOfRangeException e)
            {
                // empty becuase their was no checkboxs to check
            }
            
            
        }

        private void basic_panel_setup()
        {
            show_panel(this.BasicPanel);
            for(int i = 0; i < all_Panels.Length; i++)
            {
                clear_panel(all_Panels[i]);
                if(i > 0)
                {
                    hide_panel(all_Panels[i]);
                }
            }
        }

        private void advanced_panel_setup()
        {
            show_panel(all_Panels[0]);
            show_panel(all_Panels[1]);
            for (int i = 0; i < all_Panels.Length; i++)
            {
                clear_panel(all_Panels[i]);
                if (i > 1)
                {
                    hide_panel(all_Panels[i]);
                }
            }
        }

        private void super_panel_setup()
        {
            foreach(var i in all_Panels)
            {
                show_panel(i);
                clear_panel(i);
            }
        }

        private void BasicRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(this.BasicRadio.Checked == true)
            {
                basic_panel_setup();
            }
        }

        private void AdvancedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(AdvancedRadio.Checked == true)
            {
                advanced_panel_setup();
            }
        }

        private void SuperRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(SuperRadio.Checked == true)
            {
                super_panel_setup();
            }
        }

        private void InJson_Click(object sender, EventArgs e)
        {

            this.openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            this.openFileDialog.DefaultExt = "json";
            this.openFileDialog.ShowDialog();
            fileInput file = new fileInput(this.openFileDialog.FileName);

            foreach(var i in file.Parse())
            {
                this.Emps.Add(i);
            }

            this.generateChart();

        }

        private void generateChart()
        {
            this.EmployeeDataGrid.DataSource = null;
            this.EmployeeDataGrid.DataSource = this.Emps;
        }

        private void InTxt_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "All files (*.*)|*.*";
            this.openFileDialog.ShowDialog();
            
            fileInput file = new fileInput(this.openFileDialog.FileName);

            foreach(var i in file.Parse())
            {
                this.Emps.Add(i);
            }

            this.generateChart();
        }

        private void WriteJsonBtn_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.ShowDialog();
            fileOutput file = new fileOutput(this.saveFileDialog.FileName, file_types.json);
            file.Write(this.Emps.ToArray());

        }

        private void WriteTxtBtn_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.Filter = "All files (*.*)|*.*";
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.ShowDialog();
            fileOutput file = new fileOutput(this.saveFileDialog.FileName, file_types.raw_text);
            file.Write(this.Emps.ToArray());
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            

            if (BasicRadio.Checked)
            {
                Emps.Add(makeBasic());
            }
            else if (AdvancedRadio.Checked)
            {
                Emps.Add(makeAdvanced());
               
            }
            else
            {

            }
        }

        private object makeAdvanced()
        {
            var hours = tb_parser(this.HoursTB.Text);
            var hour_rate = tb_parser(this.HourlRateTB.Text);

            var message = "";
            bool hour_check = (hours < 0 || hours > 80);
            bool rate_check = (hour_rate < 10 || hour_rate > 42.5);
            bool both = hour_check && rate_check;

            if (!hour_check)
            {
                message += "ERROR: Hour must be between 0 & 80";
            }
            if (!both)
            {
                message += "\nand\n";
            }
            if (!rate_check)
            {
                message += "ERROR: Hour Rate must be between $10 & $42.50";
            }

            if (message.Equals(""))
            {
                var basic = makeBasic();
                return new advancedEmployee(basic.Name)
            }
            else
            {
                MessageBox.Show(message, "Error");
            }
        }

        private object makeBasic()
        {
            return new baseEmployee(
                        this.NameTB.Text,
                        this.EmailTB.Text,
                        this.AddressTB.Text
                    );
        }
    }
}
