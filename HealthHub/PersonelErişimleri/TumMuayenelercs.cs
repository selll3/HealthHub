using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthHub.Database.Model;
using HealthHub.Database.Entity;
namespace HealthHub.PersonelErişimleri
{
    public partial class TumMuayenelercs : Form
    {   HealthHubDb pdb = new HealthHubDb();
        private int currentUserId;
        public TumMuayenelercs(int Userid)
        {
            currentUserId = Userid;
            InitializeComponent();
            yetkileriolustur();
        }

        private void TumMuayenelercs_Load(object sender, EventArgs e)
        {
            
            
                ListeleMuayeneler();

                // DataGridView başlıklarını düzenle
                dataGridView1.Columns["MUAYENEID"].HeaderText = "Muayene ID";
                dataGridView1.Columns["TarihSaat"].HeaderText = "Tarih ve Saat";
                dataGridView1.Columns["DoktorAdSoyad"].HeaderText = "Doktor Adı Soyadı";
                dataGridView1.Columns["HastaAdSoyad"].HeaderText = "Hasta Adı Soyadı";
            

        }
        private void yetkileriolustur()
        {

            var userPermissions = pdb.PERSONELFORMYETKILERI
                                           .Where(p => p.KULLANICIID == currentUserId && p.Yetki == true)
                                           .ToList();


            foreach (var permission in userPermissions)
            {
                switch (permission.FormID)
                {
                    case 3:
                        EKLE.Enabled = true;
                        break;
                    case 4:
                        GUNCELLE.Enabled = true;
                        button1.Enabled = true;
                        break;



                }
            }
        }
        private void ListeleMuayeneler()
        {
            var muayeneler = Muayeneler.GetTumMuayenelerWithDetails();
            dataGridView1.DataSource = muayeneler; // Listeyi DataGridView'e bağla
        }

        //private void AramaYap()
        //{
        //    string aramaTerimi = txtArama.Text.ToLower(); // Kullanıcının arama kriterini al
        //    var muayeneler = Muayeneler.GetTumMuayenelerWithDetails();

        //    // Arama kriterine göre listeyi filtrele
        //    var filtreliMuayeneler = muayeneler.Where(muayene =>
        //        muayene.MuayeneAdi.ToLower().Contains(aramaTerimi) ||
        //        muayene.PacientAd.ToLower().Contains(aramaTerimi) ||
        //        muayene.DoktorAd.ToLower().Contains(aramaTerimi)
        //    ).ToList();

        //    // Filtrelenmiş listeyi DataGridView'e bağla
        //    dataGridView1.DataSource = filtreliMuayeneler;
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int muayeneID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MUAYENEID"].Value);
                var result = Muayeneler.MuayeneSil(muayeneID);
                if (result)
                {
                    MessageBox.Show("Muayene başarıyla silindi!");
                    ListeleMuayeneler(); // Güncel listeyi yükle
                }
                else
                {
                    MessageBox.Show("Muayene silinirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir muayene seçiniz!");
            }
        }

        private void GUNCELLE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int muayeneID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MUAYENEID"].Value);

                // Güncelleme formunu aç
                MuayeneGuncelle guncelleForm = new MuayeneGuncelle(muayeneID);
                if (guncelleForm.ShowDialog() == DialogResult.OK)
                {
                    ListeleMuayeneler(); // Güncel listeyi yükle
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için bir muayene seçiniz!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vazgec_Click(object sender, EventArgs e)
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
            MuayeneEkle me = new MuayeneEkle();
            me.Show();
        }
        public void AramaYap(string aramaTerimi)
        {
            try
            {
                using (var db = new HealthHubDb())
                {
                    // Arama terimini küçük harfe çevir
                    aramaTerimi = aramaTerimi.ToLower();

                    // MUAYENELER tablosundan gerekli verileri çek
                    var filtreliMuayeneler = db.MUAYENELER
                        .Include(m => m.DOKTORLAR)
                        .Include(m => m.HASTALAR)
                        .Where(m =>
                            (m.DOKTORLAR.Ad + " " + m.DOKTORLAR.Soyad).ToLower().Contains(aramaTerimi) || // Doktor adı ve soyadı
                            (m.HASTALAR.Ad + " " + m.HASTALAR.Soyad).ToLower().Contains(aramaTerimi) || // Hasta adı ve soyadı
                            m.TarihSaat.ToString().Contains(aramaTerimi) // Tarih bilgisi
                        )
                        .Select(m => new
                        {
                            m.MUAYENEID,
                            TarihSaat = m.TarihSaat,
                            DoktorAdSoyad = m.DOKTORLAR.Ad + " " + m.DOKTORLAR.Soyad,
                            HastaAdSoyad = m.HASTALAR.Ad + " " + m.HASTALAR.Soyad
                        })
                        .ToList();

                    // Sonuçları DataGridView'e bağla
                    dataGridView1.DataSource = filtreliMuayeneler;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            AramaYap(txtArama.Text);
        }
    }
}
