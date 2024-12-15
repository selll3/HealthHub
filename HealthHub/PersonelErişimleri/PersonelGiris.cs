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
//using System.Data.Entity.Database.Entity;
using HealthHub.Database.Entity;



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
            var kullanici = hb.KULLANICILAR
                .Where(g => g.KullaniciAdi == kullaniciAdi && g.Parola == parola) // Büyük/küçük harf duyarlı eşleşme
                .FirstOrDefault();

            if (kullanici != null)
            {
                // Kullanıcı bulundu, ana formu aç
                int kullaniciID = kullanici.KULLANICIID;

                DoktorMuayeneleri dm = new DoktorMuayeneleri(kullaniciID);

                PersonelAnaMenu personelAnaMenu = new PersonelAnaMenu(kullaniciID);
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
    }
}
