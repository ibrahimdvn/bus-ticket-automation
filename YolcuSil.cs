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
    public partial class YolcuSil : Form
    {
        public YolcuSil()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.YolcuTableAdapter taYolcu = new DSOtobusBiletOtomasyonuTableAdapters.YolcuTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taYolcu.YolcuSil(Convert.ToInt32(lblYolcuID.Text));
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
