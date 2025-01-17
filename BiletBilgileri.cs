using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OtobusBiletOtomasyonu.DSOtobusBiletOtomasyonu;

namespace OtobusBiletOtomasyonu
{
    public partial class BiletBilgileri : Form
    {
        public BiletBilgileri()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.Bilet1TableAdapter taBilet = new DSOtobusBiletOtomasyonuTableAdapters.Bilet1TableAdapter();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BiletBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otobusBiletiOtomasyonuDataSet6.Bilet' table. You can move, or remove it, as needed.
            this.biletTableAdapter1.Fill(this.otobusBiletiOtomasyonuDataSet6.Bilet);
            // TODO: This line of code loads data into the 'otobusBiletiOtomasyonuDataSet2.Bilet' table. You can move, or remove it, as needed.
            this.biletTableAdapter.Fill(this.otobusBiletiOtomasyonuDataSet2.Bilet);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dgvBiletler.DataSource = taBilet.GetBilet();
            BiletEkle frm = new BiletEkle();
            frm.ShowDialog();

            dgvBiletler.DataSource = taBilet.GetBilet();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            BiletGuncelle frm = new BiletGuncelle();

            
            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvBiletler.CurrentRow;

            frm.lblBiletID.Text = secilisatir.Cells[0].Value.ToString();
            frm.tbYolcuAdi.Text = secilisatir.Cells[1].Value.ToString();
            frm.tbYolcuSoyadi.Text = secilisatir.Cells[2].Value.ToString();
            frm.tbHareketSaati.Text = secilisatir.Cells[3].Value.ToString();
            frm.tbVarisSaati.Text = secilisatir.Cells[4].Value.ToString();
            frm.lblSeciliKoltuk.Text = secilisatir.Cells[6].Value.ToString();
            frm.tbSure.Text = secilisatir.Cells[5].Value.ToString();
            frm.tbSatinAlmaTarihi.Text = secilisatir.Cells[7].Value.ToString();
            frm.ShowDialog();

            dgvBiletler.DataSource = taBilet.GetBilet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            BiletSil frm = new BiletSil();
            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvBiletler.CurrentRow;

            frm.lblBiletID.Text = secilisatir.Cells[0].Value.ToString();
            frm.tbYolcuAdi.Text = secilisatir.Cells[1].Value.ToString();
            frm.tbYolcuSoyadi.Text = secilisatir.Cells[2].Value.ToString();
            frm.ShowDialog();

            dgvBiletler.DataSource = taBilet.GetBilet();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilet başarıyla kaydedilmiştir.");
        }
    }
}
