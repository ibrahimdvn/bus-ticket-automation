namespace OtobusBiletOtomasyonu
{
    partial class Odeme
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
            this.dgvOdeme = new System.Windows.Forms.DataGridView();
            this.odemeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yolcuAdiSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobusBiletiOtomasyonuDataSet5 = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet5();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.odemeTableAdapter = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet5TableAdapters.OdemeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 98);
            this.panel1.TabIndex = 3;
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
            // dgvOdeme
            // 
            this.dgvOdeme.AutoGenerateColumns = false;
            this.dgvOdeme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdeme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeIDDataGridViewTextBoxColumn,
            this.yolcuAdiSoyadiDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.odemeTarihiDataGridViewTextBoxColumn,
            this.odemeTipiDataGridViewTextBoxColumn});
            this.dgvOdeme.DataSource = this.odemeBindingSource;
            this.dgvOdeme.Location = new System.Drawing.Point(2, 94);
            this.dgvOdeme.Name = "dgvOdeme";
            this.dgvOdeme.RowHeadersWidth = 51;
            this.dgvOdeme.RowTemplate.Height = 24;
            this.dgvOdeme.Size = new System.Drawing.Size(868, 368);
            this.dgvOdeme.TabIndex = 4;
            // 
            // odemeIDDataGridViewTextBoxColumn
            // 
            this.odemeIDDataGridViewTextBoxColumn.DataPropertyName = "OdemeID";
            this.odemeIDDataGridViewTextBoxColumn.HeaderText = "OdemeID";
            this.odemeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeIDDataGridViewTextBoxColumn.Name = "odemeIDDataGridViewTextBoxColumn";
            this.odemeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yolcuAdiSoyadiDataGridViewTextBoxColumn
            // 
            this.yolcuAdiSoyadiDataGridViewTextBoxColumn.DataPropertyName = "YolcuAdiSoyadi";
            this.yolcuAdiSoyadiDataGridViewTextBoxColumn.HeaderText = "YolcuAdiSoyadi";
            this.yolcuAdiSoyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yolcuAdiSoyadiDataGridViewTextBoxColumn.Name = "yolcuAdiSoyadiDataGridViewTextBoxColumn";
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            // 
            // odemeTarihiDataGridViewTextBoxColumn
            // 
            this.odemeTarihiDataGridViewTextBoxColumn.DataPropertyName = "OdemeTarihi";
            this.odemeTarihiDataGridViewTextBoxColumn.HeaderText = "OdemeTarihi";
            this.odemeTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeTarihiDataGridViewTextBoxColumn.Name = "odemeTarihiDataGridViewTextBoxColumn";
            // 
            // odemeTipiDataGridViewTextBoxColumn
            // 
            this.odemeTipiDataGridViewTextBoxColumn.DataPropertyName = "OdemeTipi";
            this.odemeTipiDataGridViewTextBoxColumn.HeaderText = "OdemeTipi";
            this.odemeTipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeTipiDataGridViewTextBoxColumn.Name = "odemeTipiDataGridViewTextBoxColumn";
            // 
            // odemeBindingSource
            // 
            this.odemeBindingSource.DataMember = "Odeme";
            this.odemeBindingSource.DataSource = this.otobusBiletiOtomasyonuDataSet5;
            // 
            // otobusBiletiOtomasyonuDataSet5
            // 
            this.otobusBiletiOtomasyonuDataSet5.DataSetName = "OtobusBiletiOtomasyonuDataSet5";
            this.otobusBiletiOtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(745, 487);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 45);
            this.btnIptal.TabIndex = 13;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(606, 487);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(118, 45);
            this.btnOnayla.TabIndex = 12;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // odemeTableAdapter
            // 
            this.odemeTableAdapter.ClearBeforeFill = true;
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvOdeme);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Bilgileri";
            this.Load += new System.EventHandler(this.Odeme_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnayla;
        private OtobusBiletiOtomasyonuDataSet5 otobusBiletiOtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource odemeBindingSource;
        private OtobusBiletiOtomasyonuDataSet5TableAdapters.OdemeTableAdapter odemeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yolcuAdiSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTipiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvOdeme;
    }
}