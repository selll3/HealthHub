namespace HealthHub
{
    partial class Muayenelerim
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
            this.Muayeneler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Muayeneler)).BeginInit();
            this.SuspendLayout();
            // 
            // Vazgec
            // 
            this.Vazgec.Location = new System.Drawing.Point(12, 273);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(78, 22);
            this.Vazgec.TabIndex = 8;
            this.Vazgec.Text = "VAZGEÇ";
            this.Vazgec.UseVisualStyleBackColor = true;
            // 
            // Muayeneler
            // 
            this.Muayeneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Muayeneler.Location = new System.Drawing.Point(12, 12);
            this.Muayeneler.Name = "Muayeneler";
            this.Muayeneler.Size = new System.Drawing.Size(364, 232);
            this.Muayeneler.TabIndex = 9;
            // 
            // Muayenelerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 318);
            this.ControlBox = false;
            this.Controls.Add(this.Muayeneler);
            this.Controls.Add(this.Vazgec);
            this.Name = "Muayenelerim";
            this.Text = "Muayenelerim";
            ((System.ComponentModel.ISupportInitialize)(this.Muayeneler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vazgec;
        private System.Windows.Forms.DataGridView Muayeneler;
    }
}