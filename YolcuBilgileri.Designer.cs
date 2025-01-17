namespace OtobusBiletOtomasyonu
{
    partial class YolcuBilgileri
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
            this.dgvYolcular = new System.Windows.Forms.DataGridView();
            this.yolcuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yolcuTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yolcuAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yolcuSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yolcuYasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yolcuCinsiyetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yolcuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobusBiletiOtomasyonuDataSet = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet();
            this.yolcuTableAdapter = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSetTableAdapters.YolcuTableAdapter();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYolcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 98);
            this.panel1.TabIndex = 0;
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
            // dgvYolcular
            // 
            this.dgvYolcular.AutoGenerateColumns = false;
            this.dgvYolcular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYolcular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYolcular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yolcuIDDataGridViewTextBoxColumn,
            this.yolcuTCDataGridViewTextBoxColumn,
            this.yolcuAdiDataGridViewTextBoxColumn,
            this.yolcuSoyadiDataGridViewTextBoxColumn,
            this.yolcuYasiDataGridViewTextBoxColumn,
            this.yolcuCinsiyetiDataGridViewTextBoxColumn});
            this.dgvYolcular.DataSource = this.yolcuBindingSource;
            this.dgvYolcular.Location = new System.Drawing.Point(3, 98);
            this.dgvYolcular.Name = "dgvYolcular";
            this.dgvYolcular.RowHeadersWidth = 51;
            this.dgvYolcular.RowTemplate.Height = 24;
            this.dgvYolcular.Size = new System.Drawing.Size(868, 347);
            this.dgvYolcular.TabIndex = 1;
            // 
            // yolcuIDDataGridViewTextBoxColumn
            // 
            this.yolcuIDDataGridViewTextBoxColumn.DataPropertyName = "YolcuID";
            this.yolcuIDDataGridViewTextBoxColumn.HeaderText = "YolcuID";
            this.yolcuIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yolcuIDDataGridViewTextBoxColumn.Name = "yolcuIDDataGridViewTextBoxColumn";
            this.yolcuIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yolcuTCDataGridViewTextBoxColumn
            // 
            this.yolcuTCDataGridViewTextBoxColumn.DataPropertyName = "YolcuTC";
            this.yolcuTCDataGridViewTextBoxColumn.HeaderText = "YolcuTC";
            this.yolcuTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yolcuTCDataGridViewTextBoxColumn.Name = "yolcuTCDataGridViewTextBoxColumn";
            // 
            // yolcuAdiDataGridViewTextBoxColumn
            // 
            this.yolcuAdiDataGridViewTextBoxColumn.DataPropertyName = "YolcuAdi";
            this.yolcuAdiDataGridViewTextBoxColumn.HeaderText = "YolcuAdi";
            this.yolcuAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yolcuAdiDataGridViewTextBoxColumn.Name = "yolcuAdiDataGridViewTextBoxColumn";
            // 
            // yolcuSoyadiDataGridViewTextBoxColumn
            // 
            this.yolcuSoyadiDataGridViewTextBoxColumn.DataPropertyName = "YolcuSoyadi";
            this.yolcuSoyadiDataGridViewTextBoxColumn.HeaderText = "YolcuSoyadi";
            this.yolcuSoyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yolcuSoyadiDataGridViewTextBoxColumn.Name = "yolcuSoyadiDataGridViewTextBoxColumn";
            // 
            // yolcuYasiDataGridViewTextBoxColumn
            // 
            this.yolcuYasiDataGridViewTextBoxColumn.DataPropertyName = "YolcuYasi";
            this.yolcuYasiDataGridViewTextBoxColumn.HeaderText = "YolcuYasi";
            this.yolcuYasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yolcuYasiDataGridViewTextBoxColumn.Name = "yolcuYasiDataGridViewTextBoxColumn";
            // 
            // yolcuCinsiyetiDataGridViewTextBoxColumn
            // 
            this.yolcuCinsiyetiDataGridViewTextBoxColumn.DataPropertyName = "YolcuCinsiyeti";
            this.yolcuCinsiyetiDataGridViewTextBoxColumn.HeaderText = "YolcuCinsiyeti";
            this.yolcuCinsiyetiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yolcuCinsiyetiDataGridViewTextBoxColumn.Name = "yolcuCinsiyetiDataGridViewTextBoxColumn";
            // 
            // yolcuBindingSource
            // 
            this.yolcuBindingSource.DataMember = "Yolcu";
            this.yolcuBindingSource.DataSource = this.otobusBiletiOtomasyonuDataSet;
            // 
            // otobusBiletiOtomasyonuDataSet
            // 
            this.otobusBiletiOtomasyonuDataSet.DataSetName = "OtobusBiletiOtomasyonuDataSet";
            this.otobusBiletiOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yolcuTableAdapter
            // 
            this.yolcuTableAdapter.ClearBeforeFill = true;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(603, 479);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(118, 45);
            this.btnOnayla.TabIndex = 6;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(742, 479);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 45);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // YolcuBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvYolcular);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YolcuBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yolcu Bilgileri";
            this.Load += new System.EventHandler(this.YolcuBilgileri_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYolcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private OtobusBiletiOtomasyonuDataSet otobusBiletiOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource yolcuBindingSource;
        private OtobusBiletiOtomasyonuDataSetTableAdapters.YolcuTableAdapter yolcuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yolcuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yolcuTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yolcuAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yolcuSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yolcuYasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yolcuCinsiyetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnIptal;
        public System.Windows.Forms.DataGridView dgvYolcular;
    }
}