namespace HealthHub.KullanıcıErişimleri
{
    partial class YetkiControl
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
            this.YetkiKontrol = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YetkiKontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(12, 391);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 10;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // YetkiKontrol
            // 
            this.YetkiKontrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YetkiKontrol.Location = new System.Drawing.Point(12, 12);
            this.YetkiKontrol.Name = "YetkiKontrol";
            this.YetkiKontrol.Size = new System.Drawing.Size(324, 309);
            this.YetkiKontrol.TabIndex = 11;
            this.YetkiKontrol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YetkiKontrol_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YetkiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 443);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YetkiKontrol);
            this.Controls.Add(this.Vazgec);
            this.Name = "YetkiControl";
            this.Text = "YetkiControl";
            this.Load += new System.EventHandler(this.YetkiControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YetkiKontrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.DataGridView YetkiKontrol;
        private System.Windows.Forms.Button button1;
    }
}