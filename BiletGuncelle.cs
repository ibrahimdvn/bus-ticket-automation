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
    public partial class BiletGuncelle : Form
    {
        public BiletGuncelle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.Bilet1TableAdapter taBilet = new DSOtobusBiletOtomasyonuTableAdapters.Bilet1TableAdapter();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            taBilet.BiletGuncelle(tbYolcuAdi.Text, tbYolcuSoyadi.Text, tbHareketSaati.Text, tbVarisSaati.Text, Convert.ToString(tbSure.Text), Convert.ToInt32(lblSeciliKoltuk.Text), tbSatinAlmaTarihi.Text, Convert.ToInt32(lblBiletID.Text));
            MessageBox.Show("Bilet güncellendi.");
            this.Close();
        }

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
            KoltukSec frm = new KoltukSec();
            frm.ShowDialog();
            lblSeciliKoltuk.Text = frm.selectedSeat;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
