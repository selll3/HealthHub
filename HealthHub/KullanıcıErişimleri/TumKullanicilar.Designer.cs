namespace HealthHub.KullanıcıErişimleri
{
    partial class TumKullanicilar
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
            this.TumKullancilar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TumKullancilar)).BeginInit();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(12, 255);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 10;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // TumKullancilar
            // 
            this.TumKullancilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TumKullancilar.Location = new System.Drawing.Point(12, 12);
            this.TumKullancilar.Name = "TumKullancilar";
            this.TumKullancilar.Size = new System.Drawing.Size(292, 213);
            this.TumKullancilar.TabIndex = 11;
            // 
            // TümKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 288);
            this.ControlBox = false;
            this.Controls.Add(this.TumKullancilar);
            this.Controls.Add(this.Vazgec);
            this.Name = "TümKullanicilar";
            this.Text = "TümKullanicilar";
            ((System.ComponentModel.ISupportInitialize)(this.TumKullancilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.DataGridView TumKullancilar;
    }
}