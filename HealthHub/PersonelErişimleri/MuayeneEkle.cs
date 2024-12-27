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
using System.Windows.Forms.VisualStyles;

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

        

        private void MuayeneOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                // ComboBox'lardan seçilen hasta ve doktor ID'lerini al
                if (comboBox1.SelectedValue is int hastaID &&
                    Doktor.SelectedValue is int doktorID &&
                    _DoktorunSaatleri.SelectedItem is string selectedSaat)
                {
                    // Seçilen tarih ve saat
                    DateTime selectedDate = dateTimePicker1.Value.Date;
                    DateTime selectedDateTime = dateTimePicker1.Value;

                    // 'formattedSaat' variable is declared here to make it accessible throughout the method
                    string formattedSaat = selectedDateTime.ToString("HH:mm"); // Get time in "HH:mm" format

                    // Geçerli tarihten önceki bir tarih seçildi mi kontrol et
                    if (selectedDate < DateTime.Now.Date)
                    {
                        MessageBox.Show("Geçmiş bir tarih seçilemez. Lütfen gelecekte bir tarih seçin.");
                        return;
                    }

                    using (var context = new HealthHubDb())
                    {
                        // Seçilen saat doktorun çalışma saatleri içinde mi kontrol et
                        var doktorSaatleri = context.DOKTOR_SAATLERI
                            .Where(ds => ds.DOKTORID == doktorID && ds.TARIH == selectedDate && ds.AKTIF == true)
                            .Select(ds => ds.SAAT)
                            .ToList();

                        if (!doktorSaatleri.Contains(formattedSaat))
                        {
                            MessageBox.Show("Seçilen saat doktorun çalışma saatleri içinde değil!");
                            return;
                        }

                        // Seçilen saatte doktorun başka bir muayenesi var mı kontrol et
                        DateTime selectedTarihSaat = DateTime.Parse($"{selectedDate:yyyy-MM-dd} {formattedSaat}");
                        var mevcutMuayene = context.MUAYENELER
                            .FirstOrDefault(m => m.DOKTORID == doktorID && m.TarihSaat == selectedTarihSaat);

                        if (mevcutMuayene != null)
                        {
                            MessageBox.Show("Seçilen saatte doktorun başka bir muayenesi zaten bulunuyor!");
                            return;
                        }
                    }

                    // Yeni muayene oluşturma kodu
                    MUAYENELER yeniMuayene = new MUAYENELER
                    {
                        HASTAID = hastaID,
                        DOKTORID = doktorID,
                        TarihSaat = DateTime.Parse($"{selectedDate:yyyy-MM-dd} {formattedSaat}")
                    };

                    // Veritabanına kaydet
                    using (var context = new HealthHubDb())
                    {
                        context.MUAYENELER.Add(yeniMuayene);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Muayene başarıyla oluşturuldu!");
                }
                else
                {
                    MessageBox.Show("Lütfen tüm seçimleri doğru bir şekilde yapın!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
        private void FillComboDoktorSaatleri(int selectedDoktorID, DateTime selectedDate)
        {
            using (var context = new HealthHubDb())
            {
                // Veritabanından saatleri çek
                var doktorSaatleri = context.DOKTOR_SAATLERI
     .Where(ds => ds.DOKTORID == selectedDoktorID && ds.TARIH == selectedDate && ds.AKTIF == true)
     .Select(ds => ds.SAAT)
     .ToList();

                // Saatleri ComboBox'a doldur
                _DoktorunSaatleri.DataSource = doktorSaatleri;
            }
        }


        private void _doktorSaatleri_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Doktor.SelectedValue != null)
            {
                // Seçilen doktor ID'sini al
                if (int.TryParse(Doktor.SelectedValue.ToString(), out int selectedDoktorID))
                {
                    // DateTimePicker'dan seçilen tarihi al
                    DateTime selectedDate = dateTimePicker1.Value.Date;

                    // Doktorun saatlerini doldur
                    FillComboDoktorSaatleri(selectedDoktorID, selectedDate);
                }
                else
                {
                    MessageBox.Show("Seçilen doktor ID'si geçerli bir sayı değil.");
                }
            }
            else
            {
                MessageBox.Show("Bir doktor seçilmedi.");
            }


        }

        private void _DoktorunSaatleri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
