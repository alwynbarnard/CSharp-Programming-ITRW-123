namespace rectangle
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
            this.btnRectangle = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.pbxShape = new System.Windows.Forms.PictureBox();
            this.lblLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShape)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRectangle
            // 
            this.btnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRectangle.Location = new System.Drawing.Point(84, 32);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(138, 58);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.Text = "Draw Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(351, 41);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 24);
            this.txtLength.TabIndex = 1;
            this.txtLength.Text = "Length";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pbxShape
            // 
            this.pbxShape.BackColor = System.Drawing.Color.Gray;
            this.pbxShape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxShape.Location = new System.Drawing.Point(47, 112);
            this.pbxShape.Name = "pbxShape";
            this.pbxShape.Size = new System.Drawing.Size(470, 191);
            this.pbxShape.TabIndex = 2;
            this.pbxShape.TabStop = false;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(321, 13);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(154, 25);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Enter length: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(578, 347);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.pbxShape);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.btnRectangle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxShape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.PictureBox pbxShape;
        private System.Windows.Forms.Label lblLength;
    }
}

