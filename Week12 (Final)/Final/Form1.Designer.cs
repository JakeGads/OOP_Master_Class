
namespace Final
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
            this.outJson = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InTxt = new System.Windows.Forms.Button();
            this.InJson = new System.Windows.Forms.Button();
            this.OutTabControl = new System.Windows.Forms.TabPage();
            this.OutTxt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EmployeeDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuperRadio = new System.Windows.Forms.RadioButton();
            this.AdvancedRadio = new System.Windows.Forms.RadioButton();
            this.BasicRadio = new System.Windows.Forms.RadioButton();
            this.BasicPanel = new System.Windows.Forms.Panel();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdvancedPanel = new System.Windows.Forms.Panel();
            this.HoursTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HourlRateTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuperPanel = new System.Windows.Forms.Panel();
            this.OfficeNumberTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.highAccessRadio = new System.Windows.Forms.RadioButton();
            this.medAccessRadio = new System.Windows.Forms.RadioButton();
            this.lowAccessRadio = new System.Windows.Forms.RadioButton();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.outJson.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.OutTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.BasicPanel.SuspendLayout();
            this.AdvancedPanel.SuspendLayout();
            this.SuperPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outJson
            // 
            this.outJson.Controls.Add(this.tabPage1);
            this.outJson.Controls.Add(this.OutTabControl);
            this.outJson.Location = new System.Drawing.Point(12, 12);
            this.outJson.Name = "outJson";
            this.outJson.SelectedIndex = 0;
            this.outJson.Size = new System.Drawing.Size(154, 91);
            this.outJson.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InTxt);
            this.tabPage1.Controls.Add(this.InJson);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(146, 63);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // InTxt
            // 
            this.InTxt.Location = new System.Drawing.Point(4, 34);
            this.InTxt.Name = "InTxt";
            this.InTxt.Size = new System.Drawing.Size(139, 23);
            this.InTxt.TabIndex = 1;
            this.InTxt.Text = "Load TXT";
            this.InTxt.UseVisualStyleBackColor = true;
            // 
            // InJson
            // 
            this.InJson.Location = new System.Drawing.Point(4, 4);
            this.InJson.Name = "InJson";
            this.InJson.Size = new System.Drawing.Size(139, 23);
            this.InJson.TabIndex = 0;
            this.InJson.Text = "Load JSON";
            this.InJson.UseVisualStyleBackColor = true;
            // 
            // OutTabControl
            // 
            this.OutTabControl.Controls.Add(this.OutTxt);
            this.OutTabControl.Controls.Add(this.button2);
            this.OutTabControl.Location = new System.Drawing.Point(4, 24);
            this.OutTabControl.Name = "OutTabControl";
            this.OutTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.OutTabControl.Size = new System.Drawing.Size(146, 63);
            this.OutTabControl.TabIndex = 1;
            this.OutTabControl.Text = "Output";
            this.OutTabControl.UseVisualStyleBackColor = true;
            // 
            // OutTxt
            // 
            this.OutTxt.Location = new System.Drawing.Point(4, 34);
            this.OutTxt.Name = "OutTxt";
            this.OutTxt.Size = new System.Drawing.Size(139, 23);
            this.OutTxt.TabIndex = 3;
            this.OutTxt.Text = "Write TXT";
            this.OutTxt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Write JSON";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EmployeeDataGrid
            // 
            this.EmployeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGrid.Location = new System.Drawing.Point(16, 344);
            this.EmployeeDataGrid.Name = "EmployeeDataGrid";
            this.EmployeeDataGrid.RowTemplate.Height = 25;
            this.EmployeeDataGrid.Size = new System.Drawing.Size(776, 302);
            this.EmployeeDataGrid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SuperRadio);
            this.panel1.Controls.Add(this.AdvancedRadio);
            this.panel1.Controls.Add(this.BasicRadio);
            this.panel1.Location = new System.Drawing.Point(172, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 91);
            this.panel1.TabIndex = 2;
            // 
            // SuperRadio
            // 
            this.SuperRadio.AutoSize = true;
            this.SuperRadio.Location = new System.Drawing.Point(4, 63);
            this.SuperRadio.Name = "SuperRadio";
            this.SuperRadio.Size = new System.Drawing.Size(55, 19);
            this.SuperRadio.TabIndex = 2;
            this.SuperRadio.TabStop = true;
            this.SuperRadio.Text = "Super";
            this.SuperRadio.UseVisualStyleBackColor = true;
            // 
            // AdvancedRadio
            // 
            this.AdvancedRadio.AutoSize = true;
            this.AdvancedRadio.Location = new System.Drawing.Point(4, 38);
            this.AdvancedRadio.Name = "AdvancedRadio";
            this.AdvancedRadio.Size = new System.Drawing.Size(78, 19);
            this.AdvancedRadio.TabIndex = 1;
            this.AdvancedRadio.TabStop = true;
            this.AdvancedRadio.Text = "Advanced";
            this.AdvancedRadio.UseVisualStyleBackColor = true;
            // 
            // BasicRadio
            // 
            this.BasicRadio.AutoSize = true;
            this.BasicRadio.Location = new System.Drawing.Point(4, 13);
            this.BasicRadio.Name = "BasicRadio";
            this.BasicRadio.Size = new System.Drawing.Size(52, 19);
            this.BasicRadio.TabIndex = 0;
            this.BasicRadio.TabStop = true;
            this.BasicRadio.Text = "Basic";
            this.BasicRadio.UseVisualStyleBackColor = true;
            // 
            // BasicPanel
            // 
            this.BasicPanel.Controls.Add(this.AddressTB);
            this.BasicPanel.Controls.Add(this.label3);
            this.BasicPanel.Controls.Add(this.EmailTB);
            this.BasicPanel.Controls.Add(this.label2);
            this.BasicPanel.Controls.Add(this.NameTB);
            this.BasicPanel.Controls.Add(this.label1);
            this.BasicPanel.Location = new System.Drawing.Point(12, 110);
            this.BasicPanel.Name = "BasicPanel";
            this.BasicPanel.Size = new System.Drawing.Size(776, 75);
            this.BasicPanel.TabIndex = 3;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(466, 34);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(298, 23);
            this.AddressTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(256, 34);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(146, 23);
            this.EmailTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(8, 34);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(146, 23);
            this.NameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // AdvancedPanel
            // 
            this.AdvancedPanel.Controls.Add(this.HoursTB);
            this.AdvancedPanel.Controls.Add(this.label5);
            this.AdvancedPanel.Controls.Add(this.HourlRateTB);
            this.AdvancedPanel.Controls.Add(this.label4);
            this.AdvancedPanel.Location = new System.Drawing.Point(291, 12);
            this.AdvancedPanel.Name = "AdvancedPanel";
            this.AdvancedPanel.Size = new System.Drawing.Size(497, 92);
            this.AdvancedPanel.TabIndex = 4;
            // 
            // HoursTB
            // 
            this.HoursTB.Location = new System.Drawing.Point(187, 32);
            this.HoursTB.Name = "HoursTB";
            this.HoursTB.Size = new System.Drawing.Size(146, 23);
            this.HoursTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hours:";
            // 
            // HourlRateTB
            // 
            this.HourlRateTB.Location = new System.Drawing.Point(10, 34);
            this.HourlRateTB.Name = "HourlRateTB";
            this.HourlRateTB.Size = new System.Drawing.Size(146, 23);
            this.HourlRateTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hourly Rate:";
            // 
            // SuperPanel
            // 
            this.SuperPanel.Controls.Add(this.OfficeNumberTB);
            this.SuperPanel.Controls.Add(this.label6);
            this.SuperPanel.Controls.Add(this.groupBox1);
            this.SuperPanel.Location = new System.Drawing.Point(12, 201);
            this.SuperPanel.Name = "SuperPanel";
            this.SuperPanel.Size = new System.Drawing.Size(465, 130);
            this.SuperPanel.TabIndex = 5;
            // 
            // OfficeNumberTB
            // 
            this.OfficeNumberTB.Location = new System.Drawing.Point(119, 27);
            this.OfficeNumberTB.Name = "OfficeNumberTB";
            this.OfficeNumberTB.Size = new System.Drawing.Size(100, 23);
            this.OfficeNumberTB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Office Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.highAccessRadio);
            this.groupBox1.Controls.Add(this.medAccessRadio);
            this.groupBox1.Controls.Add(this.lowAccessRadio);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Access Level";
            // 
            // highAccessRadio
            // 
            this.highAccessRadio.AutoSize = true;
            this.highAccessRadio.Location = new System.Drawing.Point(7, 75);
            this.highAccessRadio.Name = "highAccessRadio";
            this.highAccessRadio.Size = new System.Drawing.Size(51, 19);
            this.highAccessRadio.TabIndex = 2;
            this.highAccessRadio.TabStop = true;
            this.highAccessRadio.Text = "High";
            this.highAccessRadio.UseVisualStyleBackColor = true;
            // 
            // medAccessRadio
            // 
            this.medAccessRadio.AutoSize = true;
            this.medAccessRadio.Location = new System.Drawing.Point(7, 48);
            this.medAccessRadio.Name = "medAccessRadio";
            this.medAccessRadio.Size = new System.Drawing.Size(70, 19);
            this.medAccessRadio.TabIndex = 1;
            this.medAccessRadio.TabStop = true;
            this.medAccessRadio.Text = "Medium";
            this.medAccessRadio.UseVisualStyleBackColor = true;
            // 
            // lowAccessRadio
            // 
            this.lowAccessRadio.AutoSize = true;
            this.lowAccessRadio.Location = new System.Drawing.Point(7, 23);
            this.lowAccessRadio.Name = "lowAccessRadio";
            this.lowAccessRadio.Size = new System.Drawing.Size(47, 19);
            this.lowAccessRadio.TabIndex = 0;
            this.lowAccessRadio.TabStop = true;
            this.lowAccessRadio.Text = "Low";
            this.lowAccessRadio.UseVisualStyleBackColor = true;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(603, 254);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 6;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.SuperPanel);
            this.Controls.Add(this.AdvancedPanel);
            this.Controls.Add(this.BasicPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmployeeDataGrid);
            this.Controls.Add(this.outJson);
            this.Name = "Form1";
            this.Text = " ";
            this.outJson.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.OutTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BasicPanel.ResumeLayout(false);
            this.BasicPanel.PerformLayout();
            this.AdvancedPanel.ResumeLayout(false);
            this.AdvancedPanel.PerformLayout();
            this.SuperPanel.ResumeLayout(false);
            this.SuperPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl outJson;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button InTxt;
        private System.Windows.Forms.Button InJson;
        private System.Windows.Forms.TabPage OutTabControl;
        private System.Windows.Forms.Button OutTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView EmployeeDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton BasicRadio;
        private System.Windows.Forms.RadioButton SuperRadio;
        private System.Windows.Forms.RadioButton AdvancedRadio;
        private System.Windows.Forms.Panel BasicPanel;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AdvancedPanel;
        private System.Windows.Forms.TextBox HoursTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HourlRateTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SuperPanel;
        private System.Windows.Forms.TextBox OfficeNumberTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton highAccessRadio;
        private System.Windows.Forms.RadioButton medAccessRadio;
        private System.Windows.Forms.RadioButton lowAccessRadio;
        private System.Windows.Forms.Button SubmitBtn;
    }
}

