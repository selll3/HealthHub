namespace HealthHub.PersonelErişimleri
{
    partial class DoktorMuayeneleri
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
            this.Vazgec = new System.Windows.Forms.Button();
            this.DoktorMuayene = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DoktorMuayene)).BeginInit();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(12, 332);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 9;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            // 
            // DoktorMuayene
            // 
            this.DoktorMuayene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoktorMuayene.Location = new System.Drawing.Point(12, 12);
            this.DoktorMuayene.Name = "DoktorMuayene";
            this.DoktorMuayene.Size = new System.Drawing.Size(304, 286);
            this.DoktorMuayene.TabIndex = 10;
            // 
            // DoktorMuayeneleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 378);
            this.ControlBox = false;
            this.Controls.Add(this.DoktorMuayene);
            this.Controls.Add(this.Vazgec);
            this.Name = "DoktorMuayeneleri";
            this.Text = "DoktorMuayeneleri";
            this.Load += new System.EventHandler(this.DoktorMuayeneleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoktorMuayene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.DataGridView DoktorMuayene;
    }
}