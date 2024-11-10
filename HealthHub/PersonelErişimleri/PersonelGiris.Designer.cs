namespace HealthHub.PersonelErişimleri
{
    partial class PersonelGiris
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
            this.Parola = new System.Windows.Forms.TextBox();
            this.KullaniciAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Parola
            // 
            this.Parola.Location = new System.Drawing.Point(90, 84);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(138, 20);
            this.Parola.TabIndex = 17;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Location = new System.Drawing.Point(90, 23);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(138, 20);
            this.KullaniciAdi.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "VAZGEÇ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Giris
            // 
            this.Giris.Location = new System.Drawing.Point(153, 152);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(75, 23);
            this.Giris.TabIndex = 14;
            this.Giris.Text = "GİRİŞ";
            this.Giris.UseVisualStyleBackColor = true;
            this.Giris.Click += new System.EventHandler(this.Giris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Parola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 254);
            this.ControlBox = false;
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.KullaniciAdi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonelGiris";
            this.Text = "PersonelGiris";
            this.Load += new System.EventHandler(this.PersonelGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.TextBox KullaniciAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}