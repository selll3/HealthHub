using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthHub.KullanıcıErişimleri
{
    public partial class Personeller : Form
    {
        int currentUserId;
        public Personeller(int userId)
        {
            currentUserId = userId;
            LoadDataIntoGridp();
            InitializeComponent();
           
        }

        public void LoadDataIntoGridp()
        {
            //dtp = new DataTable();
            //string readQuery = "SELECT PERSONELID, PersonelAdi, PersonelSoyadi,PersonelGorev FROM PERSONEL";
            //dap = new SqlDataAdapter(readQuery, con);
            //dap.Fill(dtp);
            //_Personeller_dataGridView.DataSource = dtp;


            _Personel.DataSource = Database.Model.Personeller.PersoneliGetir();
            //_Personeller_dataGridView.DataSource = Database.Model.Personeller.dp.PERSONEL
            //    .Select(r => new
            //    {
            //        r.PERSONELID,  // İstediğin sütunları buraya ekleyebilirsin
            //        r.PersonelAdi,
            //        r.PersonelSoyadi,
            //        r.PersonelGorev
            //        //r.KULLANICIID

            //        // r.Bulgu gibi başka sütunlar da ekleyebilirsin
            //    }).ToList();
            // DOKTORID sütununu gizle
            //if (_Personeller_dataGridView.Columns.Contains("PERSONELID"))
            //{
            //    _Personeller_dataGridView.Columns["PERSONELID"].Visible = false;
            //}

        }
        private void verileriyükle()
        {


            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
            _Personel.DataSource = Database.Model.Personeller.PersoneliGetir();
            //_Personeller_dataGridView.DataSource = Database.Model.Personeller.dp.PERSONEL
            //   .Select(r => new
            //   {
            //       r.PERSONELID,  // İstediğin sütunları buraya ekleyebilirsin
            //       r.PersonelAdi,
            //       r.PersonelSoyadi,
            //       r.PersonelGorev
            //       //r.KULLANICIID

            //       // r.Bulgu gibi başka sütunlar da ekleyebilirsin
            //   }).ToList();


        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            _Personel.RowHeadersVisible = false;
        }

        private void _VAZGEC_Click(object sender, EventArgs e)
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
