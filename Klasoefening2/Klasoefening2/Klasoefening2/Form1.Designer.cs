namespace Klasoefening2
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
            this.btnTeken = new System.Windows.Forms.Button();
            this.picTeken = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTeken)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTeken
            // 
            this.btnTeken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeken.Location = new System.Drawing.Point(60, 31);
            this.btnTeken.Name = "btnTeken";
            this.btnTeken.Size = new System.Drawing.Size(117, 35);
            this.btnTeken.TabIndex = 0;
            this.btnTeken.Text = "Teken";
            this.btnTeken.UseVisualStyleBackColor = true;
            this.btnTeken.Click += new System.EventHandler(this.btnTeken_Click);
            // 
            // picTeken
            // 
            this.picTeken.Location = new System.Drawing.Point(60, 125);
            this.picTeken.Name = "picTeken";
            this.picTeken.Size = new System.Drawing.Size(756, 301);
            this.picTeken.TabIndex = 1;
            this.picTeken.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 493);
            this.Controls.Add(this.picTeken);
            this.Controls.Add(this.btnTeken);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picTeken)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeken;
        private System.Windows.Forms.PictureBox picTeken;
    }
}

