namespace HealthHub
{
    partial class HastaKayit
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Parola = new System.Windows.Forms.Label();
            this.HastaTc = new System.Windows.Forms.Label();
            this.ParolaKayit = new System.Windows.Forms.TextBox();
            this.HastaTcKayit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(154, 212);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Giriş Sayfasına git";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Location = new System.Drawing.Point(9, 164);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(43, 13);
            this.Parola.TabIndex = 10;
            this.Parola.Text = "Parola :";
            // 
            // HastaTc
            // 
            this.HastaTc.AutoSize = true;
            this.HastaTc.Location = new System.Drawing.Point(9, 115);
            this.HastaTc.Name = "HastaTc";
            this.HastaTc.Size = new System.Drawing.Size(58, 13);
            this.HastaTc.TabIndex = 9;
            this.HastaTc.Text = "Hasta TC :";
            // 
            // ParolaKayit
            // 
            this.ParolaKayit.Location = new System.Drawing.Point(92, 157);
            this.ParolaKayit.Name = "ParolaKayit";
            this.ParolaKayit.Size = new System.Drawing.Size(152, 20);
            this.ParolaKayit.TabIndex = 8;
            // 
            // HastaTcKayit
            // 
            this.HastaTcKayit.Location = new System.Drawing.Point(92, 108);
            this.HastaTcKayit.Name = "HastaTcKayit";
            this.HastaTcKayit.Size = new System.Drawing.Size(152, 20);
            this.HastaTcKayit.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "KAYIT OL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hasta Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hasta Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 12;
            // 
            // HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 339);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.HastaTc);
            this.Controls.Add(this.ParolaKayit);
            this.Controls.Add(this.HastaTcKayit);
            this.Controls.Add(this.button1);
            this.Name = "HastaKayit";
            this.Text = "HastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.Label HastaTc;
        private System.Windows.Forms.TextBox ParolaKayit;
        private System.Windows.Forms.TextBox HastaTcKayit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}