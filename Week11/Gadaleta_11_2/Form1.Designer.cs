
namespace Gadaleta_11_2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_User_Box = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_Bonus = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Pay = new System.Windows.Forms.TextBox();
            this.Add_Shift = new System.Windows.Forms.TextBox();
            this.Add_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Add_User_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(504, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // Add_User_Box
            // 
            this.Add_User_Box.Controls.Add(this.label4);
            this.Add_User_Box.Controls.Add(this.Add_Bonus);
            this.Add_User_Box.Controls.Add(this.Submit);
            this.Add_User_Box.Controls.Add(this.label3);
            this.Add_User_Box.Controls.Add(this.label2);
            this.Add_User_Box.Controls.Add(this.label1);
            this.Add_User_Box.Controls.Add(this.Add_Pay);
            this.Add_User_Box.Controls.Add(this.Add_Shift);
            this.Add_User_Box.Controls.Add(this.Add_Name);
            this.Add_User_Box.Location = new System.Drawing.Point(13, 455);
            this.Add_User_Box.Name = "Add_User_Box";
            this.Add_User_Box.Size = new System.Drawing.Size(504, 149);
            this.Add_User_Box.TabIndex = 1;
            this.Add_User_Box.TabStop = false;
            this.Add_User_Box.Text = "Add User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bonus";
            // 
            // Add_Bonus
            // 
            this.Add_Bonus.Location = new System.Drawing.Point(7, 112);
            this.Add_Bonus.Name = "Add_Bonus";
            this.Add_Bonus.Size = new System.Drawing.Size(100, 23);
            this.Add_Bonus.TabIndex = 7;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(251, 23);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(191, 78);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // Add_Pay
            // 
            this.Add_Pay.Location = new System.Drawing.Point(7, 83);
            this.Add_Pay.Name = "Add_Pay";
            this.Add_Pay.Size = new System.Drawing.Size(100, 23);
            this.Add_Pay.TabIndex = 2;
            // 
            // Add_Shift
            // 
            this.Add_Shift.Location = new System.Drawing.Point(7, 53);
            this.Add_Shift.Name = "Add_Shift";
            this.Add_Shift.Size = new System.Drawing.Size(100, 23);
            this.Add_Shift.TabIndex = 1;
            // 
            // Add_Name
            // 
            this.Add_Name.Location = new System.Drawing.Point(7, 23);
            this.Add_Name.Name = "Add_Name";
            this.Add_Name.Size = new System.Drawing.Size(100, 23);
            this.Add_Name.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 631);
            this.Controls.Add(this.Add_User_Box);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Add_User_Box.ResumeLayout(false);
            this.Add_User_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Add_User_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Add_Pay;
        private System.Windows.Forms.TextBox Add_Shift;
        private System.Windows.Forms.TextBox Add_Name;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Add_Bonus;
    }
}

