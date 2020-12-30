
namespace Gadaleta_8_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.in_tf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.out_tf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // in_tf
            // 
            this.in_tf.Location = new System.Drawing.Point(56, 6);
            this.in_tf.Name = "in_tf";
            this.in_tf.Size = new System.Drawing.Size(100, 23);
            this.in_tf.TabIndex = 1;
            this.in_tf.TextChanged += new System.EventHandler(this.in_tf_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output:";
            // 
            // out_tf
            // 
            this.out_tf.Location = new System.Drawing.Point(56, 62);
            this.out_tf.Name = "out_tf";
            this.out_tf.ReadOnly = true;
            this.out_tf.Size = new System.Drawing.Size(100, 23);
            this.out_tf.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 98);
            this.Controls.Add(this.out_tf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.in_tf);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox in_tf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox out_tf;
    }
}

