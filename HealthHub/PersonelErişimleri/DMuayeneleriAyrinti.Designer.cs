namespace HealthHub.PersonelErişimleri
{
    partial class DMuayeneleriAyrinti
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this._ad = new System.Windows.Forms.TextBox();
            this._soyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(12, 12);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(163, 20);
            this.textBoxTC.TabIndex = 1;
            // 
            // _ad
            // 
            this._ad.Location = new System.Drawing.Point(12, 48);
            this._ad.Name = "_ad";
            this._ad.Size = new System.Drawing.Size(163, 20);
            this._ad.TabIndex = 2;
            // 
            // _soyad
            // 
            this._soyad.Location = new System.Drawing.Point(12, 88);
            this._soyad.Name = "_soyad";
            this._soyad.Size = new System.Drawing.Size(163, 20);
            this._soyad.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "VAZGEÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DMuayeneleriAyrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._soyad);
            this.Controls.Add(this._ad);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DMuayeneleriAyrinti";
            this.Text = "DMuayeneleriAyrinti";
            this.Load += new System.EventHandler(this.DMuayeneleriAyrinti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.TextBox _ad;
        private System.Windows.Forms.TextBox _soyad;
        private System.Windows.Forms.Button button1;
    }
}