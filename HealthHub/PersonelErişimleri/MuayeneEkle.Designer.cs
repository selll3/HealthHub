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
            this.Doktor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TarihVeSaat = new System.Windows.Forms.Label();
            this.hastasecimi = new System.Windows.Forms.Label();
            this.Doktorlar = new System.Windows.Forms.Label();
            this.MuayeneOlustur = new System.Windows.Forms.Button();
            this.Vazgec = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Doktor
            // 
            this.Doktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Doktor.FormattingEnabled = true;
            this.Doktor.Location = new System.Drawing.Point(125, 103);
            this.Doktor.Name = "Doktor";
            this.Doktor.Size = new System.Drawing.Size(121, 21);
            this.Doktor.TabIndex = 0;
            this.Doktor.SelectedIndexChanged += new System.EventHandler(this.DoktorBransi_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // TarihVeSaat
            // 
            this.TarihVeSaat.AutoSize = true;
            this.TarihVeSaat.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.TarihVeSaat.Location = new System.Drawing.Point(6, 9);
            this.TarihVeSaat.Name = "TarihVeSaat";
            this.TarihVeSaat.Size = new System.Drawing.Size(107, 16);
            this.TarihVeSaat.TabIndex = 3;
            this.TarihVeSaat.Text = "Tarih ve Saat :";
            // 
            // hastasecimi
            // 
            this.hastasecimi.AutoSize = true;
            this.hastasecimi.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.hastasecimi.Location = new System.Drawing.Point(6, 55);
            this.hastasecimi.Name = "hastasecimi";
            this.hastasecimi.Size = new System.Drawing.Size(101, 16);
            this.hastasecimi.TabIndex = 4;
            this.hastasecimi.Text = "Hasta Seçimi :";
            // 
            // Doktorlar
            // 
            this.Doktorlar.AutoSize = true;
            this.Doktorlar.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.Doktorlar.Location = new System.Drawing.Point(6, 108);
            this.Doktorlar.Name = "Doktorlar";
            this.Doktorlar.Size = new System.Drawing.Size(89, 16);
            this.Doktorlar.TabIndex = 5;
            this.Doktorlar.Text = "Doktorlar :";
            // 
            // MuayeneOlustur
            // 
            this.MuayeneOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MuayeneOlustur.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.MuayeneOlustur.Location = new System.Drawing.Point(9, 158);
            this.MuayeneOlustur.Name = "MuayeneOlustur";
            this.MuayeneOlustur.Size = new System.Drawing.Size(156, 28);
            this.MuayeneOlustur.TabIndex = 6;
            this.MuayeneOlustur.Text = "Muayene Oluştur";
            this.MuayeneOlustur.UseVisualStyleBackColor = false;
            this.MuayeneOlustur.Click += new System.EventHandler(this.MuayeneOlustur_Click);
            // 
            // Vazgec
            // 
            this.Vazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Vazgec.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.Vazgec.Location = new System.Drawing.Point(262, 158);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 28);
            this.Vazgec.TabIndex = 7;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = false;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MuayeneEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 242);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Vazgec);
            this.Controls.Add(this.MuayeneOlustur);
            this.Controls.Add(this.Doktorlar);
            this.Controls.Add(this.hastasecimi);
            this.Controls.Add(this.TarihVeSaat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Doktor);
            this.Name = "MuayeneEkle";
            this.Text = "MuayeneEkle";
            this.Load += new System.EventHandler(this.MuayeneEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Doktor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label TarihVeSaat;
        private System.Windows.Forms.Label hastasecimi;
        private System.Windows.Forms.Label Doktorlar;
        private System.Windows.Forms.Button MuayeneOlustur;
        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}