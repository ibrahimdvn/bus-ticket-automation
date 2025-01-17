namespace OtobusBiletOtomasyonu
{
    partial class BiletBilgileri
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvBiletler = new System.Windows.Forms.DataGridView();
            this.biletIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varisSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltukNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satinAlmaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobusBiletiOtomasyonuDataSet6 = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet6();
            this.otobusBiletiOtomasyonuDataSet2 = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet2();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.biletTableAdapter = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet2TableAdapters.BiletTableAdapter();
            this.biletTableAdapter1 = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet6TableAdapters.BiletTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiletler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 98);
            this.panel1.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(289, 27);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(118, 45);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(153, 27);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(118, 45);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(20, 27);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 45);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvBiletler
            // 
            this.dgvBiletler.AutoGenerateColumns = false;
            this.dgvBiletler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBiletler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiletler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biletIDDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.hareketSaatiDataGridViewTextBoxColumn,
            this.varisSaatiDataGridViewTextBoxColumn,
            this.sureDataGridViewTextBoxColumn,
            this.koltukNoDataGridViewTextBoxColumn,
            this.satinAlmaTarihiDataGridViewTextBoxColumn});
            this.dgvBiletler.DataSource = this.biletBindingSource;
            this.dgvBiletler.Location = new System.Drawing.Point(2, 95);
            this.dgvBiletler.Name = "dgvBiletler";
            this.dgvBiletler.RowHeadersWidth = 51;
            this.dgvBiletler.RowTemplate.Height = 24;
            this.dgvBiletler.Size = new System.Drawing.Size(883, 368);
            this.dgvBiletler.TabIndex = 3;
            // 
            // biletIDDataGridViewTextBoxColumn
            // 
            this.biletIDDataGridViewTextBoxColumn.DataPropertyName = "BiletID";
            this.biletIDDataGridViewTextBoxColumn.HeaderText = "BiletID";
            this.biletIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biletIDDataGridViewTextBoxColumn.Name = "biletIDDataGridViewTextBoxColumn";
            this.biletIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "Adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "Adi";
            this.adiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "Soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "Soyadi";
            this.soyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            // 
            // hareketSaatiDataGridViewTextBoxColumn
            // 
            this.hareketSaatiDataGridViewTextBoxColumn.DataPropertyName = "HareketSaati";
            this.hareketSaatiDataGridViewTextBoxColumn.HeaderText = "HareketSaati";
            this.hareketSaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hareketSaatiDataGridViewTextBoxColumn.Name = "hareketSaatiDataGridViewTextBoxColumn";
            // 
            // varisSaatiDataGridViewTextBoxColumn
            // 
            this.varisSaatiDataGridViewTextBoxColumn.DataPropertyName = "VarisSaati";
            this.varisSaatiDataGridViewTextBoxColumn.HeaderText = "VarisSaati";
            this.varisSaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varisSaatiDataGridViewTextBoxColumn.Name = "varisSaatiDataGridViewTextBoxColumn";
            // 
            // sureDataGridViewTextBoxColumn
            // 
            this.sureDataGridViewTextBoxColumn.DataPropertyName = "Sure";
            this.sureDataGridViewTextBoxColumn.HeaderText = "Sure";
            this.sureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sureDataGridViewTextBoxColumn.Name = "sureDataGridViewTextBoxColumn";
            // 
            // koltukNoDataGridViewTextBoxColumn
            // 
            this.koltukNoDataGridViewTextBoxColumn.DataPropertyName = "KoltukNo";
            this.koltukNoDataGridViewTextBoxColumn.HeaderText = "KoltukNo";
            this.koltukNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.koltukNoDataGridViewTextBoxColumn.Name = "koltukNoDataGridViewTextBoxColumn";
            // 
            // satinAlmaTarihiDataGridViewTextBoxColumn
            // 
            this.satinAlmaTarihiDataGridViewTextBoxColumn.DataPropertyName = "SatinAlmaTarihi";
            this.satinAlmaTarihiDataGridViewTextBoxColumn.HeaderText = "SatinAlmaTarihi";
            this.satinAlmaTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satinAlmaTarihiDataGridViewTextBoxColumn.Name = "satinAlmaTarihiDataGridViewTextBoxColumn";
            // 
            // biletBindingSource
            // 
            this.biletBindingSource.DataMember = "Bilet";
            this.biletBindingSource.DataSource = this.otobusBiletiOtomasyonuDataSet6;
            // 
            // otobusBiletiOtomasyonuDataSet6
            // 
            this.otobusBiletiOtomasyonuDataSet6.DataSetName = "OtobusBiletiOtomasyonuDataSet6";
            this.otobusBiletiOtomasyonuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otobusBiletiOtomasyonuDataSet2
            // 
            this.otobusBiletiOtomasyonuDataSet2.DataSetName = "OtobusBiletiOtomasyonuDataSet2";
            this.otobusBiletiOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(744, 485);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 45);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(605, 485);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(118, 45);
            this.btnOnayla.TabIndex = 10;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // biletTableAdapter
            // 
            this.biletTableAdapter.ClearBeforeFill = true;
            // 
            // biletTableAdapter1
            // 
            this.biletTableAdapter1.ClearBeforeFill = true;
            // 
            // BiletBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 553);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvBiletler);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BiletBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet Bilgileri";
            this.Load += new System.EventHandler(this.BiletBilgileri_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiletler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnayla;
        private OtobusBiletiOtomasyonuDataSet2 otobusBiletiOtomasyonuDataSet2;
        private OtobusBiletiOtomasyonuDataSet2TableAdapters.BiletTableAdapter biletTableAdapter;
        private OtobusBiletiOtomasyonuDataSet6 otobusBiletiOtomasyonuDataSet6;
        private System.Windows.Forms.BindingSource biletBindingSource;
        private OtobusBiletiOtomasyonuDataSet6TableAdapters.BiletTableAdapter biletTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltukNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satinAlmaTarihiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvBiletler;
    }
}