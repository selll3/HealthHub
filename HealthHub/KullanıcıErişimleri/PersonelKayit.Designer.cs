namespace HealthHub
{
    partial class PersonelKayit
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
            this.kayit = new System.Windows.Forms.Button();
            this.Vazgec = new System.Windows.Forms.Button();
            this.PersonelAdi = new System.Windows.Forms.TextBox();
            this.PersonelSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonelGorev = new System.Windows.Forms.ComboBox();
            this.HangiKullanici = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DoktorBransi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Soyadı :";
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(167, 339);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(75, 23);
            this.kayit.TabIndex = 2;
            this.kayit.Text = "KAYIT";
            this.kayit.UseVisualStyleBackColor = true;
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(6, 339);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 9;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.Location = new System.Drawing.Point(104, 41);
            this.PersonelAdi.Name = "PersonelAdi";
            this.PersonelAdi.Size = new System.Drawing.Size(138, 20);
            this.PersonelAdi.TabIndex = 10;
            // 
            // PersonelSoyadi
            // 
            this.PersonelSoyadi.Location = new System.Drawing.Point(104, 97);
            this.PersonelSoyadi.Name = "PersonelSoyadi";
            this.PersonelSoyadi.Size = new System.Drawing.Size(138, 20);
            this.PersonelSoyadi.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personel Görevi :";
            // 
            // PersonelGorev
            // 
            this.PersonelGorev.FormattingEnabled = true;
            this.PersonelGorev.Items.AddRange(new object[] {
            "Doktor",
            "Sekreter",
            "Hemşire"});
            this.PersonelGorev.Location = new System.Drawing.Point(104, 156);
            this.PersonelGorev.Name = "PersonelGorev";
            this.PersonelGorev.Size = new System.Drawing.Size(138, 21);
            this.PersonelGorev.TabIndex = 13;
            // 
            // HangiKullanici
            // 
            this.HangiKullanici.FormattingEnabled = true;
            this.HangiKullanici.Location = new System.Drawing.Point(104, 215);
            this.HangiKullanici.Name = "HangiKullanici";
            this.HangiKullanici.Size = new System.Drawing.Size(138, 21);
            this.HangiKullanici.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hangi Kullanıcı?";
            // 
            // DoktorBransi
            // 
            this.DoktorBransi.FormattingEnabled = true;
            this.DoktorBransi.Items.AddRange(new object[] {
            "Dahiliye",
            "KBB",
            "Kardiyoloji",
            ""});
            this.DoktorBransi.Location = new System.Drawing.Point(104, 271);
            this.DoktorBransi.Name = "DoktorBransi";
            this.DoktorBransi.Size = new System.Drawing.Size(138, 21);
            this.DoktorBransi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Doktor ise Branşı?";
            // 
            // PersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 413);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DoktorBransi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HangiKullanici);
            this.Controls.Add(this.PersonelGorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PersonelSoyadi);
            this.Controls.Add(this.PersonelAdi);
            this.Controls.Add(this.Vazgec);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonelKayit";
            this.Text = "PersonelKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.TextBox PersonelAdi;
        private System.Windows.Forms.TextBox PersonelSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PersonelGorev;
        private System.Windows.Forms.ComboBox HangiKullanici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DoktorBransi;
        private System.Windows.Forms.Label label5;
    }
}