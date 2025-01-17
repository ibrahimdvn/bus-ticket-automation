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
    public partial class SeferBilgileri : Form
    {
        public SeferBilgileri()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.SeferTableAdapter taSefer = new DSOtobusBiletOtomasyonuTableAdapters.SeferTableAdapter();

        private void SeferBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otobusBiletiOtomasyonuDataSet1.Sefer' table. You can move, or remove it, as needed.
            this.seferTableAdapter.Fill(this.otobusBiletiOtomasyonuDataSet1.Sefer);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dgvSeferler.DataSource = taSefer.GetSefer();
            SeferEkle frm = new SeferEkle();
            frm.Show();
            dgvSeferler.DataSource = taSefer.GetSefer();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SeferGuncelle frm = new SeferGuncelle();


            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvSeferler.CurrentRow;

            frm.lblSeferID.Text = secilisatir.Cells[0].Value.ToString();
            frm.tbKalkisYeri.Text = secilisatir.Cells[1].Value.ToString();
            frm.tbVarisYeri.Text = secilisatir.Cells[2].Value.ToString();
            frm.dtpKalkisTarihi.Text = secilisatir.Cells[3].Value.ToString();
            frm.dtpVarisTarihi.Text = secilisatir.Cells[4].Value.ToString();
            frm.ShowDialog();

            dgvSeferler.DataSource = taSefer.GetSefer();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SeferSil frmSil = new SeferSil();
            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvSeferler.CurrentRow;

            frmSil.lblSeferID.Text = secilisatir.Cells[0].Value.ToString();
            frmSil.tbKalkisYeri.Text = secilisatir.Cells[1].Value.ToString();
            frmSil.tbVarisYeri.Text = secilisatir.Cells[2].Value.ToString();
            frmSil.dtpKalkisTarihi.Text = secilisatir.Cells[3].Value.ToString();
            frmSil.dtpVarisTarihi.Text = secilisatir.Cells[4].Value.ToString();
            frmSil.ShowDialog();

            dgvSeferler.DataSource = taSefer.GetSefer();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler onaylanmıştır. Manuel olarak Bilet oluşturabilirsiniz.");
        }
    }
}
