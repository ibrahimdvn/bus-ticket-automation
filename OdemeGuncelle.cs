using OtobusBiletOtomasyonu.DSOtobusBiletOtomasyonuTableAdapters;
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
    public partial class OdemeGuncelle : Form
    {
        public OdemeGuncelle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.OdemeTableAdapter taOdeme = new DSOtobusBiletOtomasyonuTableAdapters.OdemeTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                
                string yolcuAdiSoyadi = tbYolcuAdiSoyadi.Text;
                string odemeTipi = cbOdemeTipi.SelectedItem?.ToString();
                int    OdemeID   = Convert.ToInt32(lblOdemeID.Text);


                decimal toplamTutar = decimal.Parse(tbToplamTutar.Text.Trim(), System.Globalization.CultureInfo.InvariantCulture);
                String odemeTarihi = tbOdemeTarihi.Text.ToString();

                
                taOdeme.OdemeGuncelle(yolcuAdiSoyadi, toplamTutar, odemeTarihi, odemeTipi, OdemeID);

                MessageBox.Show("Ödeme başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Toplam tutar veya tarih formatı hatalı! Lütfen uygun değerler girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
