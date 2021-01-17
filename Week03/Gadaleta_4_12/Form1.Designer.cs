
namespace Gadaleta_4_12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkshopDataGrid = new System.Windows.Forms.DataGridView();
            this.CityDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.CityFeeTB = new System.Windows.Forms.TextBox();
            this.WorkshopCostTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WorkshopDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkshopDataGrid
            // 
            this.WorkshopDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkshopDataGrid.Location = new System.Drawing.Point(12, 26);
            this.WorkshopDataGrid.Name = "WorkshopDataGrid";
            this.WorkshopDataGrid.ReadOnly = true;
            this.WorkshopDataGrid.RowTemplate.Height = 25;
            this.WorkshopDataGrid.Size = new System.Drawing.Size(360, 148);
            this.WorkshopDataGrid.TabIndex = 0;
            this.WorkshopDataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            // 
            // CityDataGrid
            // 
            this.CityDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityDataGrid.Location = new System.Drawing.Point(389, 13);
            this.CityDataGrid.Name = "CityDataGrid";
            this.CityDataGrid.ReadOnly = true;
            this.CityDataGrid.RowTemplate.Height = 25;
            this.CityDataGrid.Size = new System.Drawing.Size(260, 173);
            this.CityDataGrid.TabIndex = 1;
            this.CityDataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalTB);
            this.panel1.Controls.Add(this.CityFeeTB);
            this.panel1.Controls.Add(this.WorkshopCostTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 169);
            this.panel1.TabIndex = 2;
            // 
            // TotalTB
            // 
            this.TotalTB.Enabled = false;
            this.TotalTB.Location = new System.Drawing.Point(309, 92);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(100, 23);
            this.TotalTB.TabIndex = 5;
            this.TotalTB.Text = "$0.00";
            // 
            // CityFeeTB
            // 
            this.CityFeeTB.Enabled = false;
            this.CityFeeTB.Location = new System.Drawing.Point(309, 63);
            this.CityFeeTB.Name = "CityFeeTB";
            this.CityFeeTB.Size = new System.Drawing.Size(100, 23);
            this.CityFeeTB.TabIndex = 4;
            this.CityFeeTB.Text = "$0.00";
            // 
            // WorkshopCostTB
            // 
            this.WorkshopCostTB.Enabled = false;
            this.WorkshopCostTB.Location = new System.Drawing.Point(309, 30);
            this.WorkshopCostTB.Name = "WorkshopCostTB";
            this.WorkshopCostTB.Size = new System.Drawing.Size(100, 23);
            this.WorkshopCostTB.TabIndex = 3;
            this.WorkshopCostTB.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hotel Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Workshop Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CityDataGrid);
            this.Controls.Add(this.WorkshopDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WorkshopDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView WorkshopDataGrid;
        private System.Windows.Forms.DataGridView CityDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.TextBox CityFeeTB;
        private System.Windows.Forms.TextBox WorkshopCostTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

