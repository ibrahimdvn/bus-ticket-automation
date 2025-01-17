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
    public partial class SeferEkle : Form
    {
        public SeferEkle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.SeferTableAdapter taSefer = new DSOtobusBiletOtomasyonuTableAdapters.SeferTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int yeniSeferID;

            try
            {
                object maxID = taSefer.GetSefer();
                yeniSeferID = (maxID != null && int.TryParse(maxID.ToString(), out int maxValue)) ? maxValue + 1 : 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sefer ID oluşturulurken bir hata oluştu: {ex.Message}");
                return;
            }


            if (string.IsNullOrWhiteSpace(tbKalkisYeri.Text) || string.IsNullOrWhiteSpace(tbVarisYeri.Text) ||
                string.IsNullOrWhiteSpace(dtpKalkisTarihi.Text) || string.IsNullOrWhiteSpace(dtpVarisTarihi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            try
            {

                taSefer.SeferEkle(tbKalkisYeri.Text.Trim(), tbVarisYeri.Text.Trim(),
                                  dtpKalkisTarihi.Text.Trim(), dtpVarisTarihi.Text);
                MessageBox.Show("Sefer başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sefer eklenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
