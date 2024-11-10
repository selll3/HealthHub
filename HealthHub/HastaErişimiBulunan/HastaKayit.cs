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
using HealthHub.Database.Model;
using HealthHub.PersonelErişimleri;

namespace HealthHub
{
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaGiris hastaGiris = new HastaGiris();
            hastaGiris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
                HASTALAR hst = new HASTALAR();
                hst.Ad = HastaAdi.Text;
                hst.Soyad = HastaSoyadi.Text;
                hst.Tc= HastaTcKayit.Text;
                hst.Parola = ParolaKayit.Text;

                var eklendi = Database.Model.Hastalar.HastaEkle(hst);
                if (eklendi)
                {


                    MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else
                {
                    MessageBox.Show("KAYIT OLUŞTURULAMADI", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            // İlk formu güncelle ve göster
             TumHastalar formh = Application.OpenForms.OfType<TumHastalar>().FirstOrDefault();
            if (formh != null)
            {
                formh.LoadDataIntoGridh(); // İlk formun veri yükleme metodunu çağır
            }

            this.Close();
        }

        private void HastaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
