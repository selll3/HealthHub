namespace HealthHub.KullanıcıErişimleri
{
    partial class TumKullanicilar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Vazgec = new System.Windows.Forms.Button();
            this.TumKullancilar = new System.Windows.Forms.DataGridView();
            this.yetkilerigor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TumKullancilar)).BeginInit();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Vazgec.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.Vazgec.Location = new System.Drawing.Point(12, 246);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 31);
            this.Vazgec.TabIndex = 10;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = false;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // TumKullancilar
            // 
            this.TumKullancilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TumKullancilar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TumKullancilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TumKullancilar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.TumKullancilar.Location = new System.Drawing.Point(12, 12);
            this.TumKullancilar.Name = "TumKullancilar";
            this.TumKullancilar.ReadOnly = true;
            this.TumKullancilar.RowHeadersVisible = false;
            this.TumKullancilar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TumKullancilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TumKullancilar.Size = new System.Drawing.Size(292, 213);
            this.TumKullancilar.TabIndex = 11;
            // 
            // yetkilerigor
            // 
            this.yetkilerigor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.yetkilerigor.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.yetkilerigor.Location = new System.Drawing.Point(194, 246);
            this.yetkilerigor.Name = "yetkilerigor";
            this.yetkilerigor.Size = new System.Drawing.Size(110, 31);
            this.yetkilerigor.TabIndex = 12;
            this.yetkilerigor.Text = "YETKİLERİ GÖR";
            this.yetkilerigor.UseVisualStyleBackColor = false;
            this.yetkilerigor.Click += new System.EventHandler(this.yetkilerigor_Click);
            // 
            // TumKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 288);
            this.ControlBox = false;
            this.Controls.Add(this.yetkilerigor);
            this.Controls.Add(this.TumKullancilar);
            this.Controls.Add(this.Vazgec);
            this.Name = "TumKullanicilar";
            this.Text = "TümKullanicilar";
            this.Load += new System.EventHandler(this.TumKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TumKullancilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.DataGridView TumKullancilar;
        private System.Windows.Forms.Button yetkilerigor;
    }
}