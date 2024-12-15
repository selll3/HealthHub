namespace HealthHub
{
    partial class Tahlillerim
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
            this._Tahliller = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._Tahliller)).BeginInit();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Vazgec.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.Vazgec.Location = new System.Drawing.Point(12, 255);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 27);
            this.Vazgec.TabIndex = 8;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = false;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // _Tahliller
            // 
            this._Tahliller.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._Tahliller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._Tahliller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Tahliller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this._Tahliller.Location = new System.Drawing.Point(12, 103);
            this._Tahliller.Name = "_Tahliller";
            this._Tahliller.ReadOnly = true;
            this._Tahliller.RowHeadersVisible = false;
            this._Tahliller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._Tahliller.Size = new System.Drawing.Size(346, 129);
            this._Tahliller.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Tahlillerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 306);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._Tahliller);
            this.Controls.Add(this.Vazgec);
            this.Name = "Tahlillerim";
            this.Text = "Tahlillerim";
            this.Load += new System.EventHandler(this.Tahlillerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Tahliller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.DataGridView _Tahliller;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}