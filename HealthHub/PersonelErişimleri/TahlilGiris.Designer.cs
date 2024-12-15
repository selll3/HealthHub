namespace HealthHub.PersonelErişimleri
{
    partial class TahlilGiris
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kaydet = new System.Windows.Forms.Button();
            this.tahililismicombo = new System.Windows.Forms.ComboBox();
            this.parametreadicombo = new System.Windows.Forms.ComboBox();
            this.degercombo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EKLE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 22);
            this.button1.TabIndex = 16;
            this.button1.Text = "VAZGEÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Hasta Bilgisi :";
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(419, 324);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(78, 22);
            this.Kaydet.TabIndex = 34;
            this.Kaydet.Text = "KAYDET";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // tahililismicombo
            // 
            this.tahililismicombo.FormattingEnabled = true;
            this.tahililismicombo.Items.AddRange(new object[] {
            "Kan Tahlili"});
            this.tahililismicombo.Location = new System.Drawing.Point(77, 75);
            this.tahililismicombo.Name = "tahililismicombo";
            this.tahililismicombo.Size = new System.Drawing.Size(91, 21);
            this.tahililismicombo.TabIndex = 35;
            // 
            // parametreadicombo
            // 
            this.parametreadicombo.FormattingEnabled = true;
            this.parametreadicombo.Items.AddRange(new object[] {
            "Hemoglobin (Hb)",
            "WBC",
            "PLT",
            "Hct",
            "Kolesterol"});
            this.parametreadicombo.Location = new System.Drawing.Point(77, 138);
            this.parametreadicombo.Name = "parametreadicombo";
            this.parametreadicombo.Size = new System.Drawing.Size(91, 21);
            this.parametreadicombo.TabIndex = 36;
            // 
            // degercombo
            // 
            this.degercombo.Location = new System.Drawing.Point(77, 200);
            this.degercombo.Name = "degercombo";
            this.degercombo.Size = new System.Drawing.Size(91, 20);
            this.degercombo.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tahlil İsmi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Parametre Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Değer :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 205);
            this.dataGridView1.TabIndex = 41;
            // 
            // EKLE
            // 
            this.EKLE.Location = new System.Drawing.Point(77, 255);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(75, 23);
            this.EKLE.TabIndex = 42;
            this.EKLE.Text = "EKLE";
            this.EKLE.UseVisualStyleBackColor = true;
            this.EKLE.Click += new System.EventHandler(this.EKLE_Click);
            // 
            // TahlilGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 358);
            this.ControlBox = false;
            this.Controls.Add(this.EKLE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degercombo);
            this.Controls.Add(this.parametreadicombo);
            this.Controls.Add(this.tahililismicombo);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "TahlilGiris";
            this.Text = "TahlilGiris";
            this.Load += new System.EventHandler(this.TahlilGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.ComboBox tahililismicombo;
        private System.Windows.Forms.ComboBox parametreadicombo;
        private System.Windows.Forms.TextBox degercombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EKLE;
    }
}