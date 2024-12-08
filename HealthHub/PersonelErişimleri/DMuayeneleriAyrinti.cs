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

namespace HealthHub.PersonelErişimleri
{
    public partial class DMuayeneleriAyrinti : Form
    {
        private int hastaID;
        public DMuayeneleriAyrinti(int _hastaID)
        {
            InitializeComponent();
            hastaID = _hastaID; // Hasta ID'sini form yüklenirken alıyoruz
            LoadHastaBilgileri();
            LoadHastaMuayeneGecmisi();
        }
        private void LoadHastaMuayeneGecmisi()
        {
            using (var context = new HealthHubDb())
            {
                var muayeneGeçmişi = context.MUAYENELER
                    .Where(m => m.HASTAID == hastaID)
                    .Select(m => new
                    {
                        m.MUAYENEID,
                        m.TarihSaat
                        
                    })
                    .ToList();

                dataGridView1.DataSource = muayeneGeçmişi; // Geçmiş muayeneleri DataGridView'e bağla
            }
        }
        private void LoadHastaBilgileri()
        {
            using (var context = new HealthHubDb())
            {
                var hasta = context.HASTALAR
                    .Where(h => h.HASTAID == hastaID)
                    .Select(h => new
                    {   h.Tc,
                        h.Ad,
                        h.Soyad
                        
                       
                    })
                    .FirstOrDefault();

                if (hasta != null)
                {   
                    textBoxTC.Text = hasta.Tc.ToString();
                    _ad.Text = hasta.Ad;
                    _soyad.Text = hasta.Soyad;
                   
                }
            }
        }

        private void DMuayeneleriAyrinti_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["MUAYENEID"].Visible = false;
            dataGridView1.Columns["TarihSaat"].HeaderText = "Muayene Tarihi";
            
        }

        private void button1_Click(object sender, EventArgs e)
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
