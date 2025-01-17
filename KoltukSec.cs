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
using static OtobusBiletOtomasyonu.DSOtobusBiletOtomasyonu;

namespace OtobusBiletOtomasyonu
{
    public partial class KoltukSec : Form
    {
        public KoltukSec()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         public string selectedSeat;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            selectedSeat = string.Empty;
           

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    selectedSeat = control.Text;
                    break;
                }
            }
            this.Close();

            //if (!string.IsNullOrEmpty(selectedSeat))
            //{

            //    dgvBiletler.Rows.Add(selectedSeat);


            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        string query = "INSERT INTO Biletler (KoltukNo) VALUES (@KoltukNo)";
            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@KoltukNo", selectedSeat);
            //            command.ExecuteNonQuery();
            //        }
            //    }

            //    MessageBox.Show("Koltuk seçimi kaydedilmiştir.");
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen bir koltuk seçin.");
            //}

        }

        private void birinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text; 
            this.DialogResult = DialogResult.OK; 
            this.Close(); 
        }

        private void KoltukSec_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn && btn.Name.StartsWith("btnKoltuk"))
                {
                    btn.Click += KoltukSec_Load;
                }
            }
        }

        private void ikinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ucuncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dorduncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void besinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void altıncıKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yedinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void sekizinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dokuzuncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void onuncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void onbirinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void onikinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void onucuncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ondorduncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void onbesinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void onaltıncıKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void onYedinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void onsekizinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ondokuzuncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirminciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirmibirinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirmikinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirmiucuncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirmidorduncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirmibesinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirmialtıncıKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirmiyedinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirmisekizinciKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yirmidokuzuncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void otuzuncuKoltuk_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if (selectedButton == null) return;


            DialogResult result = MessageBox.Show("Bu koltuk için cinsiyet seçin:\nEvet: Erkek, Hayır: Kadın",
                                                  "Cinsiyet Seçimi",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                selectedButton.BackColor = Color.LightBlue;
                MessageBox.Show($"Koltuk {selectedButton.Text} erkek olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                selectedButton.BackColor = Color.Pink;
                MessageBox.Show($"Koltuk {selectedButton.Text} kadın olarak seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show($"Koltuk {selectedButton.Text} seçimi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Button lblSeciliKoltuk = sender as Button;
            selectedSeat = lblSeciliKoltuk.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

