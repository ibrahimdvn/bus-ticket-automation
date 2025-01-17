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
    public partial class OdemeSil : Form
    {
        public OdemeSil()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.OdemeTableAdapter taOdeme = new DSOtobusBiletOtomasyonuTableAdapters.OdemeTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                taOdeme.OdemeSil(Convert.ToInt32(lblOdemeID.Text));
                this.Close();
            }
            else
            {
                this.Close();
            }

            MessageBox.Show("Ödeme Başarıyla Silindi.");
        }

        
    }
}

