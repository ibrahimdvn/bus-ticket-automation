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
    public partial class BiletEkle : Form
    {
        public BiletEkle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.Bilet1TableAdapter taBilet = new DSOtobusBiletOtomasyonuTableAdapters.Bilet1TableAdapter();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int yeniBiletID;

            try
            {

                object maxID = taBilet.GetBilet();
                yeniBiletID = (maxID != null && int.TryParse(maxID.ToString(), out int maxValue)) ? maxValue + 1 : 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilet ID oluşturulurken bir hata oluştu: {ex.Message}");
                return;
            }


            if (string.IsNullOrWhiteSpace(tbYolcuAdi.Text) || string.IsNullOrWhiteSpace(tbYolcuSoyadi.Text) ||
                string.IsNullOrWhiteSpace(tbHareketSaati.Text) || string.IsNullOrWhiteSpace(tbVarisSaati.Text)
                || string.IsNullOrWhiteSpace(tbSure.Text) || string.IsNullOrWhiteSpace(tbSatinAlmatarihi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            try
            {

                taBilet.BiletEkle(tbYolcuAdi.Text, tbYolcuSoyadi.Text, tbHareketSaati.Text, tbVarisSaati.Text, tbSure.Text, tbSatinAlmatarihi.Text);
                MessageBox.Show("Bilet başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilet eklenirken bir hata oluştu: {ex.Message}");
            }
            this.Close();
        }

        private void btnKoltukSec_Click_1(object sender, EventArgs e)
        {

            using (KoltukSec koltukSecForm = new KoltukSec())
            {
                if (koltukSecForm.ShowDialog() == DialogResult.OK)
                {
                    lblSeciliKoltuk.Text = koltukSecForm.selectedSeat;
                }
            }

            KoltukSec frm = new KoltukSec();
            frm.ShowDialog();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

