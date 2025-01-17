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
    public partial class OtobusGuncelle : Form
    {
        public OtobusGuncelle()
        {
            InitializeComponent();
        }


        DSOtobusBiletOtomasyonuTableAdapters.OtobusTableAdapter taOtobus = new DSOtobusBiletOtomasyonuTableAdapters.OtobusTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cbOtobusKapasitesi.Text, out int otobusKapasitesi) &&
            int.TryParse(lblOtobusID.Text, out int otobusID))
            {
                taOtobus.OtobusGuncelle(tbOtobusPlakasi.Text, otobusKapasitesi, cbOtobusMarkasi.Text, cbOtobusModeli.Text, otobusID);
                MessageBox.Show("Otobüs Kaydı Başarıyla Güncellendi.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Kapasite ve Otobüs ID alanlarını doğru formatta doldurun.");
            }

        }
    }
}
