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
    public partial class YolcuGuncelle : Form
    {
        public YolcuGuncelle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.YolcuTableAdapter taYolcu = new DSOtobusBiletOtomasyonuTableAdapters.YolcuTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            taYolcu.YolcuGuncelle(Convert.ToString(tbYolcuTC.Text), tbYolcuAdi.Text, tbYolcuSoyadi.Text, Convert.ToInt32(tbYolcuYasi.Text), cbYolcuCinsiyeti.Text, Convert.ToInt32(lblYolcuID.Text));
            MessageBox.Show("Yolcu güncellendi.");
            this.Close();
        }
    }
}
