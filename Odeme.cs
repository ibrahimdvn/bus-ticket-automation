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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.OdemeTableAdapter taOdeme = new DSOtobusBiletOtomasyonuTableAdapters.OdemeTableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otobusBiletiOtomasyonuDataSet5.Odeme' table. You can move, or remove it, as needed.
            this.odemeTableAdapter.Fill(this.otobusBiletiOtomasyonuDataSet5.Odeme);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            OdemeEkle frm = new OdemeEkle();
            frm.Show();

            dgvOdeme.DataSource = taOdeme.GetOdeme();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OdemeGuncelle frm = new OdemeGuncelle();


            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvOdeme.CurrentRow;

            frm.lblOdemeID.Text = secilisatir.Cells[0].Value.ToString();
            frm.tbYolcuAdiSoyadi.Text = secilisatir.Cells[1].Value.ToString();
            frm.tbToplamTutar.Text = secilisatir.Cells[2].Value.ToString();
            frm.tbOdemeTarihi.Text = secilisatir.Cells[3].Value.ToString();
            frm.cbOdemeTipi.Text = secilisatir.Cells[4].Value.ToString();
            frm.ShowDialog();

            dgvOdeme.DataSource = taOdeme.GetOdeme();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            {
                try
                {

                    if (dgvOdeme.SelectedRows.Count > 0)
                    {

                        int odemeID = Convert.ToInt32(dgvOdeme.SelectedRows[0].Cells["OdemeID"].Value);

                 
                        DialogResult result = MessageBox.Show("Bu ödemeyi silmek istediğinizden emin misiniz?",
                                                              "Silme Onayı",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                         
                            OdemeTableAdapter odemeAdapter = new OdemeTableAdapter();


                            
                            MessageBox.Show("Ödeme başarıyla silindi!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek için bir satır seçin.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler onaylanmıştır. Manuel olarak Bilet oluşturabilirsiniz.");
        }
    }
}
