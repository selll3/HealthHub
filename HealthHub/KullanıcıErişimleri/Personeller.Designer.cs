namespace HealthHub.KullanıcıErişimleri
{
    partial class Personeller
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
            this._Personel = new System.Windows.Forms.DataGridView();
            this._VAZGEC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Personel)).BeginInit();
            this.SuspendLayout();
            // 
            // _Personel
            // 
            this._Personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Personel.Location = new System.Drawing.Point(12, 12);
            this._Personel.Name = "_Personel";
            this._Personel.Size = new System.Drawing.Size(454, 251);
            this._Personel.TabIndex = 0;
            // 
            // _VAZGEC
            // 
            this._VAZGEC.Location = new System.Drawing.Point(12, 301);
            this._VAZGEC.Name = "_VAZGEC";
            this._VAZGEC.Size = new System.Drawing.Size(75, 23);
            this._VAZGEC.TabIndex = 1;
            this._VAZGEC.Text = "VAZGEÇ";
            this._VAZGEC.UseVisualStyleBackColor = true;
            this._VAZGEC.Click += new System.EventHandler(this._VAZGEC_Click);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 345);
            this.ControlBox = false;
            this.Controls.Add(this._VAZGEC);
            this.Controls.Add(this._Personel);
            this.Name = "Personeller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Personel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _Personel;
        private System.Windows.Forms.Button _VAZGEC;
    }
}