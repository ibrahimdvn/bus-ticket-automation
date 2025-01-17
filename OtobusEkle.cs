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
    public partial class OtobusEkle : Form
    {
        public OtobusEkle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.OtobusTableAdapter taOtobus = new DSOtobusBiletOtomasyonuTableAdapters.OtobusTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int yeniOtobusID;

            try
            {

                object maxID = taOtobus.GetOtobus();
                yeniOtobusID = (maxID != null && int.TryParse(maxID.ToString(), out int maxValue)) ? maxValue + 1 : 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Otobüs ID oluşturulurken bir hata oluştu: {ex.Message}");
                return;
            }


            if (string.IsNullOrWhiteSpace(tbOtobusPlakasi.Text) || string.IsNullOrWhiteSpace(tbOtobusKapasitesi.Text) ||
                string.IsNullOrWhiteSpace(cbOtobusMarkasi.Text) || string.IsNullOrWhiteSpace(cbOtobusModeli.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            try
            {

                taOtobus.otobusEkle(Convert.ToString(tbOtobusPlakasi.Text), Convert.ToInt32(tbOtobusKapasitesi.Text),
                                  cbOtobusMarkasi.Text, cbOtobusModeli.Text);
                MessageBox.Show("Otobüs başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Otobüs eklenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
