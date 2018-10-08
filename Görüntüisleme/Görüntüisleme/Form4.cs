using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görüntüisleme
{
    public partial class Form4 : Form
    {
 
        Bitmap kaynak,işlem;

        public Form4()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
              DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakbox.Image = kaynak;
                kanalSıralaToolStripMenuItem.Enabled = true;
            }
        }

        private void rGBGBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yük = kaynak.Height;
            işlem = new Bitmap(gen, yük);
            for (int y = 0; y < yük; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkli = kaynak.GetPixel(x, y);
                    int ortalama = (renkli.R + renkli.G + renkli.B) / 3;
                    Color yenirenk = Color.FromArgb(renkli.G,renkli.B,renkli.R);
                    işlem.SetPixel(x, y, yenirenk);
                }
                islembox.Image = işlem;
            }
        }

        private void işlemlereGeriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void kanalSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rGBBGRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int yükseklik = kaynak.Height;
            int genişlik = kaynak.Width;
            işlem = new Bitmap(genişlik, yükseklik);
           
            for (int i = 0; i < yükseklik; i++)
            {
                for (int j = 0; j < genişlik; j++)
                {
                    Color renkli = kaynak.GetPixel(i, j);
                    int ortalama = (renkli.R + renkli.G + renkli.B) / 3;
                    Color yenirenk = Color.FromArgb(renkli.B, renkli.G, renkli.R);
                    işlem.SetPixel(i, j, yenirenk);

                }
            }
            islembox.Image = işlem;
        }

        private void rGBBRGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int yükseklik = kaynak.Height;
            int genişlik = kaynak.Width;
            işlem = new Bitmap(genişlik, yükseklik);

            for (int i = 0; i < yükseklik; i++)
            {
                for (int j = 0; j < genişlik; j++)
                {
                    Color renkli = kaynak.GetPixel(i, j);
                    int ortalama = (renkli.R + renkli.G + renkli.B) / 3;
                    Color yenirenk = Color.FromArgb(renkli.B, renkli.R, renkli.G);
                    işlem.SetPixel(i, j, yenirenk);

                }
            }
            islembox.Image = işlem;
        }
    }
}
