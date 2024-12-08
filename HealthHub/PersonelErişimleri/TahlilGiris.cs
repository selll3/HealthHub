using HealthHub.Database.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthHub.PersonelErişimleri
{
    public partial class TahlilGiris : Form
    {
        public TahlilGiris()
        {
            InitializeComponent();
        }

        private void TahlilGiris_Load(object sender, EventArgs e)
        {
            FillComboSearchHasta();
            InitializeDataGridView();
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

        private void button1_Click(object sender, EventArgs e)
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

        private void EKLE_Click(object sender, EventArgs e)
        {
            string parametreAdi = parametreadicombo.SelectedItem?.ToString();
            string deger = degercombo.Text;

            if (!string.IsNullOrWhiteSpace(parametreAdi) && !string.IsNullOrWhiteSpace(deger))
            {
                // DataGridView'e ekle
                dataGridView1.Rows.Add(parametreAdi, deger);

                // Alanları temizle
                parametreadicombo.SelectedIndex = -1;
                degercombo.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("ParametreAdi", "Parametre Adı");
            dataGridView1.Columns.Add("Deger", "Değer");
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            // Seçilen hasta ve tahlil bilgilerini alın
            int hastaID = (int)comboBox1.SelectedValue;
            string tahlilTuru = tahililismicombo.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tahlilTuru))
            {
                MessageBox.Show("Lütfen bir tahlil türü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yeni tahlil oluştur
            var yeniTahlil = new TAHLIL
            {
                HASTAID = hastaID,
                TahlilIsmi = tahlilTuru
            };

            // Tahlil parametrelerini oluştur
            var tahlilDegerleri = new List<TAHLILDEGERLERI>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ParametreAdi"].Value != null && row.Cells["Deger"].Value != null)
                {
                    tahlilDegerleri.Add(new TAHLILDEGERLERI
                    {
                        ParametreAdi = row.Cells["ParametreAdi"].Value.ToString(),
                        Deger = Convert.ToDecimal(row.Cells["Deger"].Value)


                    });
                }
            }
            

            // Veritabanına kaydet
            bool sonuc = HealthHub.Database.Model.Tahliller.TahlilEkle(yeniTahlil, tahlilDegerleri);

            if (sonuc)
            {
                MessageBox.Show("Tahlil başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                tahililismicombo.SelectedIndex = -1;
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Tahlil kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
