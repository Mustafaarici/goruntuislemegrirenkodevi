namespace Görüntüisleme
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griYöntemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT709YöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalÇıkarımıYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakbox = new System.Windows.Forms.PictureBox();
            this.islembox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.işlemlereGeriDönToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islembox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.griYöntemleriToolStripMenuItem,
            this.işlemlereGeriDönToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
           
            // 
            // griYöntemleriToolStripMenuItem
            // 
            this.griYöntemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ortalamaToolStripMenuItem,
            this.lumaYöntemiToolStripMenuItem,
            this.bT709YöntemiToolStripMenuItem,
            this.açıklıkYöntemiToolStripMenuItem,
            this.kanalÇıkarımıYöntemiToolStripMenuItem});
            this.griYöntemleriToolStripMenuItem.Enabled = false;
            this.griYöntemleriToolStripMenuItem.Name = "griYöntemleriToolStripMenuItem";
            this.griYöntemleriToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.griYöntemleriToolStripMenuItem.Text = "Gri Yöntemleri";
            // 
            // ortalamaToolStripMenuItem
            // 
            this.ortalamaToolStripMenuItem.Name = "ortalamaToolStripMenuItem";
            this.ortalamaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ortalamaToolStripMenuItem.Text = "Ortalama";
            this.ortalamaToolStripMenuItem.Click += new System.EventHandler(this.ortalamaToolStripMenuItem_Click);
            // 
            // lumaYöntemiToolStripMenuItem
            // 
            this.lumaYöntemiToolStripMenuItem.Name = "lumaYöntemiToolStripMenuItem";
            this.lumaYöntemiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.lumaYöntemiToolStripMenuItem.Text = "Luma Yöntemi";
            this.lumaYöntemiToolStripMenuItem.Click += new System.EventHandler(this.lumaYöntemiToolStripMenuItem_Click);
            // 
            // bT709YöntemiToolStripMenuItem
            // 
            this.bT709YöntemiToolStripMenuItem.Name = "bT709YöntemiToolStripMenuItem";
            this.bT709YöntemiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bT709YöntemiToolStripMenuItem.Text = "BT-709 Yöntemi";
            this.bT709YöntemiToolStripMenuItem.Click += new System.EventHandler(this.bT709YöntemiToolStripMenuItem_Click);
            // 
            // açıklıkYöntemiToolStripMenuItem
            // 
            this.açıklıkYöntemiToolStripMenuItem.Name = "açıklıkYöntemiToolStripMenuItem";
            this.açıklıkYöntemiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.açıklıkYöntemiToolStripMenuItem.Text = "Açıklık Yöntemi";
            this.açıklıkYöntemiToolStripMenuItem.Click += new System.EventHandler(this.açıklıkYöntemiToolStripMenuItem_Click);
            // 
            // kanalÇıkarımıYöntemiToolStripMenuItem
            // 
            this.kanalÇıkarımıYöntemiToolStripMenuItem.Name = "kanalÇıkarımıYöntemiToolStripMenuItem";
            this.kanalÇıkarımıYöntemiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.kanalÇıkarımıYöntemiToolStripMenuItem.Text = "Kanal Çıkarımı Yöntemi";
            this.kanalÇıkarımıYöntemiToolStripMenuItem.Click += new System.EventHandler(this.kanalÇıkarımıYöntemiToolStripMenuItem_Click);
            // 
            // kaynakbox
            // 
            this.kaynakbox.Location = new System.Drawing.Point(12, 27);
            this.kaynakbox.Name = "kaynakbox";
            this.kaynakbox.Size = new System.Drawing.Size(439, 347);
            this.kaynakbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaynakbox.TabIndex = 1;
            this.kaynakbox.TabStop = false;
            // 
            // islembox
            // 
            this.islembox.Location = new System.Drawing.Point(553, 27);
            this.islembox.Name = "islembox";
            this.islembox.Size = new System.Drawing.Size(439, 347);
            this.islembox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.islembox.TabIndex = 2;
            this.islembox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // işlemlereGeriDönToolStripMenuItem
            // 
            this.işlemlereGeriDönToolStripMenuItem.Name = "işlemlereGeriDönToolStripMenuItem";
            this.işlemlereGeriDönToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.işlemlereGeriDönToolStripMenuItem.Text = "İşlemlere Geri Dön";
            this.işlemlereGeriDönToolStripMenuItem.Click += new System.EventHandler(this.işlemlereGeriDönToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 457);
            this.Controls.Add(this.islembox);
            this.Controls.Add(this.kaynakbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Gri Dönüştürme Yöntemleri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islembox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griYöntemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamaToolStripMenuItem;
        private System.Windows.Forms.PictureBox kaynakbox;
        private System.Windows.Forms.PictureBox islembox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem lumaYöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT709YöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkYöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalÇıkarımıYöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlereGeriDönToolStripMenuItem;
    }
}