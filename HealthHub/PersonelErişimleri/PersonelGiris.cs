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
using System.Data.SqlClient;
using System.Data.Entity;





namespace HealthHub.PersonelErişimleri
{   
    public partial class PersonelGiris : Form
    { 
        public PersonelGiris()
        {
            InitializeComponent();
        }
        private HealthHubDb hb = new HealthHubDb();
        private void Giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdi.Text;
            string parola = Parola.Text;

            // LINQ kullanarak veritabanında kullanıcı sorgulama
            var kullanici = HealthHub.Database.Entity.KULLANICILAR
                .Where(g => g.KullaniciAdi.Equals(kullaniciAdi, StringComparison.OrdinalIgnoreCase) &&
                            g.Parola.Equals(parola))
                .FirstOrDefault();

            if (kullanici != null)
            {
                // Kullanıcı bulundu, ana formu aç
                int kullaniciID = kullanici.KULLANICIID;

                DoktorMuayeneleri dm = new DoktorMuayeneleri(kullaniciID);

                PersonelAnaMenu personelAnaMenu= new PersonelAnaMenu(kullaniciID);
                this.Hide();
                personelAnaMenu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }

        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
