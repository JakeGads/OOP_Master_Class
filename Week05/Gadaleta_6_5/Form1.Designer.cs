
namespace Gadaleta_6_5
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
            this.Oil_Group = new System.Windows.Forms.GroupBox();
            this.Lube_Job_CB = new System.Windows.Forms.CheckBox();
            this.Oil_Change_CB = new System.Windows.Forms.CheckBox();
            this.Flushes_Group = new System.Windows.Forms.GroupBox();
            this.Radiaotr_Flush_CB = new System.Windows.Forms.CheckBox();
            this.Transmssion_Flush_CB = new System.Windows.Forms.CheckBox();
            this.Misc_Group = new System.Windows.Forms.GroupBox();
            this.Tire_Rotation_CB = new System.Windows.Forms.CheckBox();
            this.Inspection_CB = new System.Windows.Forms.CheckBox();
            this.Replace_Muffler_CB = new System.Windows.Forms.CheckBox();
            this.Parts_Labour_Group = new System.Windows.Forms.GroupBox();
            this.Labour_tf = new System.Windows.Forms.TextBox();
            this.Parts_tf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Summary_Group = new System.Windows.Forms.GroupBox();
            this.Total_tf = new System.Windows.Forms.TextBox();
            this.Parts_Tax_tf = new System.Windows.Forms.TextBox();
            this.Parts_Cost_tf = new System.Windows.Forms.TextBox();
            this.Service_Labour_Cost_tf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculate_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Oil_Group.SuspendLayout();
            this.Flushes_Group.SuspendLayout();
            this.Misc_Group.SuspendLayout();
            this.Parts_Labour_Group.SuspendLayout();
            this.Summary_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Oil_Group
            // 
            this.Oil_Group.Controls.Add(this.Lube_Job_CB);
            this.Oil_Group.Controls.Add(this.Oil_Change_CB);
            this.Oil_Group.Location = new System.Drawing.Point(13, 13);
            this.Oil_Group.Name = "Oil_Group";
            this.Oil_Group.Size = new System.Drawing.Size(200, 100);
            this.Oil_Group.TabIndex = 0;
            this.Oil_Group.TabStop = false;
            this.Oil_Group.Text = "Oil && Lube";
            // 
            // Lube_Job_CB
            // 
            this.Lube_Job_CB.AutoSize = true;
            this.Lube_Job_CB.Location = new System.Drawing.Point(7, 49);
            this.Lube_Job_CB.Name = "Lube_Job_CB";
            this.Lube_Job_CB.Size = new System.Drawing.Size(117, 19);
            this.Lube_Job_CB.TabIndex = 1;
            this.Lube_Job_CB.Text = "Lube Job ($18.00)";
            this.Lube_Job_CB.UseVisualStyleBackColor = true;
            // 
            // Oil_Change_CB
            // 
            this.Oil_Change_CB.AutoSize = true;
            this.Oil_Change_CB.Location = new System.Drawing.Point(7, 23);
            this.Oil_Change_CB.Name = "Oil_Change_CB";
            this.Oil_Change_CB.Size = new System.Drawing.Size(129, 19);
            this.Oil_Change_CB.TabIndex = 0;
            this.Oil_Change_CB.Text = "Oil Change ($26.00)";
            this.Oil_Change_CB.UseVisualStyleBackColor = true;
            // 
            // Flushes_Group
            // 
            this.Flushes_Group.Controls.Add(this.Radiaotr_Flush_CB);
            this.Flushes_Group.Controls.Add(this.Transmssion_Flush_CB);
            this.Flushes_Group.Location = new System.Drawing.Point(219, 13);
            this.Flushes_Group.Name = "Flushes_Group";
            this.Flushes_Group.Size = new System.Drawing.Size(200, 100);
            this.Flushes_Group.TabIndex = 2;
            this.Flushes_Group.TabStop = false;
            this.Flushes_Group.Text = " ";
            // 
            // Radiaotr_Flush_CB
            // 
            this.Radiaotr_Flush_CB.AutoSize = true;
            this.Radiaotr_Flush_CB.Location = new System.Drawing.Point(7, 49);
            this.Radiaotr_Flush_CB.Name = "Radiaotr_Flush_CB";
            this.Radiaotr_Flush_CB.Size = new System.Drawing.Size(169, 19);
            this.Radiaotr_Flush_CB.TabIndex = 1;
            this.Radiaotr_Flush_CB.Text = "Transmission Flush ($80.00)";
            this.Radiaotr_Flush_CB.UseVisualStyleBackColor = true;
            // 
            // Transmssion_Flush_CB
            // 
            this.Transmssion_Flush_CB.AutoSize = true;
            this.Transmssion_Flush_CB.Location = new System.Drawing.Point(7, 23);
            this.Transmssion_Flush_CB.Name = "Transmssion_Flush_CB";
            this.Transmssion_Flush_CB.Size = new System.Drawing.Size(145, 19);
            this.Transmssion_Flush_CB.TabIndex = 0;
            this.Transmssion_Flush_CB.Text = "Radiator Flush ($30.00)";
            this.Transmssion_Flush_CB.UseVisualStyleBackColor = true;
            // 
            // Misc_Group
            // 
            this.Misc_Group.Controls.Add(this.Tire_Rotation_CB);
            this.Misc_Group.Controls.Add(this.Inspection_CB);
            this.Misc_Group.Controls.Add(this.Replace_Muffler_CB);
            this.Misc_Group.Location = new System.Drawing.Point(12, 119);
            this.Misc_Group.Name = "Misc_Group";
            this.Misc_Group.Size = new System.Drawing.Size(200, 100);
            this.Misc_Group.TabIndex = 2;
            this.Misc_Group.TabStop = false;
            this.Misc_Group.Text = "Misc";
            // 
            // Tire_Rotation_CB
            // 
            this.Tire_Rotation_CB.AutoSize = true;
            this.Tire_Rotation_CB.Location = new System.Drawing.Point(8, 75);
            this.Tire_Rotation_CB.Name = "Tire_Rotation_CB";
            this.Tire_Rotation_CB.Size = new System.Drawing.Size(137, 19);
            this.Tire_Rotation_CB.TabIndex = 2;
            this.Tire_Rotation_CB.Text = "Tire Rotation ($20.00)";
            this.Tire_Rotation_CB.UseVisualStyleBackColor = true;
            // 
            // Inspection_CB
            // 
            this.Inspection_CB.AutoSize = true;
            this.Inspection_CB.Location = new System.Drawing.Point(7, 49);
            this.Inspection_CB.Name = "Inspection_CB";
            this.Inspection_CB.Size = new System.Drawing.Size(159, 19);
            this.Inspection_CB.TabIndex = 1;
            this.Inspection_CB.Text = "Replace Muffler ($100.00)";
            this.Inspection_CB.UseVisualStyleBackColor = true;
            // 
            // Replace_Muffler_CB
            // 
            this.Replace_Muffler_CB.AutoSize = true;
            this.Replace_Muffler_CB.Location = new System.Drawing.Point(7, 23);
            this.Replace_Muffler_CB.Name = "Replace_Muffler_CB";
            this.Replace_Muffler_CB.Size = new System.Drawing.Size(125, 19);
            this.Replace_Muffler_CB.TabIndex = 0;
            this.Replace_Muffler_CB.Text = "Inspection ($15.00)";
            this.Replace_Muffler_CB.UseVisualStyleBackColor = true;
            // 
            // Parts_Labour_Group
            // 
            this.Parts_Labour_Group.Controls.Add(this.Labour_tf);
            this.Parts_Labour_Group.Controls.Add(this.Parts_tf);
            this.Parts_Labour_Group.Controls.Add(this.label2);
            this.Parts_Labour_Group.Controls.Add(this.label1);
            this.Parts_Labour_Group.Location = new System.Drawing.Point(219, 120);
            this.Parts_Labour_Group.Name = "Parts_Labour_Group";
            this.Parts_Labour_Group.Size = new System.Drawing.Size(200, 100);
            this.Parts_Labour_Group.TabIndex = 3;
            this.Parts_Labour_Group.TabStop = false;
            this.Parts_Labour_Group.Text = "Parts && Labor";
            // 
            // Labour_tf
            // 
            this.Labour_tf.Location = new System.Drawing.Point(87, 54);
            this.Labour_tf.Name = "Labour_tf";
            this.Labour_tf.Size = new System.Drawing.Size(100, 23);
            this.Labour_tf.TabIndex = 3;
            // 
            // Parts_tf
            // 
            this.Parts_tf.Location = new System.Drawing.Point(87, 25);
            this.Parts_tf.Name = "Parts_tf";
            this.Parts_tf.Size = new System.Drawing.Size(100, 23);
            this.Parts_tf.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labour ($)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // Summary_Group
            // 
            this.Summary_Group.Controls.Add(this.Total_tf);
            this.Summary_Group.Controls.Add(this.Parts_Tax_tf);
            this.Summary_Group.Controls.Add(this.Parts_Cost_tf);
            this.Summary_Group.Controls.Add(this.Service_Labour_Cost_tf);
            this.Summary_Group.Controls.Add(this.label6);
            this.Summary_Group.Controls.Add(this.label5);
            this.Summary_Group.Controls.Add(this.label4);
            this.Summary_Group.Controls.Add(this.label3);
            this.Summary_Group.Location = new System.Drawing.Point(13, 235);
            this.Summary_Group.Name = "Summary_Group";
            this.Summary_Group.Size = new System.Drawing.Size(406, 152);
            this.Summary_Group.TabIndex = 4;
            this.Summary_Group.TabStop = false;
            this.Summary_Group.Text = "Summary";
            // 
            // Total_tf
            // 
            this.Total_tf.Location = new System.Drawing.Point(149, 119);
            this.Total_tf.Name = "Total_tf";
            this.Total_tf.ReadOnly = true;
            this.Total_tf.Size = new System.Drawing.Size(166, 23);
            this.Total_tf.TabIndex = 7;
            // 
            // Parts_Tax_tf
            // 
            this.Parts_Tax_tf.Location = new System.Drawing.Point(149, 89);
            this.Parts_Tax_tf.Name = "Parts_Tax_tf";
            this.Parts_Tax_tf.ReadOnly = true;
            this.Parts_Tax_tf.Size = new System.Drawing.Size(166, 23);
            this.Parts_Tax_tf.TabIndex = 6;
            // 
            // Parts_Cost_tf
            // 
            this.Parts_Cost_tf.Location = new System.Drawing.Point(149, 59);
            this.Parts_Cost_tf.Name = "Parts_Cost_tf";
            this.Parts_Cost_tf.ReadOnly = true;
            this.Parts_Cost_tf.Size = new System.Drawing.Size(166, 23);
            this.Parts_Cost_tf.TabIndex = 5;
            // 
            // Service_Labour_Cost_tf
            // 
            this.Service_Labour_Cost_tf.Location = new System.Drawing.Point(149, 30);
            this.Service_Labour_Cost_tf.Name = "Service_Labour_Cost_tf";
            this.Service_Labour_Cost_tf.ReadOnly = true;
            this.Service_Labour_Cost_tf.Size = new System.Drawing.Size(166, 23);
            this.Service_Labour_Cost_tf.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax (on parts)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Service && Labor";
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(20, 427);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(75, 23);
            this.Calculate_btn.TabIndex = 5;
            this.Calculate_btn.Text = "Calculate";
            this.Calculate_btn.UseVisualStyleBackColor = true;
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(176, 427);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(75, 23);
            this.Clear_btn.TabIndex = 6;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(331, 427);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 7;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 457);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.Summary_Group);
            this.Controls.Add(this.Parts_Labour_Group);
            this.Controls.Add(this.Misc_Group);
            this.Controls.Add(this.Flushes_Group);
            this.Controls.Add(this.Oil_Group);
            this.Name = "Form1";
            this.Text = "Automative";
            this.Oil_Group.ResumeLayout(false);
            this.Oil_Group.PerformLayout();
            this.Flushes_Group.ResumeLayout(false);
            this.Flushes_Group.PerformLayout();
            this.Misc_Group.ResumeLayout(false);
            this.Misc_Group.PerformLayout();
            this.Parts_Labour_Group.ResumeLayout(false);
            this.Parts_Labour_Group.PerformLayout();
            this.Summary_Group.ResumeLayout(false);
            this.Summary_Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Oil_Group;
        private System.Windows.Forms.CheckBox Lube_Job_CB;
        private System.Windows.Forms.CheckBox Oil_Change_CB;
        private System.Windows.Forms.GroupBox Flushes_Group;
        private System.Windows.Forms.CheckBox Radiaotr_Flush_CB;
        private System.Windows.Forms.CheckBox Transmssion_Flush_CB;
        private System.Windows.Forms.GroupBox Misc_Group;
        private System.Windows.Forms.CheckBox Tire_Rotation_CB;
        private System.Windows.Forms.CheckBox Inspection_CB;
        private System.Windows.Forms.CheckBox Replace_Muffler_CB;
        private System.Windows.Forms.GroupBox Parts_Labour_Group;
        private System.Windows.Forms.TextBox Labour_tf;
        private System.Windows.Forms.TextBox Parts_tf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Summary_Group;
        private System.Windows.Forms.TextBox Total_tf;
        private System.Windows.Forms.TextBox Parts_Tax_tf;
        private System.Windows.Forms.TextBox Parts_Cost_tf;
        private System.Windows.Forms.TextBox Service_Labour_Cost_tf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}

