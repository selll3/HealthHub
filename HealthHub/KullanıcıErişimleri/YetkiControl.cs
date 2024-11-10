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

namespace HealthHub.KullanıcıErişimleri
{
    public partial class YetkiControl : Form
    {
        private int kid;
        DataTable dt;
        public YetkiControl( int userdid)
        {
            kid = userdid;
            InitializeComponent();
        }
        private void LoadYetkiler()
        {
            using (HealthHubDb dbContext = new HealthHubDb())
            {
                var yetkiler = (from form in dbContext.FORMLAR
                                join yetki in dbContext.PERSONELFORMYETKILERI
                                on form.FormID equals yetki.FormID into formYetkileri
                                from fy in formYetkileri.Where(y => y.KULLANICIID == kid).DefaultIfEmpty()
                                select new
                                {
                                    form.FormID,
                                    form.FormAdi,
                                    Yetki = fy != null ? fy.Yetki : false // Eğer yetki kaydı yoksa varsayılan olarak false ayarlanır
                                }).ToList();

                dt = new DataTable();
                dt.Columns.Add("FormID", typeof(int));
                dt.Columns.Add("FormAdi", typeof(string));
                dt.Columns.Add("Yetki", typeof(bool));

                foreach (var item in yetkiler)
                {
                    DataRow row = dt.NewRow();
                    row["FormID"] = item.FormID;
                    row["FormAdi"] = item.FormAdi;
                    row["Yetki"] = item.Yetki;
                    dt.Rows.Add(row);
                }

                YetkiKontrol.DataSource = dt;

                // FormID sütununu gizle
                if (YetkiKontrol.Columns.Contains("FormID"))
                {
                    YetkiKontrol.Columns["FormID"].Visible = false;
                }

                YetkiKontrol.Columns[1].ReadOnly = true;
                YetkiKontrol.RowHeadersVisible = false;
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

        private void YetkiControl_Load(object sender, EventArgs e)
        {
            LoadYetkiler();
        }

        private void YetkiKontrol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == YetkiKontrol.Columns["Yetki"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)YetkiKontrol.Rows[e.RowIndex].Cells["Yetki"];
                checkBoxCell.Value = !(Convert.ToBoolean(checkBoxCell.Value)); // Mevcut değeri tersine çevir
                YetkiKontrol.RefreshEdit(); // Güncellemeleri yansıt
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                int formID = Convert.ToInt32(row["FormID"]);
                bool yetki = Convert.ToBoolean(row["Yetki"]);

                if (formID <= 0)
                {
                    MessageBox.Show("Geçersiz FormID: " + formID, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PERSONELFORMYETKILERI pfy = new PERSONELFORMYETKILERI
                {
                    KULLANICIID = kid,
                    FormID = formID,
                    Yetki = yetki
                };

                bool islemBasarili = Database.Model.Yetkiler.YetkiEkleVeyaGuncelle(pfy);

                if (!islemBasarili)
                {
                    MessageBox.Show("Bir hata oluştu. İşlem başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Kayıt başarıyla tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

            //Main mainguncel = new Main(kullaniciID);
            //mainguncel.yetkileriolustur();

        }
    }
}
