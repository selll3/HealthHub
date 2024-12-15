using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthHub.Database.Model;
namespace HealthHub.PersonelErişimleri
{
    public partial class TumMuayenelercs : Form
    {
        public TumMuayenelercs()
        {
            InitializeComponent();
        }

        private void TumMuayenelercs_Load(object sender, EventArgs e)
        {
            ListeleMuayeneler();
        }
        private void ListeleMuayeneler()
        {
            var muayeneler = Muayeneler.GetTumMuayenelerWithDetails();
            dataGridView1.DataSource = muayeneler; // Listeyi DataGridView'e bağla
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int muayeneID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MUAYENEID"].Value);
                var result = Muayeneler.MuayeneSil(muayeneID);
                if (result)
                {
                    MessageBox.Show("Muayene başarıyla silindi!");
                    ListeleMuayeneler(); // Güncel listeyi yükle
                }
                else
                {
                    MessageBox.Show("Muayene silinirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir muayene seçiniz!");
            }
        }

        private void GUNCELLE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int muayeneID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MUAYENEID"].Value);

                // Güncelleme formunu aç
                MuayeneGuncelle guncelleForm = new MuayeneGuncelle(muayeneID);
                if (guncelleForm.ShowDialog() == DialogResult.OK)
                {
                    ListeleMuayeneler(); // Güncel listeyi yükle
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için bir muayene seçiniz!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vazgec_Click(object sender, EventArgs e)
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

        private void EKLE_Click(object sender, EventArgs e)
        {
            MuayeneEkle me = new MuayeneEkle();
            me.Show();
        }
    }
}
