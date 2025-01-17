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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void yolcuBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YolcuBilgileri frm = new YolcuBilgileri();
            frm.ShowDialog();
        }

        private void seferBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeferBilgileri frm = new SeferBilgileri();
            frm.ShowDialog();
        }

        private void biletBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletBilgileri frm = new BiletBilgileri();
            frm.ShowDialog();
        }

        private void otobüslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otobusler frm = new Otobusler();
            frm.ShowDialog();
        }

        private void güzergahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guzergah frm = new Guzergah();
            frm.ShowDialog();
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odeme frm = new Odeme();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
