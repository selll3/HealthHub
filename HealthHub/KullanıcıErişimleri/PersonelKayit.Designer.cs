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
            this.label3 = new System.Windows.Forms.Label();
            this.PersonelGorev = new System.Windows.Forms.ComboBox();
            this.HangiKullanici = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DoktorBransi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._PersonelAdi = new System.Windows.Forms.TextBox();
            this._PersonelSoyadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Soyadı :";
            // 
            // kayit
            // 
            this.kayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kayit.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold);
            this.kayit.Location = new System.Drawing.Point(207, 335);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(78, 31);
            this.kayit.TabIndex = 2;
            this.kayit.Text = "KAYIT";
            this.kayit.UseVisualStyleBackColor = false;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // Vazgec
            // 
            this.Vazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Vazgec.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold);
            this.Vazgec.Location = new System.Drawing.Point(8, 335);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 31);
            this.Vazgec.TabIndex = 9;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = false;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personel Görevi :";
            // 
            // PersonelGorev
            // 
            this.PersonelGorev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.PersonelGorev.Font = new System.Drawing.Font("Lucida Bright", 9F);
            this.PersonelGorev.ForeColor = System.Drawing.Color.Black;
            this.PersonelGorev.FormattingEnabled = true;
            this.PersonelGorev.Items.AddRange(new object[] {
            "DOKTOR\t",
            "LABORANT",
            "SEKRETER"});
            this.PersonelGorev.Location = new System.Drawing.Point(147, 163);
            this.PersonelGorev.Name = "PersonelGorev";
            this.PersonelGorev.Size = new System.Drawing.Size(138, 23);
            this.PersonelGorev.TabIndex = 13;
            // 
            // HangiKullanici
            // 
            this.HangiKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.HangiKullanici.Font = new System.Drawing.Font("Lucida Bright", 9F);
            this.HangiKullanici.ForeColor = System.Drawing.Color.Black;
            this.HangiKullanici.FormattingEnabled = true;
            this.HangiKullanici.Location = new System.Drawing.Point(147, 222);
            this.HangiKullanici.Name = "HangiKullanici";
            this.HangiKullanici.Size = new System.Drawing.Size(138, 23);
            this.HangiKullanici.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hangi Kullanıcı?";
            // 
            // DoktorBransi
            // 
            this.DoktorBransi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.DoktorBransi.Font = new System.Drawing.Font("Lucida Bright", 9F);
            this.DoktorBransi.ForeColor = System.Drawing.Color.Black;
            this.DoktorBransi.FormattingEnabled = true;
            this.DoktorBransi.Items.AddRange(new object[] {
            "Dahiliye",
            "KBB",
            "Kardiyoloji",
            ""});
            this.DoktorBransi.Location = new System.Drawing.Point(147, 274);
            this.DoktorBransi.Name = "DoktorBransi";
            this.DoktorBransi.Size = new System.Drawing.Size(138, 23);
            this.DoktorBransi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Doktor ise Branşı?";
            // 
            // _PersonelAdi
            // 
            this._PersonelAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this._PersonelAdi.Font = new System.Drawing.Font("Lucida Bright", 9F);
            this._PersonelAdi.Location = new System.Drawing.Point(147, 44);
            this._PersonelAdi.Name = "_PersonelAdi";
            this._PersonelAdi.Size = new System.Drawing.Size(138, 22);
            this._PersonelAdi.TabIndex = 18;
            // 
            // _PersonelSoyadi
            // 
            this._PersonelSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this._PersonelSoyadi.Font = new System.Drawing.Font("Lucida Bright", 9F);
            this._PersonelSoyadi.Location = new System.Drawing.Point(147, 96);
            this._PersonelSoyadi.Name = "_PersonelSoyadi";
            this._PersonelSoyadi.Size = new System.Drawing.Size(138, 22);
            this._PersonelSoyadi.TabIndex = 19;
            // 
            // PersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 399);
            this.ControlBox = false;
            this.Controls.Add(this._PersonelSoyadi);
            this.Controls.Add(this._PersonelAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DoktorBransi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HangiKullanici);
            this.Controls.Add(this.PersonelGorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Vazgec);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonelKayit";
            this.Text = "PersonelKayit";
            this.Load += new System.EventHandler(this.PersonelKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PersonelGorev;
        private System.Windows.Forms.ComboBox HangiKullanici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DoktorBransi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _PersonelAdi;
        private System.Windows.Forms.TextBox _PersonelSoyadi;
    }
}