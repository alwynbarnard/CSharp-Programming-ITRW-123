namespace Prak_6_Deel_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnSalaried = new System.Windows.Forms.RadioButton();
            this.rbnHourly = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWeek = new System.Windows.Forms.TextBox();
            this.txtHrs = new System.Windows.Forms.TextBox();
            this.txtHRSW = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(160, 30);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(100, 20);
            this.txtFN.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(160, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(370, 27);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(100, 20);
            this.txtLN.TabIndex = 5;
            this.txtLN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHRSW);
            this.groupBox1.Controls.Add(this.txtHrs);
            this.groupBox1.Controls.Add(this.txtWeek);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbnHourly);
            this.groupBox1.Controls.Add(this.rbnSalaried);
            this.groupBox1.Location = new System.Drawing.Point(81, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 126);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbnSalaried
            // 
            this.rbnSalaried.AutoSize = true;
            this.rbnSalaried.Location = new System.Drawing.Point(22, 20);
            this.rbnSalaried.Name = "rbnSalaried";
            this.rbnSalaried.Size = new System.Drawing.Size(63, 17);
            this.rbnSalaried.TabIndex = 0;
            this.rbnSalaried.TabStop = true;
            this.rbnSalaried.Text = "Salaried";
            this.rbnSalaried.UseVisualStyleBackColor = true;
            // 
            // rbnHourly
            // 
            this.rbnHourly.AutoSize = true;
            this.rbnHourly.Location = new System.Drawing.Point(138, 20);
            this.rbnHourly.Name = "rbnHourly";
            this.rbnHourly.Size = new System.Drawing.Size(55, 17);
            this.rbnHourly.TabIndex = 1;
            this.rbnHourly.TabStop = true;
            this.rbnHourly.Text = "Hourly";
            this.rbnHourly.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weekly Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hours rate:";
            // 
            // txtWeek
            // 
            this.txtWeek.Location = new System.Drawing.Point(22, 85);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(100, 20);
            this.txtWeek.TabIndex = 6;
            // 
            // txtHrs
            // 
            this.txtHrs.Location = new System.Drawing.Point(219, 49);
            this.txtHrs.Name = "txtHrs";
            this.txtHrs.Size = new System.Drawing.Size(100, 20);
            this.txtHrs.TabIndex = 7;
            // 
            // txtHRSW
            // 
            this.txtHRSW.Location = new System.Drawing.Point(219, 92);
            this.txtHRSW.Name = "txtHRSW";
            this.txtHRSW.Size = new System.Drawing.Size(100, 20);
            this.txtHRSW.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(81, 235);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(412, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate Payslip";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(81, 281);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 95);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 384);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHRSW;
        private System.Windows.Forms.TextBox txtHrs;
        private System.Windows.Forms.TextBox txtWeek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbnHourly;
        private System.Windows.Forms.RadioButton rbnSalaried;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listBox1;
    }
}

