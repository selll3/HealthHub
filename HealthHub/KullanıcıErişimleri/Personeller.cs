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

namespace HealthHub.KullanıcıErişimleri
{
    public partial class Personeller : Form
    {
        int currentUserId;
        public Personeller(int userId)
        {
            currentUserId = userId;
            LoadDataIntoGridp();
            InitializeComponent();
           
        }

        public void LoadDataIntoGridp()
        {
            try
            {
                // Model üzerinden personelleri getir
                var personeller = Database.Model.Personeller.PersoneliGetir();

                if (personeller != null && personeller.Count > 0)
                {
                    _Personel.DataSource = personeller;

                    // Kolon başlıklarını ayarla (isteğe bağlı)
                    _Personel.Columns["PERSONELID"].HeaderText = "Personel ID";
                    _Personel.Columns["Ad"].HeaderText = "Ad";
                    _Personel.Columns["Soyad"].HeaderText = "Soyad";
                    _Personel.Columns["PersonelGörevi"].HeaderText = "Görev";
                }
                else
                {
                    MessageBox.Show("Hiç personel bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Personel verileri yüklenirken hata oluştu: {ex.Message}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void verileriyükle()
        {


            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
            _Personel.DataSource = Database.Model.Personeller.PersoneliGetir();
            //_Personeller_dataGridView.DataSource = Database.Model.Personeller.dp.PERSONEL
            //   .Select(r => new
            //   {
            //       r.PERSONELID,  // İstediğin sütunları buraya ekleyebilirsin
            //       r.PersonelAdi,
            //       r.PersonelSoyadi,
            //       r.PersonelGorev
            //       //r.KULLANICIID

            //       // r.Bulgu gibi başka sütunlar da ekleyebilirsin
            //   }).ToList();


        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            _Personel.RowHeadersVisible = false;
            
        }

        private void _VAZGEC_Click(object sender, EventArgs e)
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
    }
}
