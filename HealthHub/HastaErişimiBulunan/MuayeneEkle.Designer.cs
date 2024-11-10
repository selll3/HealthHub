namespace HealthHub
{
    partial class MuayeneEkle
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
            this.DoktorBransi = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TarihVeSaat = new System.Windows.Forms.Label();
            this.Brans = new System.Windows.Forms.Label();
            this.Doktorlar = new System.Windows.Forms.Label();
            this.MuayeneOlustur = new System.Windows.Forms.Button();
            this.Vazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoktorBransi
            // 
            this.DoktorBransi.FormattingEnabled = true;
            this.DoktorBransi.Location = new System.Drawing.Point(326, 95);
            this.DoktorBransi.Name = "DoktorBransi";
            this.DoktorBransi.Size = new System.Drawing.Size(102, 21);
            this.DoktorBransi.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "KBB",
            "Dahiliye",
            "Kardiyoloji"});
            this.comboBox1.Location = new System.Drawing.Point(105, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // TarihVeSaat
            // 
            this.TarihVeSaat.AutoSize = true;
            this.TarihVeSaat.Location = new System.Drawing.Point(12, 28);
            this.TarihVeSaat.Name = "TarihVeSaat";
            this.TarihVeSaat.Size = new System.Drawing.Size(77, 13);
            this.TarihVeSaat.TabIndex = 3;
            this.TarihVeSaat.Text = "Tarih ve Saat :";
            // 
            // Brans
            // 
            this.Brans.AutoSize = true;
            this.Brans.Location = new System.Drawing.Point(12, 98);
            this.Brans.Name = "Brans";
            this.Brans.Size = new System.Drawing.Size(74, 13);
            this.Brans.TabIndex = 4;
            this.Brans.Text = "Branş Seçimi :";
            // 
            // Doktorlar
            // 
            this.Doktorlar.AutoSize = true;
            this.Doktorlar.Location = new System.Drawing.Point(264, 98);
            this.Doktorlar.Name = "Doktorlar";
            this.Doktorlar.Size = new System.Drawing.Size(56, 13);
            this.Doktorlar.TabIndex = 5;
            this.Doktorlar.Text = "Doktorlar :";
            // 
            // MuayeneOlustur
            // 
            this.MuayeneOlustur.Location = new System.Drawing.Point(272, 220);
            this.MuayeneOlustur.Name = "MuayeneOlustur";
            this.MuayeneOlustur.Size = new System.Drawing.Size(156, 22);
            this.MuayeneOlustur.TabIndex = 6;
            this.MuayeneOlustur.Text = "Muayene Oluştur";
            this.MuayeneOlustur.UseVisualStyleBackColor = true;
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(15, 220);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 7;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // MuayeneEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 295);
            this.ControlBox = false;
            this.Controls.Add(this.Vazgec);
            this.Controls.Add(this.MuayeneOlustur);
            this.Controls.Add(this.Doktorlar);
            this.Controls.Add(this.Brans);
            this.Controls.Add(this.TarihVeSaat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DoktorBransi);
            this.Name = "MuayeneEkle";
            this.Text = "MuayeneEkle";
            this.Load += new System.EventHandler(this.MuayeneEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DoktorBransi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label TarihVeSaat;
        private System.Windows.Forms.Label Brans;
        private System.Windows.Forms.Label Doktorlar;
        private System.Windows.Forms.Button MuayeneOlustur;
        private System.Windows.Forms.Button Vazgec;
    }
}