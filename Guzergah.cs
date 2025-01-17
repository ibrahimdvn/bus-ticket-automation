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
    public partial class Guzergah : Form
    {
        public Guzergah()
        {
            InitializeComponent();
        }

        DSOtobusBiletOtomasyonuTableAdapters.GuzergahTableAdapter taGuzergah = new DSOtobusBiletOtomasyonuTableAdapters.GuzergahTableAdapter();

        private void Guzergah_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otobusBiletiOtomasyonuDataSet4.Guzergah' table. You can move, or remove it, as needed.
            this.guzergahTableAdapter.Fill(this.otobusBiletiOtomasyonuDataSet4.Guzergah);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dgvGuzergah.DataSource = taGuzergah.GetGuzergah();
            GuzergahEkle frm = new GuzergahEkle();
            frm.Show();
            dgvGuzergah.DataSource = taGuzergah.GetGuzergah();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GuzergahGuncelle frmSil = new GuzergahGuncelle();
            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvGuzergah.CurrentRow;

            frmSil.lblGuzergahID.Text = secilisatir.Cells[0].Value.ToString();
            frmSil.tbBaslangicSehir.Text = secilisatir.Cells[1].Value.ToString();
            frmSil.tbBitisSehir.Text = secilisatir.Cells[2].Value.ToString();
            frmSil.tbMesafe.Text = secilisatir.Cells[3].Value.ToString();
            frmSil.tbTahminiSure.Text = secilisatir.Cells[4].Value.ToString();
            frmSil.ShowDialog();

            dgvGuzergah.DataSource = taGuzergah.GetGuzergah();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            GuzergahSil frmSil = new GuzergahSil();
            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvGuzergah.CurrentRow;

            frmSil.lblGuzergahID.Text = secilisatir.Cells[0].Value.ToString();
            frmSil.tbBaslangicSehir.Text = secilisatir.Cells[1].Value.ToString();
            frmSil.tbBitisSehir.Text = secilisatir.Cells[2].Value.ToString();
            frmSil.tbMesafe.Text = secilisatir.Cells[3].Value.ToString();
            frmSil.tbTahminiSure.Text = secilisatir.Cells[4].Value.ToString();
            frmSil.ShowDialog();

            dgvGuzergah.DataSource = taGuzergah.GetGuzergah();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler onaylanmıştır. Manuel olarak Bilet oluşturabilirsiniz.");
        }
    }
}
