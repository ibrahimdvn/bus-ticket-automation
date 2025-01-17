using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletOtomasyonu
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=RAZIEL; Initial Catalog=OtobusBiletiOtomasyonu; Integrated Security=true;");
        public static string k_adi = "";

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            conn.Open();

           

            SqlCommand cmd = new SqlCommand("Select * from yonetici where k_adi='" + tbKullaniciAdi.Text + "' and sifre='" + tbSifre.Text + "'", conn);
            SqlDataReader drs = cmd.ExecuteReader();

            

            var username = tbKullaniciAdi.Text;
            var password = tbSifre.Text;
            var errormessage = "";
            var isError = false;

            

            if (string.IsNullOrEmpty(username))
            {
                errormessage += "Kullanıcı adını boş geçemezsiniz!\r\n";
                isError = true;
            }

            if (string.IsNullOrEmpty(password))
            {
                errormessage += "Şifreyi boş geçemezsiniz!\r\n";
                isError = true;
            }

            if (isError)
            {
                MessageBox.Show(errormessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            if (drs.Read())
            {
                k_adi = drs["k_adi"].ToString();
                AnaForm frm = new AnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı veya şifrenizi hatalı girdiniz.");
            }
            conn.Close();
        }

        private void btnGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
