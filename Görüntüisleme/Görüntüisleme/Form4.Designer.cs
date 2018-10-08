namespace Görüntüisleme
{
    partial class Form4
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
            this.kanalSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBGBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.islembox = new System.Windows.Forms.PictureBox();
            this.kaynakbox = new System.Windows.Forms.PictureBox();
            this.işlemlereGeriDönToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBBGRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBBRGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islembox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.kanalSıralaToolStripMenuItem,
            this.işlemlereGeriDönToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kanalSıralaToolStripMenuItem
            // 
            this.kanalSıralaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBGBRToolStripMenuItem,
            this.rGBBGRToolStripMenuItem,
            this.rGBBRGToolStripMenuItem});
            this.kanalSıralaToolStripMenuItem.Enabled = false;
            this.kanalSıralaToolStripMenuItem.Name = "kanalSıralaToolStripMenuItem";
            this.kanalSıralaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.kanalSıralaToolStripMenuItem.Text = "Kanal Sırala";
            this.kanalSıralaToolStripMenuItem.Click += new System.EventHandler(this.kanalSıralaToolStripMenuItem_Click);
            // 
            // rGBGBRToolStripMenuItem
            // 
            this.rGBGBRToolStripMenuItem.Name = "rGBGBRToolStripMenuItem";
            this.rGBGBRToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rGBGBRToolStripMenuItem.Text = "RGB > GBR";
            this.rGBGBRToolStripMenuItem.Click += new System.EventHandler(this.rGBGBRToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // islembox
            // 
            this.islembox.Location = new System.Drawing.Point(554, 54);
            this.islembox.Name = "islembox";
            this.islembox.Size = new System.Drawing.Size(439, 347);
            this.islembox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.islembox.TabIndex = 4;
            this.islembox.TabStop = false;
            // 
            // kaynakbox
            // 
            this.kaynakbox.Location = new System.Drawing.Point(13, 54);
            this.kaynakbox.Name = "kaynakbox";
            this.kaynakbox.Size = new System.Drawing.Size(439, 347);
            this.kaynakbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaynakbox.TabIndex = 3;
            this.kaynakbox.TabStop = false;
            // 
            // işlemlereGeriDönToolStripMenuItem
            // 
            this.işlemlereGeriDönToolStripMenuItem.Name = "işlemlereGeriDönToolStripMenuItem";
            this.işlemlereGeriDönToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.işlemlereGeriDönToolStripMenuItem.Text = "İşlemlere Geri Dön";
            this.işlemlereGeriDönToolStripMenuItem.Click += new System.EventHandler(this.işlemlereGeriDönToolStripMenuItem_Click);
            // 
            // rGBBGRToolStripMenuItem
            // 
            this.rGBBGRToolStripMenuItem.Name = "rGBBGRToolStripMenuItem";
            this.rGBBGRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rGBBGRToolStripMenuItem.Text = "RGB > BGR";
            this.rGBBGRToolStripMenuItem.Click += new System.EventHandler(this.rGBBGRToolStripMenuItem_Click);
            // 
            // rGBBRGToolStripMenuItem
            // 
            this.rGBBRGToolStripMenuItem.Name = "rGBBRGToolStripMenuItem";
            this.rGBBRGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rGBBRGToolStripMenuItem.Text = "RGB > BRG";
            this.rGBBRGToolStripMenuItem.Click += new System.EventHandler(this.rGBBRGToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 454);
            this.Controls.Add(this.islembox);
            this.Controls.Add(this.kaynakbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Kanal Sırala Uygulaması";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islembox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBGBRToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox islembox;
        private System.Windows.Forms.PictureBox kaynakbox;
        private System.Windows.Forms.ToolStripMenuItem işlemlereGeriDönToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBBGRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBBRGToolStripMenuItem;
    }
}