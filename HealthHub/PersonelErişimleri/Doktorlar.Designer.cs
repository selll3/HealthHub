namespace HealthHub.PersonelErişimleri
{
    partial class Doktorlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Vazgec = new System.Windows.Forms.Button();
            this.Doktor = new System.Windows.Forms.DataGridView();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Doktor)).BeginInit();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Vazgec.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.Vazgec.Location = new System.Drawing.Point(12, 362);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 29);
            this.Vazgec.TabIndex = 10;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = false;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // Doktor
            // 
            this.Doktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Doktor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Doktor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Doktor.DefaultCellStyle = dataGridViewCellStyle4;
            this.Doktor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.Doktor.Location = new System.Drawing.Point(12, 60);
            this.Doktor.Name = "Doktor";
            this.Doktor.ReadOnly = true;
            this.Doktor.RowHeadersVisible = false;
            this.Doktor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Doktor.Size = new System.Drawing.Size(379, 277);
            this.Doktor.TabIndex = 11;
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(244, 24);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(147, 20);
            this.txtFiltre.TabIndex = 12;
            this.txtFiltre.TextChanged += new System.EventHandler(this.txtFiltre_TextChanged);
            // 
            // Doktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 430);
            this.ControlBox = false;
            this.Controls.Add(this.txtFiltre);
            this.Controls.Add(this.Doktor);
            this.Controls.Add(this.Vazgec);
            this.Name = "Doktorlar";
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.Doktorlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Doktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.DataGridView Doktor;
        private System.Windows.Forms.TextBox txtFiltre;
    }
}