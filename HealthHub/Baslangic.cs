using HealthHub.PersonelErişimleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthHub
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }

        private void HastaGiris_Click(object sender, EventArgs e)
        {
            HastaGiris hg = new HastaGiris();
            hg.Show();
        }

        private void PersonelGiris_Click(object sender, EventArgs e)
        {
            PersonelGiris personel = new PersonelGiris();
            personel.Show();
        }

        private void Baslangic_Load(object sender, EventArgs e)
        {

        }
    }
}
