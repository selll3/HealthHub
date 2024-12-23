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
    public partial class TumPersoneller : Form
    {
        int currentUserId;
        public TumPersoneller(int userId)
        {
            currentUserId = userId;
            
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
                    dataGridView1.DataSource = personeller;

                    // Kolon başlıklarını ayarla (isteğe bağlı)
                    dataGridView1.Columns["PERSONELID"].HeaderText = "Personel ID";
                    dataGridView1.Columns["Ad"].HeaderText = "Ad";
                    dataGridView1.Columns["Soyad"].HeaderText = "Soyad";
                    dataGridView1.Columns["PersonelGörevi"].HeaderText = "Görev";
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
            dataGridView1.DataSource = Database.Model.Personeller.PersoneliGetir();
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
            if (dataGridView1 == null)
            {
                MessageBox.Show("DataGridView başlatılamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadDataIntoGridp();

            dataGridView1.RowHeadersVisible = false;
            
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

        private void _Personel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
