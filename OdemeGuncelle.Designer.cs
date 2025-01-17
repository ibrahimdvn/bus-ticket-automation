namespace OtobusBiletOtomasyonu
{
    partial class OdemeGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbOdemeTarihi = new System.Windows.Forms.TextBox();
            this.lblOdemeID = new System.Windows.Forms.Label();
            this.lblOdemeNo = new System.Windows.Forms.Label();
            this.cbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbToplamTutar = new System.Windows.Forms.TextBox();
            this.tbYolcuAdiSoyadi = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbOdemeTarihi);
            this.groupBox1.Controls.Add(this.lblOdemeID);
            this.groupBox1.Controls.Add(this.lblOdemeNo);
            this.groupBox1.Controls.Add(this.cbOdemeTipi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbToplamTutar);
            this.groupBox1.Controls.Add(this.tbYolcuAdiSoyadi);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 276);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Güncelle";
            // 
            // tbOdemeTarihi
            // 
            this.tbOdemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbOdemeTarihi.Location = new System.Drawing.Point(187, 170);
            this.tbOdemeTarihi.Name = "tbOdemeTarihi";
            this.tbOdemeTarihi.Size = new System.Drawing.Size(203, 28);
            this.tbOdemeTarihi.TabIndex = 33;
            // 
            // lblOdemeID
            // 
            this.lblOdemeID.AutoSize = true;
            this.lblOdemeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeID.Location = new System.Drawing.Point(147, 36);
            this.lblOdemeID.Name = "lblOdemeID";
            this.lblOdemeID.Size = new System.Drawing.Size(32, 24);
            this.lblOdemeID.TabIndex = 32;
            this.lblOdemeID.Text = "52";
            // 
            // lblOdemeNo
            // 
            this.lblOdemeNo.AutoSize = true;
            this.lblOdemeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeNo.Location = new System.Drawing.Point(23, 36);
            this.lblOdemeNo.Name = "lblOdemeNo";
            this.lblOdemeNo.Size = new System.Drawing.Size(118, 24);
            this.lblOdemeNo.TabIndex = 31;
            this.lblOdemeNo.Text = "Ödeme No:";
            // 
            // cbOdemeTipi
            // 
            this.cbOdemeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOdemeTipi.FormattingEnabled = true;
            this.cbOdemeTipi.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.cbOdemeTipi.Location = new System.Drawing.Point(187, 211);
            this.cbOdemeTipi.Name = "cbOdemeTipi";
            this.cbOdemeTipi.Size = new System.Drawing.Size(203, 30);
            this.cbOdemeTipi.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Yolcu Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Toplam Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ödeme Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ödeme Tipi:";
            // 
            // tbToplamTutar
            // 
            this.tbToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbToplamTutar.Location = new System.Drawing.Point(187, 124);
            this.tbToplamTutar.Name = "tbToplamTutar";
            this.tbToplamTutar.Size = new System.Drawing.Size(203, 28);
            this.tbToplamTutar.TabIndex = 16;
            // 
            // tbYolcuAdiSoyadi
            // 
            this.tbYolcuAdiSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYolcuAdiSoyadi.Location = new System.Drawing.Point(187, 81);
            this.tbYolcuAdiSoyadi.Name = "tbYolcuAdiSoyadi";
            this.tbYolcuAdiSoyadi.Size = new System.Drawing.Size(203, 28);
            this.tbYolcuAdiSoyadi.TabIndex = 15;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(654, 313);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 45);
            this.btnIptal.TabIndex = 33;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(515, 313);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(118, 45);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // OdemeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdemeGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Güncelleme Sayfası";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbToplamTutar;
        public System.Windows.Forms.TextBox tbYolcuAdiSoyadi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Label lblOdemeID;
        public System.Windows.Forms.Label lblOdemeNo;
        public System.Windows.Forms.ComboBox cbOdemeTipi;
        public System.Windows.Forms.TextBox tbOdemeTarihi;
    }
}