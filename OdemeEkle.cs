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
    public partial class OdemeEkle : Form
    {
        public OdemeEkle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.OdemeTableAdapter taOdeme = new DSOtobusBiletOtomasyonuTableAdapters.OdemeTableAdapter();


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int yeniGuzergahID;

            try
            {

                // Vertitabanında olan en yüksek ID değerini alıyor ve yeni bir yolcu eklemek için kullanılacak yeni bir ID belirtiyor.

                object maxID = taOdeme.GetOdeme();
                yeniGuzergahID = (maxID != null && int.TryParse(maxID.ToString(), out int maxValue)) ? maxValue + 1 : 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödeme ID oluşturulurken bir hata oluştu: {ex.Message}");
                return;
            }

            string odemeID = (lblOdemeID.Text);
            string yolcuAdiSoyadi = tbYolcuAdiSoyadi.Text;
            string toplamTutar = tbToplamTutar.Text;
            string OdemeTarihi = tbOdemeTarihi.Text;
            string odemeTipi = cbOdemeTipi.Text;


            if (string.IsNullOrWhiteSpace(yolcuAdiSoyadi) || string.IsNullOrWhiteSpace(toplamTutar) ||
                string.IsNullOrWhiteSpace(OdemeTarihi) || string.IsNullOrWhiteSpace(odemeTipi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                taOdeme.OdemeEkle(yolcuAdiSoyadi, Convert.ToInt32(toplamTutar), OdemeTarihi, odemeTipi);

                MessageBox.Show("Ödeme başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
