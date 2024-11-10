namespace HealthHub.PersonelErişimleri
{
    partial class TumHastalar
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
            this.Vazgec = new System.Windows.Forms.Button();
            this.Hasta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Hasta)).BeginInit();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(12, 355);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 9;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // Hasta
            // 
            this.Hasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hasta.Location = new System.Drawing.Point(12, 12);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(370, 307);
            this.Hasta.TabIndex = 10;
            // 
            // TumHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 390);
            this.ControlBox = false;
            this.Controls.Add(this.Hasta);
            this.Controls.Add(this.Vazgec);
            this.Name = "TumHastalar";
            this.Text = "Hastalar";
            this.Load += new System.EventHandler(this.TumHastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.DataGridView Hasta;
    }
}