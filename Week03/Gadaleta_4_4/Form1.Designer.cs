
namespace Gadaleta_4_4
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
            this.Mixer_btn = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Primary_Box = new System.Windows.Forms.GroupBox();
            this.yellow = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.Secondary_Box = new System.Windows.Forms.GroupBox();
            this.yellow_s = new System.Windows.Forms.RadioButton();
            this.blue_s = new System.Windows.Forms.RadioButton();
            this.red_s = new System.Windows.Forms.RadioButton();
            this.Primary_Box.SuspendLayout();
            this.Secondary_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mixer_btn
            // 
            this.Mixer_btn.Location = new System.Drawing.Point(228, 317);
            this.Mixer_btn.Name = "Mixer_btn";
            this.Mixer_btn.Size = new System.Drawing.Size(75, 23);
            this.Mixer_btn.TabIndex = 2;
            this.Mixer_btn.Text = "Mix";
            this.Mixer_btn.UseVisualStyleBackColor = true;
            this.Mixer_btn.Click += new System.EventHandler(this.Mixer_btn_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(471, 317);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Exit";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // Primary_Box
            // 
            this.Primary_Box.Controls.Add(this.yellow);
            this.Primary_Box.Controls.Add(this.blue);
            this.Primary_Box.Controls.Add(this.red);
            this.Primary_Box.Location = new System.Drawing.Point(103, 78);
            this.Primary_Box.Name = "Primary_Box";
            this.Primary_Box.Size = new System.Drawing.Size(200, 100);
            this.Primary_Box.TabIndex = 4;
            this.Primary_Box.TabStop = false;
            this.Primary_Box.Text = "Primary";
            // 
            // yellow
            // 
            this.yellow.AutoSize = true;
            this.yellow.Location = new System.Drawing.Point(7, 75);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(59, 19);
            this.yellow.TabIndex = 2;
            this.yellow.Text = "yellow";
            this.yellow.UseVisualStyleBackColor = true;
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(7, 49);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(48, 19);
            this.blue.TabIndex = 1;
            this.blue.Text = "blue";
            this.blue.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Checked = true;
            this.red.Location = new System.Drawing.Point(7, 23);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(42, 19);
            this.red.TabIndex = 0;
            this.red.TabStop = true;
            this.red.Text = "red";
            this.red.UseVisualStyleBackColor = true;
            // 
            // Secondary_Box
            // 
            this.Secondary_Box.Controls.Add(this.yellow_s);
            this.Secondary_Box.Controls.Add(this.blue_s);
            this.Secondary_Box.Controls.Add(this.red_s);
            this.Secondary_Box.Location = new System.Drawing.Point(471, 78);
            this.Secondary_Box.Name = "Secondary_Box";
            this.Secondary_Box.Size = new System.Drawing.Size(200, 100);
            this.Secondary_Box.TabIndex = 5;
            this.Secondary_Box.TabStop = false;
            this.Secondary_Box.Text = "Secondary";
            // 
            // yellow_s
            // 
            this.yellow_s.AutoSize = true;
            this.yellow_s.Location = new System.Drawing.Point(7, 75);
            this.yellow_s.Name = "yellow_s";
            this.yellow_s.Size = new System.Drawing.Size(59, 19);
            this.yellow_s.TabIndex = 2;
            this.yellow_s.Text = "yellow";
            this.yellow_s.UseVisualStyleBackColor = true;
            // 
            // blue_s
            // 
            this.blue_s.AutoSize = true;
            this.blue_s.Location = new System.Drawing.Point(7, 49);
            this.blue_s.Name = "blue_s";
            this.blue_s.Size = new System.Drawing.Size(48, 19);
            this.blue_s.TabIndex = 1;
            this.blue_s.Text = "blue";
            this.blue_s.UseVisualStyleBackColor = true;
            // 
            // red_s
            // 
            this.red_s.AutoSize = true;
            this.red_s.Checked = true;
            this.red_s.Location = new System.Drawing.Point(7, 23);
            this.red_s.Name = "red_s";
            this.red_s.Size = new System.Drawing.Size(42, 19);
            this.red_s.TabIndex = 0;
            this.red_s.TabStop = true;
            this.red_s.Text = "red";
            this.red_s.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Secondary_Box);
            this.Controls.Add(this.Primary_Box);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Mixer_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Primary_Box.ResumeLayout(false);
            this.Primary_Box.PerformLayout();
            this.Secondary_Box.ResumeLayout(false);
            this.Secondary_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Mixer_btn;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.GroupBox Primary_Box;
        private System.Windows.Forms.RadioButton yellow;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.GroupBox Secondary_Box;
        private System.Windows.Forms.RadioButton yellow_s;
        private System.Windows.Forms.RadioButton blue_s;
        private System.Windows.Forms.RadioButton red_s;
    }
}

