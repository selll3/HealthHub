using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HealthHub.PersonelErişimleri
{
    public partial class DoktorMuayeneleri : Form
    {
        public static int kullaniciId;

        public DoktorMuayeneleri(int Kid)
        {
            kullaniciId = Kid;
            InitializeComponent();

            // DataGridView olayları
            DoktorMuayene.CellDoubleClick += DoktorMuayene_CellDoubleClick;

            // TextBox olayları
            TxtSearch.TextChanged += TxtSearch_TextChanged;

            DoktorMuayeneleriniListele();
        }

        private void DoktorMuayeneleri_Load(object sender, EventArgs e)
        {
            DoktorMuayene.RowHeadersVisible = false;
            DoktorMuayene.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DoktorMuayene.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Form boyutlandırılabilir olsun
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Giriş yapan kullanıcının KULLANICIID'sini al
            int kullaniciID = kullaniciId;

            // PERSONELID'yi bul
            int personelID = GetPersonelIDByKullaniciID(kullaniciID);

            // DOKTORID'yi bul
            int doktorID = GetDoctorIDByPersonelID(personelID);

            // Doktorun gelecekteki muayenelerini yükle
            LoadUpcomingAppointments(doktorID);
        }

        private void LoadUpcomingAppointments(int doktorID)
        {
            var muayeneler = GetGelecekMuayeneler(doktorID);
            DoktorMuayene.DataSource = muayeneler.Select(m => new
            {
                m.MUAYENEID,
                HASTAID = m.HASTAID, // Gizli sütun
                HastaAdSoyad = $"{m.HASTALAR.Ad} {m.HASTALAR.Soyad}", // Ad Soyad sütunu
                DoktorAdSoyad = $"{m.DOKTORLAR.Ad} {m.DOKTORLAR.Soyad}",
                TarihSaat = m.TarihSaat
            }).ToList();

            // HASTAID sütununu gizle
            DoktorMuayene.Columns["HASTAID"].Visible = false;
        }

        private List<Database.Entity.MUAYENELER> GetGelecekMuayeneler(int doktorID)
        {
            return Database.Model.Muayeneler.dbm.MUAYENELER
                .Where(m => m.DOKTORID == doktorID && m.TarihSaat >= DateTime.Now)
                .ToList();
        }

        private void DoktorMuayeneleriniListele()
        {
            try
            {
                int personelID = GetPersonelIDByKullaniciID(kullaniciId);

                if (personelID > 0)
                {
                    int doktorID = GetDoctorIDByPersonelID(personelID);

                    if (doktorID > 0)
                    {
                        var muayeneler = Database.Model.Muayeneler.GetMuayenelerByDoktorID(doktorID);

                        if (muayeneler != null && muayeneler.Any())
                        {
                            DoktorMuayene.DataSource = muayeneler.Select(m => new
                            {
                                MuayeneID = m.MUAYENEID,
                                HastaAdSoyad = $"{m.HASTALAR.Ad} {m.HASTALAR.Soyad}",
                                DoktorAdSoyad = $"{m.DOKTORLAR.Ad} {m.DOKTORLAR.Soyad}",
                                TarihSaat = m.TarihSaat
                            }).ToList();
                        }
                        else
                        {
                            MessageBox.Show("Doktora ait muayene bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giriş yapan kullanıcı bir doktor değil.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Personel ID alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = TxtSearch.Text.ToLower();

            // Filtreleme işlemi
            var filteredMuayeneler = Database.Model.Muayeneler.GetMuayenelerByDoktorID(GetDoctorIDByPersonelID(GetPersonelIDByKullaniciID(kullaniciId)))
                .Where(m =>
                    $"{m.HASTALAR.Ad} {m.HASTALAR.Soyad}".ToLower().Contains(searchTerm) ||
                    m.MUAYENEID.ToString().Contains(searchTerm) ||
                    m.TarihSaat.HasValue && m.TarihSaat.Value.ToString("yyyy-MM-dd").Contains(searchTerm)
                )
                .Select(m => new
                {
                    MuayeneID = m.MUAYENEID,
                    HastaAdSoyad = $"{m.HASTALAR.Ad} {m.HASTALAR.Soyad}",
                    DoktorAdSoyad = $"{m.DOKTORLAR.Ad} {m.DOKTORLAR.Soyad}",
                    TarihSaat = m.TarihSaat
                })
                .ToList();

            DoktorMuayene.DataSource = filteredMuayeneler;
        }

        private int GetPersonelIDByKullaniciID(int kullaniciID)
        {
            return Database.Model.Personeller.dp.PERSONELLER
                .Where(p => p.KULLANICIID == kullaniciID)
                .Select(p => p.PERSONELID)
                .FirstOrDefault();
        }

        private int GetDoctorIDByPersonelID(int personelID)
        {
            string personelGorev = Database.Model.Personeller.dp.PERSONELLER
                .Where(p => p.PERSONELID == personelID)
                .Select(p => p.PersonelGörevi)
                .FirstOrDefault();

            if (personelGorev == "DOKTOR")
            {
                return Database.Model.Doktorlar.dbd.DOKTORLAR
                    .Where(d => d.PERSONELID == personelID)
                    .Select(d => d.DOKTORID)
                    .FirstOrDefault();
            }
            return 0;
        }

        private void DoktorMuayene_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // HASTAID sütunundan veriyi al
                int hastaID = Convert.ToInt32(DoktorMuayene.Rows[e.RowIndex].Cells["HASTAID"].Value);

                // Hasta detay formunu aç
                DMuayeneleriAyrinti hastaForm = new DMuayeneleriAyrinti(hastaID);
                hastaForm.ShowDialog();
            }
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


        private void DoktorMuayene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // İçerik tıklama işlemleri buraya eklenebilir
        }
    }
}




