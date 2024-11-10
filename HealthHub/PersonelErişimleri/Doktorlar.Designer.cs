namespace HealthHub.PersonelErişimleri
{
    partial class Doktorlar
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
            this.Doktor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Doktor)).BeginInit();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(12, 318);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 10;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            // 
            // Doktor
            // 
            this.Doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doktor.Location = new System.Drawing.Point(12, 12);
            this.Doktor.Name = "Doktor";
            this.Doktor.Size = new System.Drawing.Size(379, 277);
            this.Doktor.TabIndex = 11;
            // 
            // Doktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 354);
            this.ControlBox = false;
            this.Controls.Add(this.Doktor);
            this.Controls.Add(this.Vazgec);
            this.Name = "Doktorlar";
            this.Text = "Doktorlar";
            ((System.ComponentModel.ISupportInitialize)(this.Doktor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.DataGridView Doktor;
    }
}