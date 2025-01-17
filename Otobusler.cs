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
    public partial class Otobusler : Form
    {
        public Otobusler()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DSOtobusBiletOtomasyonuTableAdapters.OtobusTableAdapter taOtobus = new DSOtobusBiletOtomasyonuTableAdapters.OtobusTableAdapter();

        private void Otobusler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otobusBiletiOtomasyonuDataSet3.Otobus' table. You can move, or remove it, as needed.
            this.otobusTableAdapter.Fill(this.otobusBiletiOtomasyonuDataSet3.Otobus);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dgvOtobusler.DataSource = taOtobus.GetOtobus();
            OtobusEkle frm = new OtobusEkle();
            frm.ShowDialog();
            dgvOtobusler.DataSource = taOtobus.GetOtobus();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OtobusGuncelle frm = new OtobusGuncelle();


            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvOtobusler.CurrentRow;

            frm.lblOtobusID.Text = secilisatir.Cells[0].Value.ToString();
            frm.tbOtobusPlakasi.Text = secilisatir.Cells[1].Value.ToString();
            frm.cbOtobusKapasitesi.Text = secilisatir.Cells[2].Value.ToString();
            frm.cbOtobusMarkasi.Text = secilisatir.Cells[3].Value.ToString();
            frm.cbOtobusModeli.Text = secilisatir.Cells[4].Value.ToString();
            frm.ShowDialog();

            dgvOtobusler.DataSource = taOtobus.GetOtobus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OtobusSil frmSil = new OtobusSil();
            DataGridViewRow secilisatir = new DataGridViewRow();
            secilisatir = dgvOtobusler.CurrentRow;

            frmSil.lblOtobusID.Text = secilisatir.Cells[0].Value.ToString();
            frmSil.tbOtobusPlakasi.Text = secilisatir.Cells[1].Value.ToString();
            frmSil.cbOtobusKapasitesi.Text = secilisatir.Cells[2].Value.ToString();
            frmSil.cbOtobusMarkasi.Text = secilisatir.Cells[3].Value.ToString();
            frmSil.cbOtobusModeli.Text = secilisatir.Cells[4].Value.ToString();
            frmSil.ShowDialog();

            dgvOtobusler.DataSource = taOtobus.GetOtobus();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler onaylanmıştır. Manuel olarak Bilet oluşturabilirsiniz.");
        }
    }
}
