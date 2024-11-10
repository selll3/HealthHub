namespace HealthHub
{
    partial class Baslangic
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
            this.HastaGiris = new System.Windows.Forms.Button();
            this.PersonelGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HastaGiris
            // 
            this.HastaGiris.Location = new System.Drawing.Point(21, 63);
            this.HastaGiris.Name = "HastaGiris";
            this.HastaGiris.Size = new System.Drawing.Size(191, 33);
            this.HastaGiris.TabIndex = 0;
            this.HastaGiris.Text = "Hasta Giriş";
            this.HastaGiris.UseVisualStyleBackColor = true;
            this.HastaGiris.Click += new System.EventHandler(this.HastaGiris_Click);
            // 
            // PersonelGiris
            // 
            this.PersonelGiris.Location = new System.Drawing.Point(21, 137);
            this.PersonelGiris.Name = "PersonelGiris";
            this.PersonelGiris.Size = new System.Drawing.Size(191, 33);
            this.PersonelGiris.TabIndex = 1;
            this.PersonelGiris.Text = "Personel Giriş";
            this.PersonelGiris.UseVisualStyleBackColor = true;
            // 
            // Baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 241);
            this.Controls.Add(this.PersonelGiris);
            this.Controls.Add(this.HastaGiris);
            this.Name = "Baslangic";
            this.Text = "Baslangic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HastaGiris;
        private System.Windows.Forms.Button PersonelGiris;
    }
}