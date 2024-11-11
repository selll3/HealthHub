namespace HealthHub.PersonelErişimleri
{
    partial class PersonelAnaMenu
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
            this.DoktorMuayeneleri = new System.Windows.Forms.Button();
            this.Hastalar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._KullaniciIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(12, 259);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 9;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // DoktorMuayeneleri
            // 
            this.DoktorMuayeneleri.Location = new System.Drawing.Point(12, 12);
            this.DoktorMuayeneleri.Name = "DoktorMuayeneleri";
            this.DoktorMuayeneleri.Size = new System.Drawing.Size(184, 28);
            this.DoktorMuayeneleri.TabIndex = 10;
            this.DoktorMuayeneleri.Text = "Doktor Muayeneleri";
            this.DoktorMuayeneleri.UseVisualStyleBackColor = true;
            // 
            // Hastalar
            // 
            this.Hastalar.Location = new System.Drawing.Point(12, 74);
            this.Hastalar.Name = "Hastalar";
            this.Hastalar.Size = new System.Drawing.Size(184, 28);
            this.Hastalar.TabIndex = 11;
            this.Hastalar.Text = "Hastalar";
            this.Hastalar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Tahlil Verilerinin Kaydı";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // _KullaniciIslemleri
            // 
            this._KullaniciIslemleri.Location = new System.Drawing.Point(12, 192);
            this._KullaniciIslemleri.Name = "_KullaniciIslemleri";
            this._KullaniciIslemleri.Size = new System.Drawing.Size(181, 23);
            this._KullaniciIslemleri.TabIndex = 13;
            this._KullaniciIslemleri.Text = "Kullanıcı işlemleri";
            this._KullaniciIslemleri.UseVisualStyleBackColor = true;
            this._KullaniciIslemleri.Click += new System.EventHandler(this._KullaniciIslemleri_Click);
            // 
            // PersonelAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 326);
            this.ControlBox = false;
            this.Controls.Add(this._KullaniciIslemleri);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Hastalar);
            this.Controls.Add(this.DoktorMuayeneleri);
            this.Controls.Add(this.Vazgec);
            this.Name = "PersonelAnaMenu";
            this.Text = "PersonelAnaMenu";
            this.Load += new System.EventHandler(this.PersonelAnaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.Button DoktorMuayeneleri;
        private System.Windows.Forms.Button Hastalar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button _KullaniciIslemleri;
    }
}