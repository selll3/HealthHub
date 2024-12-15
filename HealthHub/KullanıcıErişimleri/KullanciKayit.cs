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
using HealthHub.Database.Model;
using HealthHub.KullanıcıErişimleri;


namespace HealthHub
{
    public partial class KullanciKayit : Form
    {
        public KullanciKayit()
        {
            InitializeComponent();
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

        private void KullanciKayit_Load(object sender, EventArgs e)
        {

        }

        private void KullaniciKayit_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                // Sadece TextBox'ları kontrol et
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    isAnyEmpty = true;
                    break;
                }
            }

            if (isAnyEmpty)
            {
                MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Yeni kullanıcıyı ekle
                KULLANICILAR newUser = new KULLANICILAR
                {
                    KullaniciAdi = KullaniciAdiKayit.Text,
                    Parola = ParolaKayit.Text
                };

                // Model katmanındaki KullaniciEkle yöntemini çağır
                bool userAdded = Database.Model.Kullanicilar.KullaniciEkle(newUser);

                if (userAdded)
                {
                    // Yetkileri ekleme
                    List<int> formIDs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

                    foreach (var formID in formIDs)
                    {
                        PERSONELFORMYETKILERI yetki = new PERSONELFORMYETKILERI
                        {
                            KULLANICIID = newUser.KULLANICIID, // KULLANICIID yeni kullanıcının ID'si
                            FormID = formID,
                            Yetki = false // 0 yerine false
                        };

                        // Model katmanındaki YetkiEkle yöntemini çağır
                        Database.Model.Yetkiler.YetkiEkleVeyaGuncelle(yetki);
                    }

                    MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TumKullanicilar formh = Application.OpenForms.OfType<TumKullanicilar>().FirstOrDefault();
                    if (formh != null)
                    {
                        formh.LoadDatakullanici(); // İlk formun veri yükleme metodunu çağır
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenirken bir hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
