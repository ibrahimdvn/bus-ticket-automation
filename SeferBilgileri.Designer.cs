namespace OtobusBiletOtomasyonu
{
    partial class SeferBilgileri
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
            this.dgvSeferler = new System.Windows.Forms.DataGridView();
            this.seferIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkisYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varisYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobusBiletiOtomasyonuDataSet1 = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet1();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.seferTableAdapter = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet1TableAdapters.SeferTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 98);
            this.panel1.TabIndex = 1;
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
            // dgvSeferler
            // 
            this.dgvSeferler.AutoGenerateColumns = false;
            this.dgvSeferler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seferIDDataGridViewTextBoxColumn,
            this.kalkisYeriDataGridViewTextBoxColumn,
            this.varisYeriDataGridViewTextBoxColumn,
            this.kalkisTarihiDataGridViewTextBoxColumn,
            this.varisTarihiDataGridViewTextBoxColumn});
            this.dgvSeferler.DataSource = this.seferBindingSource;
            this.dgvSeferler.Location = new System.Drawing.Point(0, 96);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.RowHeadersWidth = 51;
            this.dgvSeferler.RowTemplate.Height = 24;
            this.dgvSeferler.Size = new System.Drawing.Size(871, 356);
            this.dgvSeferler.TabIndex = 2;
            // 
            // seferIDDataGridViewTextBoxColumn
            // 
            this.seferIDDataGridViewTextBoxColumn.DataPropertyName = "SeferID";
            this.seferIDDataGridViewTextBoxColumn.HeaderText = "SeferID";
            this.seferIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seferIDDataGridViewTextBoxColumn.Name = "seferIDDataGridViewTextBoxColumn";
            this.seferIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalkisYeriDataGridViewTextBoxColumn
            // 
            this.kalkisYeriDataGridViewTextBoxColumn.DataPropertyName = "KalkisYeri";
            this.kalkisYeriDataGridViewTextBoxColumn.HeaderText = "KalkisYeri";
            this.kalkisYeriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalkisYeriDataGridViewTextBoxColumn.Name = "kalkisYeriDataGridViewTextBoxColumn";
            // 
            // varisYeriDataGridViewTextBoxColumn
            // 
            this.varisYeriDataGridViewTextBoxColumn.DataPropertyName = "VarisYeri";
            this.varisYeriDataGridViewTextBoxColumn.HeaderText = "VarisYeri";
            this.varisYeriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varisYeriDataGridViewTextBoxColumn.Name = "varisYeriDataGridViewTextBoxColumn";
            // 
            // kalkisTarihiDataGridViewTextBoxColumn
            // 
            this.kalkisTarihiDataGridViewTextBoxColumn.DataPropertyName = "KalkisTarihi";
            this.kalkisTarihiDataGridViewTextBoxColumn.HeaderText = "KalkisTarihi";
            this.kalkisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalkisTarihiDataGridViewTextBoxColumn.Name = "kalkisTarihiDataGridViewTextBoxColumn";
            // 
            // varisTarihiDataGridViewTextBoxColumn
            // 
            this.varisTarihiDataGridViewTextBoxColumn.DataPropertyName = "VarisTarihi";
            this.varisTarihiDataGridViewTextBoxColumn.HeaderText = "VarisTarihi";
            this.varisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varisTarihiDataGridViewTextBoxColumn.Name = "varisTarihiDataGridViewTextBoxColumn";
            // 
            // seferBindingSource
            // 
            this.seferBindingSource.DataMember = "Sefer";
            this.seferBindingSource.DataSource = this.otobusBiletiOtomasyonuDataSet1;
            // 
            // otobusBiletiOtomasyonuDataSet1
            // 
            this.otobusBiletiOtomasyonuDataSet1.DataSetName = "OtobusBiletiOtomasyonuDataSet1";
            this.otobusBiletiOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(742, 481);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 45);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(603, 481);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(118, 45);
            this.btnOnayla.TabIndex = 8;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // seferTableAdapter
            // 
            this.seferTableAdapter.ClearBeforeFill = true;
            // 
            // SeferBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvSeferler);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeferBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer Bilgileri";
            this.Load += new System.EventHandler(this.SeferBilgileri_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvSeferler;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnayla;
        private OtobusBiletiOtomasyonuDataSet1 otobusBiletiOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource seferBindingSource;
        private OtobusBiletiOtomasyonuDataSet1TableAdapters.SeferTableAdapter seferTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkisYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisTarihiDataGridViewTextBoxColumn;
    }
}