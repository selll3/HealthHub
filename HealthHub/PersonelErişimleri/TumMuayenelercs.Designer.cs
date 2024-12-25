namespace HealthHub.PersonelErişimleri
{
    partial class TumMuayenelercs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vazgec = new System.Windows.Forms.Button();
            this.GUNCELLE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EKLE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(433, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vazgec
            // 
            this.vazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.vazgec.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vazgec.Location = new System.Drawing.Point(12, 294);
            this.vazgec.Name = "vazgec";
            this.vazgec.Size = new System.Drawing.Size(75, 34);
            this.vazgec.TabIndex = 1;
            this.vazgec.Text = "VAZGEÇ";
            this.vazgec.UseVisualStyleBackColor = false;
            this.vazgec.Click += new System.EventHandler(this.vazgec_Click);
            // 
            // GUNCELLE
            // 
            this.GUNCELLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GUNCELLE.Enabled = false;
            this.GUNCELLE.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GUNCELLE.Location = new System.Drawing.Point(124, 294);
            this.GUNCELLE.Name = "GUNCELLE";
            this.GUNCELLE.Size = new System.Drawing.Size(89, 34);
            this.GUNCELLE.TabIndex = 2;
            this.GUNCELLE.Text = "GÜNCELLE";
            this.GUNCELLE.UseVisualStyleBackColor = false;
            this.GUNCELLE.Click += new System.EventHandler(this.GUNCELLE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(255, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EKLE
            // 
            this.EKLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EKLE.Enabled = false;
            this.EKLE.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EKLE.Location = new System.Drawing.Point(370, 294);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(75, 34);
            this.EKLE.TabIndex = 4;
            this.EKLE.Text = "EKLE";
            this.EKLE.UseVisualStyleBackColor = false;
            this.EKLE.Click += new System.EventHandler(this.EKLE_Click);
            // 
            // TumMuayenelercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 396);
            this.ControlBox = false;
            this.Controls.Add(this.EKLE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GUNCELLE);
            this.Controls.Add(this.vazgec);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TumMuayenelercs";
            this.Text = "TumMuayenelercs";
            this.Load += new System.EventHandler(this.TumMuayenelercs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button vazgec;
        private System.Windows.Forms.Button GUNCELLE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EKLE;
    }
}