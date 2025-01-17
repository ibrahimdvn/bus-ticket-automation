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
    public partial class SeferSil : Form
    {
        public SeferSil()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.SeferTableAdapter taSefer = new DSOtobusBiletOtomasyonuTableAdapters.SeferTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taSefer.SeferSil(Convert.ToInt32(lblSeferID.Text));
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
