
namespace Gadaleta_7_7
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.one_avg_label = new System.Windows.Forms.Label();
            this.two_avg_label = new System.Windows.Forms.Label();
            this.three_avg_label = new System.Windows.Forms.Label();
            this.cuml_avg_label = new System.Windows.Forms.Label();
            this.highest_label = new System.Windows.Forms.Label();
            this.lowest_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(149, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 94);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(291, 13);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 94);
            this.listBox3.TabIndex = 2;
            // 
            // one_avg_label
            // 
            this.one_avg_label.AutoSize = true;
            this.one_avg_label.Location = new System.Drawing.Point(23, 136);
            this.one_avg_label.Name = "one_avg_label";
            this.one_avg_label.Size = new System.Drawing.Size(98, 15);
            this.one_avg_label.TabIndex = 3;
            this.one_avg_label.Text = "Group 1 Average:";
            // 
            // two_avg_label
            // 
            this.two_avg_label.AutoSize = true;
            this.two_avg_label.Location = new System.Drawing.Point(23, 165);
            this.two_avg_label.Name = "two_avg_label";
            this.two_avg_label.Size = new System.Drawing.Size(98, 15);
            this.two_avg_label.TabIndex = 4;
            this.two_avg_label.Text = "Group 2 Average:";
            // 
            // three_avg_label
            // 
            this.three_avg_label.AutoSize = true;
            this.three_avg_label.Location = new System.Drawing.Point(23, 194);
            this.three_avg_label.Name = "three_avg_label";
            this.three_avg_label.Size = new System.Drawing.Size(98, 15);
            this.three_avg_label.TabIndex = 5;
            this.three_avg_label.Text = "Group 3 Average:";
            // 
            // cuml_avg_label
            // 
            this.cuml_avg_label.AutoSize = true;
            this.cuml_avg_label.Location = new System.Drawing.Point(23, 223);
            this.cuml_avg_label.Name = "cuml_avg_label";
            this.cuml_avg_label.Size = new System.Drawing.Size(117, 15);
            this.cuml_avg_label.TabIndex = 6;
            this.cuml_avg_label.Text = "Cumulative Average:";
            // 
            // highest_label
            // 
            this.highest_label.AutoSize = true;
            this.highest_label.Location = new System.Drawing.Point(23, 270);
            this.highest_label.Name = "highest_label";
            this.highest_label.Size = new System.Drawing.Size(51, 15);
            this.highest_label.TabIndex = 7;
            this.highest_label.Text = "Highest:";
            // 
            // lowest_label
            // 
            this.lowest_label.AutoSize = true;
            this.lowest_label.Location = new System.Drawing.Point(23, 294);
            this.lowest_label.Name = "lowest_label";
            this.lowest_label.Size = new System.Drawing.Size(47, 15);
            this.lowest_label.TabIndex = 8;
            this.lowest_label.Text = "Lowest:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.lowest_label);
            this.Controls.Add(this.highest_label);
            this.Controls.Add(this.cuml_avg_label);
            this.Controls.Add(this.three_avg_label);
            this.Controls.Add(this.two_avg_label);
            this.Controls.Add(this.one_avg_label);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label one_avg_label;
        private System.Windows.Forms.Label two_avg_label;
        private System.Windows.Forms.Label three_avg_label;
        private System.Windows.Forms.Label cuml_avg_label;
        private System.Windows.Forms.Label highest_label;
        private System.Windows.Forms.Label lowest_label;
    }
}

