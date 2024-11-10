namespace HealthHub
{
    partial class KullanciKayit
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
            this.KullaniciKayit = new System.Windows.Forms.Button();
            this.ParolaKayit = new System.Windows.Forms.TextBox();
            this.KullaniciAdiKayit = new System.Windows.Forms.TextBox();
            this.Parola = new System.Windows.Forms.Label();
            this.KullaniciAdi = new System.Windows.Forms.Label();
            this.Vazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullaniciKayit
            // 
            this.KullaniciKayit.Location = new System.Drawing.Point(142, 130);
            this.KullaniciKayit.Name = "KullaniciKayit";
            this.KullaniciKayit.Size = new System.Drawing.Size(75, 23);
            this.KullaniciKayit.TabIndex = 9;
            this.KullaniciKayit.Text = "KAYIT OL";
            this.KullaniciKayit.UseVisualStyleBackColor = true;
            // 
            // ParolaKayit
            // 
            this.ParolaKayit.Location = new System.Drawing.Point(84, 61);
            this.ParolaKayit.Name = "ParolaKayit";
            this.ParolaKayit.Size = new System.Drawing.Size(133, 20);
            this.ParolaKayit.TabIndex = 8;
            // 
            // KullaniciAdiKayit
            // 
            this.KullaniciAdiKayit.Location = new System.Drawing.Point(84, 12);
            this.KullaniciAdiKayit.Name = "KullaniciAdiKayit";
            this.KullaniciAdiKayit.Size = new System.Drawing.Size(133, 20);
            this.KullaniciAdiKayit.TabIndex = 7;
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Location = new System.Drawing.Point(8, 68);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(43, 13);
            this.Parola.TabIndex = 6;
            this.Parola.Text = "Parola :";
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.AutoSize = true;
            this.KullaniciAdi.Location = new System.Drawing.Point(8, 15);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(70, 13);
            this.KullaniciAdi.TabIndex = 5;
            this.KullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(11, 130);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 10;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            // 
            // KullanciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 171);
            this.ControlBox = false;
            this.Controls.Add(this.Vazgec);
            this.Controls.Add(this.KullaniciKayit);
            this.Controls.Add(this.ParolaKayit);
            this.Controls.Add(this.KullaniciAdiKayit);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.KullaniciAdi);
            this.Name = "KullanciKayit";
            this.Text = "KullanciKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KullaniciKayit;
        private System.Windows.Forms.TextBox ParolaKayit;
        private System.Windows.Forms.TextBox KullaniciAdiKayit;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.Label KullaniciAdi;
        private System.Windows.Forms.Button Vazgec;
    }
}