namespace HealthHub
{
    partial class HastaAnaMenu
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
            this.HastaMuayeneleri = new System.Windows.Forms.Button();
            this.HastaMuayeneEkle = new System.Windows.Forms.Button();
            this.HastaTahlil = new System.Windows.Forms.Button();
            this.Vazgec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HastaMuayeneleri
            // 
            this.HastaMuayeneleri.Location = new System.Drawing.Point(12, 57);
            this.HastaMuayeneleri.Name = "HastaMuayeneleri";
            this.HastaMuayeneleri.Size = new System.Drawing.Size(157, 26);
            this.HastaMuayeneleri.TabIndex = 0;
            this.HastaMuayeneleri.Text = "Muayenelerim";
            this.HastaMuayeneleri.UseVisualStyleBackColor = true;
            // 
            // HastaMuayeneEkle
            // 
            this.HastaMuayeneEkle.Location = new System.Drawing.Point(12, 117);
            this.HastaMuayeneEkle.Name = "HastaMuayeneEkle";
            this.HastaMuayeneEkle.Size = new System.Drawing.Size(157, 26);
            this.HastaMuayeneEkle.TabIndex = 1;
            this.HastaMuayeneEkle.Text = "Muayene Ekle";
            this.HastaMuayeneEkle.UseVisualStyleBackColor = true;
            // 
            // HastaTahlil
            // 
            this.HastaTahlil.Location = new System.Drawing.Point(12, 181);
            this.HastaTahlil.Name = "HastaTahlil";
            this.HastaTahlil.Size = new System.Drawing.Size(157, 26);
            this.HastaTahlil.TabIndex = 2;
            this.HastaTahlil.Text = "Tahlillerim";
            this.HastaTahlil.UseVisualStyleBackColor = true;
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(127, 287);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(75, 23);
            this.Vazgec.TabIndex = 3;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "VAZGEÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HastaAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 341);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vazgec);
            this.Controls.Add(this.HastaTahlil);
            this.Controls.Add(this.HastaMuayeneEkle);
            this.Controls.Add(this.HastaMuayeneleri);
            this.Name = "HastaAnaMenu";
            this.Text = "HastaAnaMenu";
            this.Load += new System.EventHandler(this.HastaAnaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HastaMuayeneleri;
        private System.Windows.Forms.Button HastaMuayeneEkle;
        private System.Windows.Forms.Button HastaTahlil;
        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.Button button1;
    }
}