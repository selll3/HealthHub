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

namespace HealthHub
{
    public partial class Tahlillerim : Form
    {
        public Tahlillerim()
        {
            InitializeComponent();
           
        }
      
        private void FillComboSearchHasta()
        {


            var hastalar = Database.Model.Hastalar.dbh.HASTALAR
                .Select(h => new
                {
                    h.HASTAID,
                    ADSOYAD = h.Ad + " " + h.Soyad
                })
                .ToList();
            comboBox1.DataSource = hastalar;
            comboBox1.ValueMember = "HASTAID";
            comboBox1.DisplayMember = "ADSOYAD";



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

        private void Tahlillerim_Load(object sender, EventArgs e)
        {
            FillComboSearchHasta();
            // Hem otomatik genişleme hem de kullanıcıya manuel genişletme izni:
            _Tahliller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _Tahliller.AllowUserToResizeColumns = true;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int hastaID))
            {
                // Tahlilleri dinamik türde getir
                var tahliller = HealthHub.Database.Model.Tahliller.TahlilleriGetir(hastaID);

                if (tahliller != null && tahliller.Any())
                {
                    var tahlilListesi = new List<object>();

                    // Her tahlili işle
                    foreach (var tahlil in tahliller)
                    {
                        // Dinamik türün içindeki 'Degerler' listesini manuel işle
                        var degerlerListesi = tahlil.Degerler as IEnumerable<dynamic>;

                        string testDegerleri = "Değerler yok";
                        if (degerlerListesi != null && degerlerListesi.Any())
                        {
                            testDegerleri = string.Join(", ", degerlerListesi.Select(d => $"{d.ParametreAdi}: {d.Deger}"));
                        }

                        // Tahlili işlenmiş haliyle listeye ekle
                        tahlilListesi.Add(new
                        {
                            TahlilID = tahlil.TahlilID,
                            TahlilIsmi = tahlil.TahlilIsmi,
                            TestDegerleri = testDegerleri
                        });
                    }

                    // İşlenmiş tahlilleri DataGridView'e ata
                    _Tahliller.DataSource = tahlilListesi;
                    _Tahliller.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    _Tahliller.DataSource = null;
                    MessageBox.Show("Seçilen hastanın tahlilleri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void _Tahliller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
