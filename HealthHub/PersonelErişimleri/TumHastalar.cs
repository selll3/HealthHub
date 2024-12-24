using HealthHub.Database.Entity;
using HealthHub.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HealthHub.PersonelErişimleri
{
    public partial class TumHastalar : Form
    {
        private int kid;
        private static HealthHubDb db = new HealthHubDb();
        public TumHastalar(int kullaniciid)
        {
            kid = kullaniciid;

            InitializeComponent();
            //yetkileriolustur();
            LoadDataIntoGridh();
        }
        //private void yetkileriolustur()
        //{

        //    var userPermissions = db.PERSONELFORMYETKILERI
        //                                   .Where(p => p.KULLANICIID == kid && p.Yetki == true)
        //                                   .ToList();


        //    foreach (var permission in userPermissions)
        //    {
        //        switch (permission.FormID)
        //        {
        //            case 1:
        //                _Ekle_button.Enabled = true;
        //             break;



        //        }
        //    }
        //}

        public void LoadDataIntoGridh()
        {
            //Hastanedb db = new Hastanedb();
            //_Hastalar_dataGridView.DataSource = Database.Model.Hastalar.db.HASTALAR.ToList();


            Hasta.DataSource = Database.Model.Hastalar.HastalariGetir();
            //_Hastalar_dataGridView.DataSource = Database.Model.Hastalar.db.HASTALAR
            //    .Select(r => new
            //    {
            //        r.HASTAID,  // İstediğin sütunları buraya ekleyebilirsin
            //        r.HastaAdi,
            //        r.HastaSoyadi,
            //        r.HastaYasi

            //        // r.Bulgu gibi başka sütunlar da ekleyebilirsin
            //    }).ToList();

            // DOKTORID sütununu gizle
            //if (_Hastalar_dataGridView.Columns.Contains("HASTAID"))
            //{
            //    _Hastalar_dataGridView.Columns["HASTAID"].Visible = false;
            //}

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

        private void TumHastalar_Load(object sender, EventArgs e)
        {

        }

        private void Hasta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
