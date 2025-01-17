using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace OtobusBiletOtomasyonu
{
    public partial class BiletSil : Form
    {
        public BiletSil()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.Bilet1TableAdapter taBilet = new DSOtobusBiletOtomasyonuTableAdapters.Bilet1TableAdapter();

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taBilet.BiletSil(Convert.ToInt32(lblBiletID.Text));
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
