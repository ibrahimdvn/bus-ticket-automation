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
    public partial class GuzergahEkle : Form
    {
        public GuzergahEkle()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.GuzergahTableAdapter taGuzergah = new DSOtobusBiletOtomasyonuTableAdapters.GuzergahTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int yeniGuzergahID;

            try
            {

                object maxID = taGuzergah.GetGuzergah();
                yeniGuzergahID = (maxID != null && int.TryParse(maxID.ToString(), out int maxValue)) ? maxValue + 1 : 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güzergah ID oluşturulurken bir hata oluştu: {ex.Message}");
                return;
            }

            string baslangicSehir = tbBaslangicSehir.Text;
            string bitisSehir = tbBitisSehir.Text;
            string mesafe = tbMesafe.Text;
            string tahminiSure = tbTahminiSure.Text;


            if (string.IsNullOrWhiteSpace(baslangicSehir) || string.IsNullOrWhiteSpace(bitisSehir) ||
                string.IsNullOrWhiteSpace(mesafe) || string.IsNullOrWhiteSpace(tahminiSure))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                taGuzergah.Insert(baslangicSehir, bitisSehir, mesafe, tahminiSure);

                MessageBox.Show("Güzergah başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
