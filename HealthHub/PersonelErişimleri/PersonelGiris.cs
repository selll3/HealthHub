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

            var kullanici = hb.KULLANICILAR
                .FirstOrDefault(g => g.KullaniciAdi.Equals(kullaniciAdi, StringComparison.Ordinal)
                                  && g.Parola.Equals(parola, StringComparison.Ordinal)); // Büyük/küçük harf duyarlılığı sağlanır

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

        // SELİNAY SEN PERSONEL GİRİŞ DE KÜÇÜK BÜYÜK HARF AYRIMINA DİKKAT EDEREK GİRİŞ YAPMAYI DÜZELT
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Parola.PasswordChar = '\0'; // Şifreyi görünür yap
            }
            else
            {
                Parola.PasswordChar = '*'; // Şifreyi tekrar gizle
            }
        }
    }
}
