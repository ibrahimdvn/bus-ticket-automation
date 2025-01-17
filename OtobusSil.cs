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
    public partial class OtobusSil : Form
    {
        public OtobusSil()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.OtobusTableAdapter taOtobus = new DSOtobusBiletOtomasyonuTableAdapters.OtobusTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taOtobus.OtobusSil(Convert.ToInt32(lblOtobusID.Text));
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
