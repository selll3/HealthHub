using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthHub.Database.Model;

namespace HealthHub.PersonelErişimleri
{
    public partial class Doktorlar : Form
    {
      
        public Doktorlar()
        {
            InitializeComponent();
            
        }

        private void Vazgec_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }

            // Formu kapat
            this.Close();
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {// Hem otomatik genişleme hem de kullanıcıya manuel genişletme izni:
           
            

            try
            {
                // AutoGenerateColumns özelliğini kapat
                Doktor.ScrollBars = ScrollBars.Both;
                Doktor.AutoGenerateColumns = false;
                Doktor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                Doktor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Form boyutlandırılabilir olsun
                this.FormBorderStyle = FormBorderStyle.Sizable;
                // Sütunları manuel olarak tanımla
                Doktor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "DoktorAdSoyad",
                    HeaderText = "Doktor Adı Soyadı",
                    DataPropertyName = "DoktorAdSoyad"
                });

                Doktor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Saatler",
                    HeaderText = "Saatler",
                    DataPropertyName = "Saatler"
                });

                // Doktorlar ve saatleri yükle
                var doktorlarSaatler = HealthHub.Database.Model.Doktorlar.GetDoktorlarVeSaatleri();
                Doktor.DataSource = doktorlarSaatler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {

            string filtre = txtFiltre.Text.ToLower();

            // Doktorlar ve saatleri filtrele
            var doktorlarSaatler = HealthHub.Database.Model.Doktorlar.GetDoktorlarVeSaatleri();
            var filtreliSonuc = doktorlarSaatler
                .Where(d => d.DoktorAdSoyad.ToLower().Contains(filtre))
                .ToList();

           Doktor.DataSource = filtreliSonuc;


        }

        private void Doktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
