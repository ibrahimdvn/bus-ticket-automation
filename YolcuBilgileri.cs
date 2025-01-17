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
    public partial class YolcuBilgileri : Form
    {
        public YolcuBilgileri()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.YolcuTableAdapter taYolcu = new DSOtobusBiletOtomasyonuTableAdapters.YolcuTableAdapter();

        private void YolcuBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otobusBiletiOtomasyonuDataSet.Yolcu' table. You can move, or remove it, as needed.
            this.yolcuTableAdapter.Fill(this.otobusBiletiOtomasyonuDataSet.Yolcu);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            YolcuEkle frm = new YolcuEkle();
            frm.Show();
            dgvYolcular.DataSource = taYolcu.GetYolcu();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            YolcuGuncelle frm = new YolcuGuncelle();
            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvYolcular.CurrentRow;

            frm.lblYolcuID.Text = secilisatir.Cells[0].Value.ToString();
            frm.tbYolcuTC.Text = secilisatir.Cells[1].Value.ToString();
            frm.tbYolcuAdi.Text = secilisatir.Cells[2].Value.ToString();
            frm.tbYolcuSoyadi.Text = secilisatir.Cells[3].Value.ToString();
            frm.tbYolcuYasi.Text = secilisatir.Cells[4].Value.ToString();
            frm.cbYolcuCinsiyeti.Text = secilisatir.Cells[5].Value.ToString();
            frm.ShowDialog();

            dgvYolcular.DataSource = taYolcu.GetYolcu();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            YolcuSil frmSil = new YolcuSil();
            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvYolcular.CurrentRow;

            frmSil.lblYolcuID.Text = secilisatir.Cells[0].Value.ToString();
            frmSil.tbYolcuTC.Text = secilisatir.Cells[1].Value.ToString();
            frmSil.tbYolcuAdi.Text = secilisatir.Cells[2].Value.ToString();
            frmSil.tbYolcuSoyadi.Text = secilisatir.Cells[3].Value.ToString();
            frmSil.ShowDialog();

            dgvYolcular.DataSource = taYolcu.GetYolcu();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler onaylanmıştır. Manuel olarak Bilet oluşturabilirsiniz.");
        }
    }
}
