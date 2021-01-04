
namespace Midterm
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
            this.Setup_Box = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit_Btn = new System.Windows.Forms.Button();
            this.Add_Bill_Btn = new System.Windows.Forms.Button();
            this.Add_Cost_Tf = new System.Windows.Forms.TextBox();
            this.Month_cb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Setup_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setup_Box
            // 
            this.Setup_Box.Controls.Add(this.label1);
            this.Setup_Box.Controls.Add(this.Submit_Btn);
            this.Setup_Box.Controls.Add(this.Add_Bill_Btn);
            this.Setup_Box.Controls.Add(this.Add_Cost_Tf);
            this.Setup_Box.Controls.Add(this.Month_cb);
            this.Setup_Box.Location = new System.Drawing.Point(13, 13);
            this.Setup_Box.Name = "Setup_Box";
            this.Setup_Box.Size = new System.Drawing.Size(384, 224);
            this.Setup_Box.TabIndex = 0;
            this.Setup_Box.TabStop = false;
            this.Setup_Box.Text = "Setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Cost";
            // 
            // Submit_Btn
            // 
            this.Submit_Btn.Location = new System.Drawing.Point(135, 163);
            this.Submit_Btn.Name = "Submit_Btn";
            this.Submit_Btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_Btn.TabIndex = 3;
            this.Submit_Btn.Text = "Submit";
            this.Submit_Btn.UseVisualStyleBackColor = true;
            this.Submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // Add_Bill_Btn
            // 
            this.Add_Bill_Btn.Location = new System.Drawing.Point(290, 74);
            this.Add_Bill_Btn.Name = "Add_Bill_Btn";
            this.Add_Bill_Btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Bill_Btn.TabIndex = 2;
            this.Add_Bill_Btn.Text = "Add ";
            this.Add_Bill_Btn.UseVisualStyleBackColor = true;
            this.Add_Bill_Btn.Click += new System.EventHandler(this.Add_Bill_Btn_Click);
            // 
            // Add_Cost_Tf
            // 
            this.Add_Cost_Tf.Location = new System.Drawing.Point(99, 74);
            this.Add_Cost_Tf.Name = "Add_Cost_Tf";
            this.Add_Cost_Tf.Size = new System.Drawing.Size(169, 23);
            this.Add_Cost_Tf.TabIndex = 1;
            // 
            // Month_cb
            // 
            this.Month_cb.FormattingEnabled = true;
            this.Month_cb.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.Month_cb.Location = new System.Drawing.Point(7, 23);
            this.Month_cb.Name = "Month_cb";
            this.Month_cb.Size = new System.Drawing.Size(371, 23);
            this.Month_cb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(415, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 739);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(13, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 509);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 764);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Setup_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Setup_Box.ResumeLayout(false);
            this.Setup_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Setup_Box;
        private System.Windows.Forms.Button Add_Bill_Btn;
        private System.Windows.Forms.TextBox Add_Cost_Tf;
        private System.Windows.Forms.ComboBox Month_cb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit_Btn;
    }
}

