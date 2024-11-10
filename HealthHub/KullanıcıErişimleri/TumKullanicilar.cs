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
    public partial class TumKullanicilar : Form
    {
        private int currentUserId;
        public int selectedUserID; 
        public TumKullanicilar(int userId)
        {
            InitializeComponent();
            LoadDatakullanici();
            currentUserId = userId;
        }
        public void LoadDatakullanici()
        {
            TumKullancilar.DataSource = Database.Model.Kullanicilar.KullanicilariGetir();

            //_kullanicilar_dataGridView.DataSource = dk.GIRIS
            //     .Select(r => new
            //     {
            //         r.KULLANICIID,  // İstediğin sütunları buraya ekleyebilirsin
            //         r.KullaniciAdi,
            //         r.Parola


            //         // r.Bulgu gibi başka sütunlar da ekleyebilirsin
            //     }).ToList();

            // DOKTORID sütununu gizle
            if (TumKullancilar.Columns.Contains("KULLANICIID"))
            {
                TumKullancilar.Columns["KULLANICIID"].Visible = false;
            }
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

        private void TumKullanicilar_Load(object sender, EventArgs e)
        {
            TumKullancilar.RowHeadersVisible = false;
        }

        private void yetkilerigor_Click(object sender, EventArgs e)
        {
            if (TumKullancilar.SelectedRows.Count > 0)
            {
                selectedUserID = Convert.ToInt32(TumKullancilar.SelectedRows[0].Cells["KULLANICIID"].Value);
                YetkiControl yetkileriGor = new YetkiControl(selectedUserID);
                yetkileriGor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }

        }
    }
}
