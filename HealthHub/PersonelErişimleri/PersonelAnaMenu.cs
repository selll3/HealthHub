using HealthHub.KullanıcıErişimleri;
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
    public partial class PersonelAnaMenu : Form
    {
        private int currentUserId;
        public PersonelAnaMenu(int userId)
        {
            currentUserId = userId;
            InitializeComponent();
        }

        private void PersonelAnaMenu_Load(object sender, EventArgs e)
        {

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

        private void _KullaniciIslemleri_Click(object sender, EventArgs e)
        {
          KullaniciAnaMenu kullaniciAnaMenu = new KullaniciAnaMenu();
            kullaniciAnaMenu.Show();
        }

        private void DoktorMuayeneleri_Click(object sender, EventArgs e)
        {
            DoktorMuayeneleri dm = new DoktorMuayeneleri(currentUserId);
            dm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TumMuayenelercs tm = new TumMuayenelercs();
            tm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tahlillerim t = new Tahlillerim();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TahlilGiris tg = new TahlilGiris();
            tg.Show();
        }

        private void Hastalar_Click(object sender, EventArgs e)
        {
            TumHastalar th = new TumHastalar(currentUserId);
            th.Show();

        }
    }
}
