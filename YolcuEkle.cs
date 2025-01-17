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
    public partial class YolcuEkle : Form
    {
        public YolcuEkle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.YolcuTableAdapter taYolcu = new DSOtobusBiletOtomasyonuTableAdapters.YolcuTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int yeniYolcuID;

            try
            {

                object maxID = taYolcu.GetYolcu();
                yeniYolcuID = (maxID != null && int.TryParse(maxID.ToString(), out int maxValue)) ? maxValue + 1 : 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yolcu ID oluşturulurken bir hata oluştu: {ex.Message}");
                return;
            }


            if (string.IsNullOrWhiteSpace(tbYolcuYasi.Text) || !int.TryParse(tbYolcuYasi.Text, out int yolcuYasi))
            {
                MessageBox.Show("Geçersiz yaş formatı. Lütfen geçerli bir sayı giriniz.");
                return;
            }


            if (string.IsNullOrWhiteSpace(tbYolcuTC.Text) || string.IsNullOrWhiteSpace(tbYolcuAdi.Text) ||
                string.IsNullOrWhiteSpace(tbYolcuSoyadi.Text) || cbYolcuCinsiyeti.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }


            if (!(cbYolcuCinsiyeti.Text == "Erkek" || cbYolcuCinsiyeti.Text == "Kadın"))
            {
                MessageBox.Show("Geçerli bir cinsiyet seçiniz.");
                return;
            }

            try
            {

                taYolcu.YolcuEkle(tbYolcuTC.Text.Trim(), tbYolcuAdi.Text.Trim(),
                                  tbYolcuSoyadi.Text.Trim(), yolcuYasi, cbYolcuCinsiyeti.Text);
                MessageBox.Show("Yolcu başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yolcu eklenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
