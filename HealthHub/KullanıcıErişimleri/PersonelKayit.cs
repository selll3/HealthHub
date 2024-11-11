using HealthHub.Database.Entity;
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
                if (control is System.Windows.Forms.TextBox)
                {
                    control.Text = string.Empty;
                }
            }

            // Formu kapat
            this.Close();
        }

        private void PersonelKayit_Load(object sender, EventArgs e)
        {
            FillComboSeachCode();
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox && string.IsNullOrWhiteSpace(control.Text))
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
                    Ad = _PersonelAdi.Text,
                    Soyad = _PersonelSoyadi.Text,
                    PersonelGörevi = PersonelGorev.SelectedItem.ToString(),

                    KULLANICIID = kullaniciId
                };

                // Önce PERSONEL kaydını ekle
                context.PERSONELLER.Add(yP);
                context.SaveChanges(); // SaveChanges çağrısı yaparak veritabanına ekleyin

                // PERSONELID değerini aldıktan sonra doktor ekleme
                int personelID = yP.PERSONELID;

                // Eğer personel doktor ise doktorlar tablosuna da ekle
                if (PersonelGorev.SelectedItem.ToString() == "Doktor")
                {
                    AddDoctor(personelID, _PersonelAdi.Text, _PersonelSoyadi.Text);
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
        private void AddDoctor(int personelID, string doktorAdi, string doktorSoyadi)
        {
            using (var context = new HealthHubDb())
            {
                // Geçerli bir PERSONELID kontrolü
                if (personelID <= 0)
                {
                    MessageBox.Show("Geçerli bir PERSONELID değeri yok.");
                    return;
                }

                var yeniDoktor = new DOKTORLAR
                {
                    Ad = doktorAdi,
                    Soyad = doktorSoyadi,
                    Brans = DoktorBransi.SelectedItem.ToString(), // Branş ID yerine ismi kullanıyoruz
                   
                    PERSONELID = personelID // Yeni eklenen personelin ID'si
                };

                // Doktoru DOKTORLAR tablosuna ekleyin
                context.DOKTORLAR.Add(yeniDoktor);
                context.SaveChanges();

                MessageBox.Show("Doktor başarıyla eklendi.");
            }
            //using (var context = new Hastanedb())
            //{
            //    var yeniDoktor = new DOKTORLAR
            //    {
            //        DoktorAdi = doktorAdi,
            //        DoktorSoyadi = doktorSoyadi,
            //        DoktorunBransi = _doktorunbransi_comboBox.SelectedItem.ToString(), // Branş ID yerine ismi kullanıyoruz
            //        Doktorun_kati = (int)_doktorunkati_numericUpDown.Value,
            //        PERSONELID = personelID
            //    };

            //    context.DOKTORLAR.Add(yeniDoktor);
            //    context.SaveChanges();

            //    MessageBox.Show("Doktor başarıyla eklendi.");
            //}
        }
        private void FillComboSeachCode()
        {
            using (var context = new HealthHubDb())
            {
                var kullaniciListesi = context.KULLANICILAR
                    .Where(g => !context.PERSONELLER.Any(p => p.KULLANICIID == g.KULLANICIID)
                                && g.KullaniciAdi.ToLower() != "admin") // "admin" olanları büyük-küçük harf duyarsız olarak hariç tut
                    .Select(g => new
                    {
                        g.KULLANICIID,
                        g.KullaniciAdi
                    }).ToList();

                HangiKullanici.DataSource = kullaniciListesi;
                HangiKullanici.ValueMember = "KULLANICIID";
                HangiKullanici.DisplayMember = "KullaniciAdi";
            }

            //_kullanici_comboBox.Items.Clear();

        }

    }
}
