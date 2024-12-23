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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        //private void StyleButton(Button button)
        //{
        //    button.FlatStyle = FlatStyle.Flat;
        //    button.BackColor = Color.FromArgb(34, 34, 34); // Koyu renk arka plan
        //    button.ForeColor = Color.White; // Beyaz metin
        //    button.Font = new Font("Arial", 12, FontStyle.Bold); // Yazı tipi ve boyutu
        //    button.Size = new Size(160, 45); // Buton boyutunu ayarla
        //    button.FlatAppearance.BorderSize = 0; // Kenarları gizle
        //    button.Cursor = Cursors.Hand; // Buton üzerine gelindiğinde el simgesi
        //}

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
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(255, 228,255); // Hover efekti
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(191, 223, 255); // Orijinal renk
        }


        private void KullaniciAnaMenu_Load(object sender, EventArgs e)
        {
            //StyleButton(button1);
            //StyleButton(button2);
            //StyleButton(button3);
            //StyleButton(button4);
           
            button1.MouseEnter += button_MouseEnter;
            button1.MouseLeave += button_MouseLeave;

            button2.MouseEnter += button_MouseEnter;
            button2.MouseLeave += button_MouseLeave;

            button3.MouseEnter += button_MouseEnter;
            button3.MouseLeave += button_MouseLeave;

            button4.MouseEnter += button_MouseEnter;
            button4.MouseLeave += button_MouseLeave;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TumPersoneller pers = new TumPersoneller(currentUserId);
           pers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TumKullanicilar tk =new TumKullanicilar(currentUserId);
            tk.Show();
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
    }
}
