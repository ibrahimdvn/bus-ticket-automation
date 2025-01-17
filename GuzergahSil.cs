using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletOtomasyonu
{
    public partial class GuzergahSil : Form
    {
        public GuzergahSil()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.GuzergahTableAdapter taGuzergah = new DSOtobusBiletOtomasyonuTableAdapters.GuzergahTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taGuzergah.GuzergahSil(Convert.ToInt32(lblGuzergahID.Text));
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
