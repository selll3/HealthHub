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
using HealthHub.Database.Entity;

namespace HealthHub
{
    public partial class MuayeneEkle : Form
    {
        public MuayeneEkle()
        {
            InitializeComponent();
        }

        private void MuayeneEkle_Load(object sender, EventArgs e)
        {
            FillComboSearchHasta();
            FillComboSearcDoktor();
        }
        private void FillComboSearchHasta()
        {


            var hastalar = Database.Model.Hastalar.dbh.HASTALAR
                .Select(h => new
                {
                    h.HASTAID,
                    ADSOYAD = h.Ad + " " + h.Soyad
                })
                .ToList();
            comboBox1.DataSource = hastalar;
            comboBox1.ValueMember = "HASTAID";
            comboBox1.DisplayMember = "ADSOYAD";



        }
        private void FillComboSearcDoktor()
        {


            var doktorlars = Database.Model.Doktorlar.dbd.DOKTORLAR
                .Select(h => new
                {
                    h.DOKTORID,
                    ADSOYAD = h.Ad + " " + h.Soyad
                })
                .ToList();
            Doktor.DataSource = doktorlars;
            Doktor.ValueMember = "DOKTORID";
            Doktor.DisplayMember = "ADSOYAD";



        }
        private void Vazgec_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1; // ComboBox seçimini temizle
                }
                else if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty; // TextBox içeriğini temizle
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now; // DateTimePicker'ı sıfırla
                }
            }

            this.Close(); // Formu kapat
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoktorBransi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MuayeneOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                // ComboBox'lardan seçilen hasta ve doktor ID'lerini al
                int hastaID = Convert.ToInt32(comboBox1.SelectedValue);
                int doktorID = Convert.ToInt32(Doktor.SelectedValue);

                // DateTimePicker'dan seçilen tarihi al
                DateTime tarihSaat = dateTimePicker1.Value;

                // Aynı doktor ve aynı saatte bir muayene var mı kontrol et
                var mevcutMuayene = Database.Model.Muayeneler.dbm.MUAYENELER
                    .FirstOrDefault(m => m.DOKTORID == doktorID && m.TarihSaat == tarihSaat);

                if (mevcutMuayene != null)
                {
                    // Eğer aynı doktor ve aynı saatte bir muayene varsa, eklemeyi engelle
                    MessageBox.Show("Bu muayene daha önce zaten oluşturulmuş");
                    return;
                }

                // Yeni muayene nesnesi oluştur
                MUAYENELER yeniMuayene = new MUAYENELER
                {
                    HASTAID = hastaID,
                    DOKTORID = doktorID,
                    TarihSaat = tarihSaat
                };

                // Veritabanına kaydet
                bool result = Muayeneler.MuayeneEkle(yeniMuayene);

                if (result)
                {
                    MessageBox.Show("Muayene başarıyla oluşturuldu!");
                }
                else
                {
                    MessageBox.Show("Muayene oluşturulurken bir hata oluştu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
