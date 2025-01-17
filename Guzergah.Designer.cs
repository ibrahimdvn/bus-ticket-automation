namespace OtobusBiletOtomasyonu
{
    partial class Guzergah
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
            this.dgvGuzergah = new System.Windows.Forms.DataGridView();
            this.guzergahIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesafeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahminiSureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guzergahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobusBiletiOtomasyonuDataSet4 = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet4();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.guzergahTableAdapter = new OtobusBiletOtomasyonu.OtobusBiletiOtomasyonuDataSet4TableAdapters.GuzergahTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuzergah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guzergahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Location = new System.Drawing.Point(1, 3);
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
            // dgvGuzergah
            // 
            this.dgvGuzergah.AutoGenerateColumns = false;
            this.dgvGuzergah.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuzergah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuzergah.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guzergahIDDataGridViewTextBoxColumn,
            this.baslangicSehirDataGridViewTextBoxColumn,
            this.bitisSehirDataGridViewTextBoxColumn,
            this.mesafeDataGridViewTextBoxColumn,
            this.tahminiSureDataGridViewTextBoxColumn});
            this.dgvGuzergah.DataSource = this.guzergahBindingSource;
            this.dgvGuzergah.Location = new System.Drawing.Point(1, 98);
            this.dgvGuzergah.Name = "dgvGuzergah";
            this.dgvGuzergah.RowHeadersWidth = 51;
            this.dgvGuzergah.RowTemplate.Height = 24;
            this.dgvGuzergah.Size = new System.Drawing.Size(871, 349);
            this.dgvGuzergah.TabIndex = 4;
            // 
            // guzergahIDDataGridViewTextBoxColumn
            // 
            this.guzergahIDDataGridViewTextBoxColumn.DataPropertyName = "GuzergahID";
            this.guzergahIDDataGridViewTextBoxColumn.HeaderText = "GuzergahID";
            this.guzergahIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guzergahIDDataGridViewTextBoxColumn.Name = "guzergahIDDataGridViewTextBoxColumn";
            this.guzergahIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baslangicSehirDataGridViewTextBoxColumn
            // 
            this.baslangicSehirDataGridViewTextBoxColumn.DataPropertyName = "BaslangicSehir";
            this.baslangicSehirDataGridViewTextBoxColumn.HeaderText = "BaslangicSehir";
            this.baslangicSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baslangicSehirDataGridViewTextBoxColumn.Name = "baslangicSehirDataGridViewTextBoxColumn";
            // 
            // bitisSehirDataGridViewTextBoxColumn
            // 
            this.bitisSehirDataGridViewTextBoxColumn.DataPropertyName = "BitisSehir";
            this.bitisSehirDataGridViewTextBoxColumn.HeaderText = "BitisSehir";
            this.bitisSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bitisSehirDataGridViewTextBoxColumn.Name = "bitisSehirDataGridViewTextBoxColumn";
            // 
            // mesafeDataGridViewTextBoxColumn
            // 
            this.mesafeDataGridViewTextBoxColumn.DataPropertyName = "Mesafe";
            this.mesafeDataGridViewTextBoxColumn.HeaderText = "Mesafe";
            this.mesafeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesafeDataGridViewTextBoxColumn.Name = "mesafeDataGridViewTextBoxColumn";
            // 
            // tahminiSureDataGridViewTextBoxColumn
            // 
            this.tahminiSureDataGridViewTextBoxColumn.DataPropertyName = "TahminiSure";
            this.tahminiSureDataGridViewTextBoxColumn.HeaderText = "TahminiSure";
            this.tahminiSureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tahminiSureDataGridViewTextBoxColumn.Name = "tahminiSureDataGridViewTextBoxColumn";
            // 
            // guzergahBindingSource
            // 
            this.guzergahBindingSource.DataMember = "Guzergah";
            this.guzergahBindingSource.DataSource = this.otobusBiletiOtomasyonuDataSet4;
            // 
            // otobusBiletiOtomasyonuDataSet4
            // 
            this.otobusBiletiOtomasyonuDataSet4.DataSetName = "OtobusBiletiOtomasyonuDataSet4";
            this.otobusBiletiOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(742, 476);
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
            this.btnOnayla.Location = new System.Drawing.Point(603, 476);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(118, 45);
            this.btnOnayla.TabIndex = 12;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // guzergahTableAdapter
            // 
            this.guzergahTableAdapter.ClearBeforeFill = true;
            // 
            // Guzergah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvGuzergah);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Guzergah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güzergah Bilgileri";
            this.Load += new System.EventHandler(this.Guzergah_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuzergah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guzergahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusBiletiOtomasyonuDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvGuzergah;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnayla;
        private OtobusBiletiOtomasyonuDataSet4 otobusBiletiOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource guzergahBindingSource;
        private OtobusBiletiOtomasyonuDataSet4TableAdapters.GuzergahTableAdapter guzergahTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn guzergahIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesafeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahminiSureDataGridViewTextBoxColumn;
    }
}