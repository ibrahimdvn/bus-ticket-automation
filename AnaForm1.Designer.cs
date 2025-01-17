namespace OtobusBiletOtomasyonu
{
    partial class AnaForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yolcuBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otobüslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güzergahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yolcuBilgileriToolStripMenuItem,
            this.seferBilgileriToolStripMenuItem,
            this.biletBilgileriToolStripMenuItem,
            this.otobüslerToolStripMenuItem,
            this.güzergahToolStripMenuItem,
            this.ödemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yolcuBilgileriToolStripMenuItem
            // 
            this.yolcuBilgileriToolStripMenuItem.Name = "yolcuBilgileriToolStripMenuItem";
            this.yolcuBilgileriToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.yolcuBilgileriToolStripMenuItem.Text = "Yolcu Bilgileri";
            // 
            // seferBilgileriToolStripMenuItem
            // 
            this.seferBilgileriToolStripMenuItem.Name = "seferBilgileriToolStripMenuItem";
            this.seferBilgileriToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.seferBilgileriToolStripMenuItem.Text = "Sefer Bilgileri";
            // 
            // biletBilgileriToolStripMenuItem
            // 
            this.biletBilgileriToolStripMenuItem.Name = "biletBilgileriToolStripMenuItem";
            this.biletBilgileriToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.biletBilgileriToolStripMenuItem.Text = "Bilet Bilgileri";
            this.biletBilgileriToolStripMenuItem.Click += new System.EventHandler(this.biletBilgileriToolStripMenuItem_Click);
            // 
            // otobüslerToolStripMenuItem
            // 
            this.otobüslerToolStripMenuItem.Name = "otobüslerToolStripMenuItem";
            this.otobüslerToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.otobüslerToolStripMenuItem.Text = "Otobüsler";
            // 
            // güzergahToolStripMenuItem
            // 
            this.güzergahToolStripMenuItem.Name = "güzergahToolStripMenuItem";
            this.güzergahToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.güzergahToolStripMenuItem.Text = "Güzergah";
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ödemeToolStripMenuItem.Text = "Ödeme";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(823, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "\"Yolculuğunuzda konfor ve güven.\"";
            // 
            // AnaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yolcuBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otobüslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güzergahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}