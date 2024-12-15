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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // KullaniciKayit
            // 
            this.KullaniciKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.KullaniciKayit.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.KullaniciKayit.Location = new System.Drawing.Point(280, 82);
            this.KullaniciKayit.Name = "KullaniciKayit";
            this.KullaniciKayit.Size = new System.Drawing.Size(75, 23);
            this.KullaniciKayit.TabIndex = 9;
            this.KullaniciKayit.Text = "KAYIT OL";
            this.KullaniciKayit.UseVisualStyleBackColor = false;
            this.KullaniciKayit.Click += new System.EventHandler(this.KullaniciKayit_Click);
            // 
            // ParolaKayit
            // 
            this.ParolaKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.ParolaKayit.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.ParolaKayit.Location = new System.Drawing.Point(105, 40);
            this.ParolaKayit.Name = "ParolaKayit";
            this.ParolaKayit.PasswordChar = '#';
            this.ParolaKayit.Size = new System.Drawing.Size(133, 22);
            this.ParolaKayit.TabIndex = 8;
            // 
            // KullaniciAdiKayit
            // 
            this.KullaniciAdiKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.KullaniciAdiKayit.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.KullaniciAdiKayit.Location = new System.Drawing.Point(105, 6);
            this.KullaniciAdiKayit.Name = "KullaniciAdiKayit";
            this.KullaniciAdiKayit.Size = new System.Drawing.Size(133, 22);
            this.KullaniciAdiKayit.TabIndex = 7;
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.Parola.Location = new System.Drawing.Point(-1, 40);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(58, 15);
            this.Parola.TabIndex = 6;
            this.Parola.Text = "Parola :";
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.AutoSize = true;
            this.KullaniciAdi.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.KullaniciAdi.Location = new System.Drawing.Point(-1, 9);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(100, 15);
            this.KullaniciAdi.TabIndex = 5;
            this.KullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // Vazgec
            // 
            this.Vazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Vazgec.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.Vazgec.Location = new System.Drawing.Point(2, 83);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 10;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = false;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.checkBox1.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.checkBox1.Location = new System.Drawing.Point(243, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Parolayı Gör";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KullanciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 128);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Vazgec);
            this.Controls.Add(this.KullaniciKayit);
            this.Controls.Add(this.ParolaKayit);
            this.Controls.Add(this.KullaniciAdiKayit);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.KullaniciAdi);
            this.Name = "KullanciKayit";
            this.Text = "KullanciKayit";
            this.Load += new System.EventHandler(this.KullanciKayit_Load);
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
        private System.Windows.Forms.CheckBox checkBox1;
    }
}