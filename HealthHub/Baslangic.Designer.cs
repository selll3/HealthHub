﻿namespace HealthHub
{
    partial class Baslangic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baslangic));
            this.PersonelGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonelGiris
            // 
            this.PersonelGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.PersonelGiris.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.PersonelGiris.Location = new System.Drawing.Point(141, 207);
            this.PersonelGiris.Name = "PersonelGiris";
            this.PersonelGiris.Size = new System.Drawing.Size(191, 33);
            this.PersonelGiris.TabIndex = 1;
            this.PersonelGiris.Text = "PERSONEL GİRİŞ";
            this.PersonelGiris.UseVisualStyleBackColor = false;
            this.PersonelGiris.Click += new System.EventHandler(this.PersonelGiris_Click);
            // 
            // Baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 338);
            this.Controls.Add(this.PersonelGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Baslangic";
            this.Text = "Baslangic";
            this.Load += new System.EventHandler(this.Baslangic_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PersonelGiris;
    }
}