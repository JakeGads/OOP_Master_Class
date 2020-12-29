
namespace Gadaleta_3_12
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Square_Footage_Input = new System.Windows.Forms.TextBox();
            this.Gallon_Cost_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.total_cost_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labour_cost_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.paint_cost_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labour_hours_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paint_required_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Square_Footage_Input);
            this.splitContainer1.Panel1.Controls.Add(this.Gallon_Cost_Input);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.total_cost_label);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.labour_cost_label);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.paint_cost_label);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.labour_hours_label);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.paint_required_label);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // Square_Footage_Input
            // 
            this.Square_Footage_Input.Location = new System.Drawing.Point(51, 307);
            this.Square_Footage_Input.Name = "Square_Footage_Input";
            this.Square_Footage_Input.Size = new System.Drawing.Size(155, 23);
            this.Square_Footage_Input.TabIndex = 4;
            this.Square_Footage_Input.TextChanged += new System.EventHandler(this.Square_Footage_Input_TextChanged);
            // 
            // Gallon_Cost_Input
            // 
            this.Gallon_Cost_Input.Location = new System.Drawing.Point(51, 64);
            this.Gallon_Cost_Input.Name = "Gallon_Cost_Input";
            this.Gallon_Cost_Input.Size = new System.Drawing.Size(155, 23);
            this.Gallon_Cost_Input.TabIndex = 3;
            this.Gallon_Cost_Input.TextChanged += new System.EventHandler(this.Gallon_Cost_Input_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paint Cost per Gallon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Square Footage";
            // 
            // total_cost_label
            // 
            this.total_cost_label.AutoSize = true;
            this.total_cost_label.Location = new System.Drawing.Point(283, 214);
            this.total_cost_label.Name = "total_cost_label";
            this.total_cost_label.Size = new System.Drawing.Size(13, 15);
            this.total_cost_label.TabIndex = 9;
            this.total_cost_label.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total";
            // 
            // labour_cost_label
            // 
            this.labour_cost_label.AutoSize = true;
            this.labour_cost_label.Location = new System.Drawing.Point(283, 172);
            this.labour_cost_label.Name = "labour_cost_label";
            this.labour_cost_label.Size = new System.Drawing.Size(13, 15);
            this.labour_cost_label.TabIndex = 7;
            this.labour_cost_label.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Labour Cost";
            // 
            // paint_cost_label
            // 
            this.paint_cost_label.AutoSize = true;
            this.paint_cost_label.Location = new System.Drawing.Point(283, 137);
            this.paint_cost_label.Name = "paint_cost_label";
            this.paint_cost_label.Size = new System.Drawing.Size(13, 15);
            this.paint_cost_label.TabIndex = 5;
            this.paint_cost_label.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Paint Cost";
            // 
            // labour_hours_label
            // 
            this.labour_hours_label.AutoSize = true;
            this.labour_hours_label.Location = new System.Drawing.Point(283, 99);
            this.labour_hours_label.Name = "labour_hours_label";
            this.labour_hours_label.Size = new System.Drawing.Size(13, 15);
            this.labour_hours_label.TabIndex = 3;
            this.labour_hours_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Labour Hours";
            // 
            // paint_required_label
            // 
            this.paint_required_label.AutoSize = true;
            this.paint_required_label.Location = new System.Drawing.Point(283, 64);
            this.paint_required_label.Name = "paint_required_label";
            this.paint_required_label.Size = new System.Drawing.Size(13, 15);
            this.paint_required_label.TabIndex = 1;
            this.paint_required_label.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Paint Required (Gallons)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_cost_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labour_cost_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label paint_cost_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labour_hours_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label paint_required_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Square_Footage_Input;
        private System.Windows.Forms.TextBox Gallon_Cost_Input;
    }
}

