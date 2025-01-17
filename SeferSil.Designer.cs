namespace OtobusBiletOtomasyonu
{
    partial class SeferSil
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
            this.dtpVarisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpKalkisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSeferID = new System.Windows.Forms.Label();
            this.lblSeferNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVarisYeri = new System.Windows.Forms.TextBox();
            this.tbKalkisYeri = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpVarisTarihi);
            this.groupBox1.Controls.Add(this.dtpKalkisTarihi);
            this.groupBox1.Controls.Add(this.lblSeferID);
            this.groupBox1.Controls.Add(this.lblSeferNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbVarisYeri);
            this.groupBox1.Controls.Add(this.tbKalkisYeri);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 279);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Sil";
            // 
            // dtpVarisTarihi
            // 
            this.dtpVarisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVarisTarihi.Location = new System.Drawing.Point(176, 214);
            this.dtpVarisTarihi.Name = "dtpVarisTarihi";
            this.dtpVarisTarihi.Size = new System.Drawing.Size(142, 22);
            this.dtpVarisTarihi.TabIndex = 28;
            // 
            // dtpKalkisTarihi
            // 
            this.dtpKalkisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKalkisTarihi.Location = new System.Drawing.Point(176, 169);
            this.dtpKalkisTarihi.Name = "dtpKalkisTarihi";
            this.dtpKalkisTarihi.Size = new System.Drawing.Size(142, 22);
            this.dtpKalkisTarihi.TabIndex = 27;
            // 
            // lblSeferID
            // 
            this.lblSeferID.AutoSize = true;
            this.lblSeferID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeferID.Location = new System.Drawing.Point(137, 33);
            this.lblSeferID.Name = "lblSeferID";
            this.lblSeferID.Size = new System.Drawing.Size(32, 24);
            this.lblSeferID.TabIndex = 24;
            this.lblSeferID.Text = "52";
            // 
            // lblSeferNo
            // 
            this.lblSeferNo.AutoSize = true;
            this.lblSeferNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeferNo.Location = new System.Drawing.Point(33, 33);
            this.lblSeferNo.Name = "lblSeferNo";
            this.lblSeferNo.Size = new System.Drawing.Size(98, 24);
            this.lblSeferNo.TabIndex = 23;
            this.lblSeferNo.Text = "Sefer No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kalkış Yeri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Varış Yeri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kalkış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Varış Tarihi:";
            // 
            // tbVarisYeri
            // 
            this.tbVarisYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbVarisYeri.Location = new System.Drawing.Point(176, 122);
            this.tbVarisYeri.Name = "tbVarisYeri";
            this.tbVarisYeri.Size = new System.Drawing.Size(142, 28);
            this.tbVarisYeri.TabIndex = 16;
            // 
            // tbKalkisYeri
            // 
            this.tbKalkisYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKalkisYeri.Location = new System.Drawing.Point(176, 78);
            this.tbKalkisYeri.Name = "tbKalkisYeri";
            this.tbKalkisYeri.Size = new System.Drawing.Size(142, 28);
            this.tbKalkisYeri.TabIndex = 15;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(632, 312);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 45);
            this.btnIptal.TabIndex = 27;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(484, 312);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(118, 45);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // SeferSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeferSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer Silme Sayfası";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSeferNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbVarisYeri;
        public System.Windows.Forms.TextBox tbKalkisYeri;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblSeferID;
        public System.Windows.Forms.DateTimePicker dtpVarisTarihi;
        public System.Windows.Forms.DateTimePicker dtpKalkisTarihi;
    }
}