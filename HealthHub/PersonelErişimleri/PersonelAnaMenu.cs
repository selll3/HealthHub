using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthHub.PersonelErişimleri
{
    public partial class PersonelAnaMenu : Form
    {
        private int currentUserId;
        public PersonelAnaMenu(int userId)
        {
            currentUserId = userId;
            InitializeComponent();
        }

        private void PersonelAnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
