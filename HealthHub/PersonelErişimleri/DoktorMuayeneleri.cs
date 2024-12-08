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
    public partial class DoktorMuayeneleri : Form
    {
        public static int kullaniciId;
        public DoktorMuayeneleri(int Kid)
        {
            kullaniciId = Kid;
            InitializeComponent();
            DoktorMuayene.CellDoubleClick += DoktorMuayene_CellDoubleClick;
            DoktorMuayeneleriniListele();
        }

        private void DoktorMuayeneleri_Load(object sender, EventArgs e)
        {
            DoktorMuayene.RowHeadersVisible = false;

            // Giriş yapan kullanıcının KULLANICIID'sini al
            int kullaniciID = kullaniciId;

            // PERSONELID'yi bul
            int personelID = GetPersonelIDByKullaniciID(kullaniciID);

            // DOKTORID'yi bul
            int doktorID = GetDoctorIDByPersonelID(personelID);

            // Doktorun gelecekteki muayenelerini yükle
            //GetGelecekMuayeneler(doktorID);
            LoadUpcomingAppointments(doktorID);

        }
        private void DoktorMuayeneleriniListele()
        {


            var personelID = Database.Model.Personeller.dp.PERSONELLER
                .Where(p => p.KULLANICIID == kullaniciId)
                .Select(p => p.PERSONELID)
                .FirstOrDefault();

            if (personelID > 0)
            {
                var doktorID = Database.Model.Doktorlar.dbd.DOKTORLAR
                    .Where(d => d.PERSONELID == personelID)
                    .Select(d => d.DOKTORID)
                    .FirstOrDefault();

                if (doktorID > 0)
                {
                    var muayeneler = Database.Model.Muayeneler.GetMuayenelerByDoktorID(doktorID);  // Modelden veriyi alıyoruz
                    DoktorMuayene.DataSource = muayeneler.Select(m => new
                    {
                        m.MUAYENEID,
                        m.HASTAID,
                        m.DOKTORID,
                        m.TarihSaat
                        
                    }).ToList(); // DataGridView'e bağlıyoruz
                }
                else
                {
                    MessageBox.Show("Giriş yapan kullanıcı doktor değil.");
                }
            }

        }
        private int GetPersonelIDByKullaniciID(int kullaniciID)
        {

            {
                // KullaniciID'ye göre PersonelID'yi alıyoruz
                return Database.Model.Personeller.dp.PERSONELLER
                    .Where(p => p.KULLANICIID == kullaniciID)
                    .Select(p => p.PERSONELID)
                    .FirstOrDefault();
            }
        }
        private int GetDoctorIDByPersonelID(int personelID)
        {


            // Personel görevinin doktor olup olmadığını kontrol ediyoruz
            string personelGorev = Database.Model.Personeller.dp.PERSONELLER
                .Where(p => p.PERSONELID == personelID)
                .Select(p => p.PersonelGörevi)
                .FirstOrDefault();

            if (personelGorev == "Doktor")
            {
                // Eğer personel doktor ise, Doktorlar tablosundan doktorID'yi alıyoruz
                return Database.Model.Doktorlar.dbd.DOKTORLAR
                    .Where(d => d.PERSONELID == personelID)
                    .Select(d => d.DOKTORID)
                    .FirstOrDefault();
            }
            return 0; // Doktor değilse 0 döndürüyoruz

        }
        private List<Database.Entity.MUAYENELER> GetGelecekMuayeneler(int doktorID)
        {
            //using (var context = new Hastanedb())
            //{
            // Doktorun gelecekteki muayenelerini listeleme
            return Database.Model.Muayeneler.dbm.MUAYENELER
                .Where(m => m.DOKTORID == doktorID && m.TarihSaat >= DateTime.Now)
                .ToList();
            //}
        }
        private void LoadUpcomingAppointments(int doktorID)
        {
            var muayeneler = GetGelecekMuayeneler(doktorID);
            DoktorMuayene.DataSource = muayeneler.Select(m => new
            {
                m.MUAYENEID,
                m.HASTAID,
                m.DOKTORID,
                m.TarihSaat
                
            }).ToList(); // Muayeneleri Da
            //DataTable dtMuayeneler = GetGelecekMuayeneler(doktorID);
            //_DoktorMuayeneleri_dataGridView.DataSource = dtMuayeneler; // Muayeneleri grid üzerinde göster
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

        }

        private void DoktorMuayene_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satıra tıklandığında
            {
                // Muayene DataGridView'den HASTAID'yi alıyoruz
                int hastaID = Convert.ToInt32(DoktorMuayene.Rows[e.RowIndex].Cells["HASTAID"].Value);
                // Hasta bilgileri formunu açıyoruz ve hasta ID'sini gönderiyoruz
                DMuayeneleriAyrinti hastaForm = new DMuayeneleriAyrinti(hastaID);
                hastaForm.ShowDialog(); // Modal olarak açıyoruz
            }
        }
    }
}
