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

namespace HealthHub.PersonelErişimleri
{
    public partial class MuayeneGuncelle : Form
    {
        private int muayeneID;
        private MUAYENELER muayene;
        public MuayeneGuncelle(int muayeneID)
        {
            InitializeComponent();
            this.muayeneID = muayeneID;
        }

        private void MuayeneGuncelle_Load(object sender, EventArgs e)
        {
            muayene = Muayeneler.GetTumMuayeneler().FirstOrDefault(m => m.MUAYENEID == muayeneID);

            if (muayene != null)
            {
                // Doktor ve hasta bilgilerini doldur
                comboBoxDoktor.DataSource = HealthHub.Database.Model.Doktorlar.DoktorlariGetir();  
                comboBoxDoktor.DisplayMember = "AdSoyad";
                comboBoxDoktor.ValueMember = "DOKTORID";
                comboBoxDoktor.SelectedValue = muayene.DOKTORID;

                comboBoxHasta.DataSource = Hastalar.HastalariGetir();
                comboBoxHasta.DisplayMember = "AdSoyad";
                comboBoxHasta.ValueMember = "HASTAID";
                comboBoxHasta.SelectedValue = muayene.HASTAID;

                // Tarih/Saat bilgisini doldur
                dateTimePicker1.Value = muayene.TarihSaat ?? DateTime.Now;
            }
        }

        private void KAYDET_Click(object sender, EventArgs e)
        {
            if (muayene != null)
            {
                muayene.DOKTORID = Convert.ToInt32(comboBoxDoktor.SelectedValue);
                muayene.HASTAID = Convert.ToInt32(comboBoxHasta.SelectedValue);
                muayene.TarihSaat = dateTimePicker1.Value;

                var result = Muayeneler.MuayeneGuncelle(muayene);
                if (result)
                {
                    MessageBox.Show("Muayene bilgileri başarıyla güncellendi!");
                    this.DialogResult = DialogResult.OK; // Ana forma güncelleme sinyali gönder
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Muayene güncellenirken bir hata oluştu.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1; // ComboBox seçimini temizle
                }
                else if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty; // TextBox içeriğini temizle
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now; // DateTimePicker'ı sıfırla
                }
            }

            this.Close(); // Formu kapat
        }
    }
}
