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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuayeneGuncelle));
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxHasta = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.KAYDET = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Doktorlar = new System.Windows.Forms.Label();
            this.hastasecimi = new System.Windows.Forms.Label();
            this.TarihVeSaat = new System.Windows.Forms.Label();
            this._DoktorunSaatleri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(116, 122);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDoktor.TabIndex = 0;
            // 
            // comboBoxHasta
            // 
            this.comboBoxHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.comboBoxHasta.FormattingEnabled = true;
            this.comboBoxHasta.Location = new System.Drawing.Point(116, 76);
            this.comboBoxHasta.Name = "comboBoxHasta";
            this.comboBoxHasta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHasta.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // KAYDET
            // 
            this.KAYDET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(155)))));
            this.KAYDET.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.KAYDET.Location = new System.Drawing.Point(452, 181);
            this.KAYDET.Name = "KAYDET";
            this.KAYDET.Size = new System.Drawing.Size(75, 27);
            this.KAYDET.TabIndex = 3;
            this.KAYDET.Text = "KAYDET";
            this.KAYDET.UseVisualStyleBackColor = false;
            this.KAYDET.Click += new System.EventHandler(this.KAYDET_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.button2.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.button2.Location = new System.Drawing.Point(6, 181);
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
            this.Doktorlar.BackColor = System.Drawing.Color.Transparent;
            this.Doktorlar.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.Doktorlar.Location = new System.Drawing.Point(3, 122);
            this.Doktorlar.Name = "Doktorlar";
            this.Doktorlar.Size = new System.Drawing.Size(78, 18);
            this.Doktorlar.TabIndex = 8;
            this.Doktorlar.Text = "Doktorlar :";
            // 
            // hastasecimi
            // 
            this.hastasecimi.AutoSize = true;
            this.hastasecimi.BackColor = System.Drawing.Color.Transparent;
            this.hastasecimi.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.hastasecimi.Location = new System.Drawing.Point(3, 76);
            this.hastasecimi.Name = "hastasecimi";
            this.hastasecimi.Size = new System.Drawing.Size(96, 18);
            this.hastasecimi.TabIndex = 7;
            this.hastasecimi.Text = "Hasta Seçimi :";
            // 
            // TarihVeSaat
            // 
            this.TarihVeSaat.AutoSize = true;
            this.TarihVeSaat.BackColor = System.Drawing.Color.Transparent;
            this.TarihVeSaat.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.TarihVeSaat.Location = new System.Drawing.Point(3, 31);
            this.TarihVeSaat.Name = "TarihVeSaat";
            this.TarihVeSaat.Size = new System.Drawing.Size(99, 18);
            this.TarihVeSaat.TabIndex = 6;
            this.TarihVeSaat.Text = "Tarih ve Saat :";
            // 
            // _DoktorunSaatleri
            // 
            this._DoktorunSaatleri.FormattingEnabled = true;
            this._DoktorunSaatleri.Location = new System.Drawing.Point(427, 119);
            this._DoktorunSaatleri.Name = "_DoktorunSaatleri";
            this._DoktorunSaatleri.Size = new System.Drawing.Size(118, 21);
            this._DoktorunSaatleri.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(245, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seçilen Doktorun Saatleri :";
            // 
            // MuayeneGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 336);
            this.ControlBox = false;
            this.Controls.Add(this._DoktorunSaatleri);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ComboBox _DoktorunSaatleri;
        private System.Windows.Forms.Label label1;
    }
}