using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using HealthHub.Database.Entity;
using HealthHub.Database.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthHub.PersonelErişimleri
{
    public partial class MuayeneGuncelle : Form
    {
        private int muayeneID; // Güncellenecek muayenenin ID'si
        private MUAYENELER muayene; // Güncellenen muayene nesnesi

        public MuayeneGuncelle(int muayeneID)
        {
            InitializeComponent();
            this.muayeneID = muayeneID;
        }

        private void MuayeneGuncelle_Load(object sender, EventArgs e)
        {
            // Tarih kontrolü için minDate ayarlanıyor
            dateTimePicker1.MinDate = DateTime.Now.Date;

            // Olayları bağla
            comboBoxDoktor.SelectedIndexChanged += comboBoxDoktor_SelectedIndexChanged;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;

            // Muayene bilgilerini al
            using (var context = new HealthHubDb())
            {
                muayene = context.MUAYENELER.FirstOrDefault(m => m.MUAYENEID == muayeneID);
            }

            if (muayene != null)
            {
                // Doktorları doldur
                FillComboDoktor();
                comboBoxDoktor.SelectedValue = muayene.DOKTORID;

                // Hastaları doldur
                FillComboHasta();
                comboBoxHasta.SelectedValue = muayene.HASTAID;

                // Tarih ve saat bilgilerini doldur
                dateTimePicker1.Value = muayene.TarihSaat ?? DateTime.Now;
                FillComboDoktorSaatleri(muayene.DOKTORID ?? 0, dateTimePicker1.Value.Date);

                // Mevcut saat ComboBox'ta varsa seçili hale getir
                _DoktorunSaatleri.SelectedItem = muayene.TarihSaat?.ToString("HH:mm");
            }
        }

        private void FillComboDoktor()
        {
            using (var context = new HealthHubDb())
            {
                var doktorlar = context.DOKTORLAR
                    .Select(d => new
                    {
                        d.DOKTORID,
                        ADSOYAD = d.Ad + " " + d.Soyad
                    })
                    .ToList();

                comboBoxDoktor.DataSource = doktorlar;
                comboBoxDoktor.DisplayMember = "ADSOYAD";
                comboBoxDoktor.ValueMember = "DOKTORID";
            }
        }

        private void FillComboHasta()
        {
            using (var context = new HealthHubDb())
            {
                var hastalar = context.HASTALAR
                    .Select(h => new
                    {
                        h.HASTAID,
                        ADSOYAD = h.Ad + " " + h.Soyad
                    })
                    .ToList();

                comboBoxHasta.DataSource = hastalar;
                comboBoxHasta.DisplayMember = "ADSOYAD";
                comboBoxHasta.ValueMember = "HASTAID";
            }
        }

        private void FillComboDoktorSaatleri(int doktorID, DateTime tarih)
        {
            using (var context = new HealthHubDb())
            {
                var doktorSaatleri = context.DOKTOR_SAATLERI
                    .Where(ds => ds.DOKTORID == doktorID && ds.TARIH == tarih && ds.AKTIF == true)
                    .Select(ds => ds.SAAT)
                    .ToList();

                if (doktorSaatleri.Any())
                {
                    _DoktorunSaatleri.DataSource = doktorSaatleri;
                }
                else
                {
                    _DoktorunSaatleri.DataSource = null;
                    MessageBox.Show("Seçilen tarihte bu doktorun aktif saatleri bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDoktorSaatleri();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateDoktorSaatleri();
        }

        private void UpdateDoktorSaatleri()
        {
            if (comboBoxDoktor.SelectedValue != null && int.TryParse(comboBoxDoktor.SelectedValue.ToString(), out int selectedDoktorID))
            {
                DateTime selectedDate = dateTimePicker1.Value.Date;
                FillComboDoktorSaatleri(selectedDoktorID, selectedDate);
            }
            else
            {
                _DoktorunSaatleri.DataSource = null;
            }
        }

        private void KAYDET_Click(object sender, EventArgs e)
        {
            if (muayene != null)
            {
                try
                {
                    // Tarih kontrolü
                    if (dateTimePicker1.Value.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("Geçmiş bir tarih seçemezsiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (comboBoxDoktor.SelectedValue is int doktorID &&
                        comboBoxHasta.SelectedValue is int hastaID)
                    {
                        DateTime selectedDate = dateTimePicker1.Value.Date;
                        string selectedSaat = dateTimePicker1.Value.ToString("HH:mm");

                        // Saatin ComboBox'ta mevcut olup olmadığını kontrol et
                        if (_DoktorunSaatleri.Items.Cast<string>().All(s => s != selectedSaat))
                        {
                            MessageBox.Show("Seçilen saat, doktorun aktif saatleri arasında değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        DateTime selectedTarihSaat = DateTime.Parse($"{selectedDate:yyyy-MM-dd} {selectedSaat}");

                        using (var context = new HealthHubDb())
                        {
                            var mevcutMuayene = context.MUAYENELER
                                .FirstOrDefault(m => m.DOKTORID == doktorID && m.TarihSaat == selectedTarihSaat && m.MUAYENEID != muayeneID);

                            if (mevcutMuayene != null)
                            {
                                MessageBox.Show("Seçilen saatte doktorun başka bir muayenesi zaten bulunuyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            muayene.DOKTORID = doktorID;
                            muayene.HASTAID = hastaID;
                            muayene.TarihSaat = selectedTarihSaat;

                            context.MUAYENELER.AddOrUpdate(muayene);
                            context.SaveChanges();

                            MessageBox.Show("Muayene bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen tüm seçimleri doğru bir şekilde yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}