using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthHub.Database.Entity;
using HealthHub.PersonelErişimleri;

namespace HealthHub
{
    public partial class HastaGiris : Form
    {  private HealthHubDb hb = new HealthHubDb();
        public HastaGiris()
        {
            InitializeComponent();
        }

        private void HastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc = textBox1.Text;
            string parola = textBox2.Text;

            // LINQ kullanarak veritabanında kullanıcı sorgulama
            var hasta = hb.HASTALAR
                .Where(g => g.Tc.Equals(tc, StringComparison.OrdinalIgnoreCase) &&
                            g.Parola.Equals(parola))
                .FirstOrDefault();

            if (hasta != null)
            {
                // Kullanıcı bulundu, ana formu aç
                int hastaid = hasta.HASTAID;

                //DoktorMuayeneleri dm = new DoktorMuayeneleri(hastaid);

                HastaAnaMenu HastaAnaMenu = new HastaAnaMenu(hastaid);
                this.Hide();
                HastaAnaMenu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayit hk = new HastaKayit();
            hk.Show();
        }
    }
}
