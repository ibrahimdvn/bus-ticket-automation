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
    public partial class GuzergahGuncelle : Form
    {
        public GuzergahGuncelle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.GuzergahTableAdapter taGuzergah = new DSOtobusBiletOtomasyonuTableAdapters.GuzergahTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            taGuzergah.GuzergahGuncelle(tbBaslangicSehir.Text, tbBitisSehir.Text, Convert.ToString(tbMesafe.Text), tbTahminiSure.Text, Convert.ToInt32(lblGuzergahID.Text));
            this.Close();
            MessageBox.Show("Güzergah Güncellendi.");
        }
    }
}
