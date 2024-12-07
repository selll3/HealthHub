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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int hastaID))
            {
                List<dynamic> tahliller = Tahliller.TahlilleriGetir(hastaID); // Tahlilleri getir
                if (tahliller != null)
                {
                    // Tahlilleri DataGridView'e ata
                    _Tahliller.DataSource = tahliller.Select(t => new
                    {
                        TahlilID = t.TahlilID,
                        TahlilIsmi = t.TahlilIsmi,
                        TestDegerleri = string.Join(", ", ((List<dynamic>)t.Degerler).Select(d => $"{d.ParametreAdi}: {d.Deger}"))
                    }).ToList();
                }
                else
                {
                    _Tahliller.DataSource = null;
                    MessageBox.Show("Seçilen hastanın tahlilleri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
