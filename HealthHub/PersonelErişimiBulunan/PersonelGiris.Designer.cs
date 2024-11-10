namespace HealthHub
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
            this.KullaniciAdi = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Vazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.AutoSize = true;
            this.KullaniciAdi.Location = new System.Drawing.Point(2, 34);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(70, 13);
            this.KullaniciAdi.TabIndex = 0;
            this.KullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Location = new System.Drawing.Point(2, 87);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(43, 13);
            this.Parola.TabIndex = 1;
            this.Parola.Text = "Parola :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(5, 150);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(75, 22);
            this.Vazgec.TabIndex = 8;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 205);
            this.Controls.Add(this.Vazgec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.KullaniciAdi);
            this.Name = "PersonelGiris";
            this.Text = "PersonelGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullaniciAdi;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Vazgec;
    }
}