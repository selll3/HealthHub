using HealthHub.Database.Entity;
using HealthHub.Database.Model;
using HealthHub.PersonelErişimleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthHub.KullanıcıErişimleri
{
    public partial class KullaniciAnaMenu : Form
    {
        private int currentUserId;
        HealthHubDb kmenu = new HealthHubDb();
        public KullaniciAnaMenu(int userId)
        {
            currentUserId = userId;
            InitializeComponent();
            yetkileriolustur();
        }
        private void yetkileriolustur()
        {

            var userPermissions = kmenu.PERSONELFORMYETKILERI
                                           .Where(p => p.KULLANICIID == currentUserId && p.Yetki == true)
                                           .ToList();


            foreach (var permission in userPermissions)
            {
                switch (permission.FormID)
                {
                    case 1007:
                        button1.Enabled = true;
                        break;
                    case 1008:
                        button2.Enabled = true;

                        break;
                    case 1009:
                        button3.Enabled = true;
                        break;
                    case 1004:
                        button2.Enabled = true;
                        break;
                    case 1010:
                        button4.Enabled = true;
                        break;
                    


                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PersonelKayit pk = new PersonelKayit();
            pk.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullanciKayit kk = new KullanciKayit();
            kk.Show();

        }

        private void KullaniciAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personeller pers = new Personeller(currentUserId);
           pers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TumKullanicilar tk =new TumKullanicilar(currentUserId);
            tk.Show();
        }
    }
}
