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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthHub
{
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
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

        private void PersonelKayit_Load(object sender, EventArgs e)
        {

        }

        private void kayit_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    isAnyEmpty = true;
                    break;
                }
            }

            if (isAnyEmpty)
            {
                MessageBox.Show("Doldurmalısın!!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new HealthHubDb()) // Entity Framework DbContext sınıfı
            {
                // Aynı kullanıcı zaten atanmış mı kontrol etmek için sorgu
                var kullaniciId = (int)HangiKullanici.SelectedValue;
                bool kullaniciZatenAtanmis = context.PERSONELLER.Any(p => p.KULLANICIID == kullaniciId);

                if (kullaniciZatenAtanmis)
                {
                    MessageBox.Show("Bu kullanıcı zaten bir personele atanmış!");
                    return;
                }

                // Yeni personel ekleme
                PERSONELLER yP = new PERSONELLER
                {
                    Ad = _PersonelAdi_textBox.Text,
                    Soyad = _PersonelSoyadi_textBox.Text,
                    PersonelGörevi = comboBox1.SelectedItem.ToString(),

                    KULLANICIID = kullaniciId
                };

                // Önce PERSONEL kaydını ekle
                context.PERSONEL.Add(yP);
                context.SaveChanges(); // SaveChanges çağrısı yaparak veritabanına ekleyin

                // PERSONELID değerini aldıktan sonra doktor ekleme
                int personelID = yP.PERSONELID;

                // Eğer personel doktor ise doktorlar tablosuna da ekle
                if (comboBox1.SelectedItem.ToString() == "Doktor")
                {
                    AddDoctor(personelID, _PersonelAdi_textBox.Text, _PersonelSoyadi_textBox.Text);
                }

                MessageBox.Show("Personel başarıyla eklendi.");

                // İlk formu güncelle ve göster
                var form1 = Application.OpenForms.OfType<Personeller>().FirstOrDefault();
                if (form1 != null)
                {
                    form1.LoadDataIntoGridp();
                }

                this.Close();
            }
        }
    }
}
