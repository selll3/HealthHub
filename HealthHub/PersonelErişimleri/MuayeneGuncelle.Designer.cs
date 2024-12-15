namespace HealthHub.PersonelErişimleri
{
    partial class MuayeneGuncelle
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
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxHasta = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.KAYDET = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Doktorlar = new System.Windows.Forms.Label();
            this.hastasecimi = new System.Windows.Forms.Label();
            this.TarihVeSaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(116, 49);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDoktor.TabIndex = 0;
            // 
            // comboBoxHasta
            // 
            this.comboBoxHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.comboBoxHasta.FormattingEnabled = true;
            this.comboBoxHasta.Location = new System.Drawing.Point(116, 98);
            this.comboBoxHasta.Name = "comboBoxHasta";
            this.comboBoxHasta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHasta.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // KAYDET
            // 
            this.KAYDET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.KAYDET.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.KAYDET.Location = new System.Drawing.Point(229, 149);
            this.KAYDET.Name = "KAYDET";
            this.KAYDET.Size = new System.Drawing.Size(75, 27);
            this.KAYDET.TabIndex = 3;
            this.KAYDET.Text = "KAYDET";
            this.KAYDET.UseVisualStyleBackColor = false;
            this.KAYDET.Click += new System.EventHandler(this.KAYDET_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.button2.Location = new System.Drawing.Point(6, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "VAZGEÇ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Doktorlar
            // 
            this.Doktorlar.AutoSize = true;
            this.Doktorlar.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.Doktorlar.Location = new System.Drawing.Point(3, 100);
            this.Doktorlar.Name = "Doktorlar";
            this.Doktorlar.Size = new System.Drawing.Size(89, 16);
            this.Doktorlar.TabIndex = 8;
            this.Doktorlar.Text = "Doktorlar :";
            // 
            // hastasecimi
            // 
            this.hastasecimi.AutoSize = true;
            this.hastasecimi.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.hastasecimi.Location = new System.Drawing.Point(3, 54);
            this.hastasecimi.Name = "hastasecimi";
            this.hastasecimi.Size = new System.Drawing.Size(101, 16);
            this.hastasecimi.TabIndex = 7;
            this.hastasecimi.Text = "Hasta Seçimi :";
            // 
            // TarihVeSaat
            // 
            this.TarihVeSaat.AutoSize = true;
            this.TarihVeSaat.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.TarihVeSaat.Location = new System.Drawing.Point(3, 9);
            this.TarihVeSaat.Name = "TarihVeSaat";
            this.TarihVeSaat.Size = new System.Drawing.Size(107, 16);
            this.TarihVeSaat.TabIndex = 6;
            this.TarihVeSaat.Text = "Tarih ve Saat :";
            // 
            // MuayeneGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 336);
            this.ControlBox = false;
            this.Controls.Add(this.Doktorlar);
            this.Controls.Add(this.hastasecimi);
            this.Controls.Add(this.TarihVeSaat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KAYDET);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxHasta);
            this.Controls.Add(this.comboBoxDoktor);
            this.Name = "MuayeneGuncelle";
            this.Text = "                               ";
            this.Load += new System.EventHandler(this.MuayeneGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.ComboBox comboBoxHasta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button KAYDET;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Doktorlar;
        private System.Windows.Forms.Label hastasecimi;
        private System.Windows.Forms.Label TarihVeSaat;
    }
}