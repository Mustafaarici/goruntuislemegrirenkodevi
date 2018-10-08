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
    public partial class Form3 : Form
    {
        Bitmap kaynak,işlem;
        int acıklık;
        int buyuk;
        int kucuk;

        public Form3()
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
                griYöntemleriToolStripMenuItem.Enabled = true;
            }
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
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
                    Color gri = Color.FromArgb(ortalama, ortalama, ortalama);
                    işlem.SetPixel(x, y, gri);
                }
                islembox.Image = işlem;
            }

        }

        

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int genislik = kaynak.Width;
            int yükseklik = kaynak.Height;
            işlem = new Bitmap(genislik, yükseklik);
            for (int x = 0; x < yükseklik; x++)
            {
                for (int y = 0; y < genislik; y++)
                {
                    Color renk = kaynak.GetPixel(x, y);
                    double R = renk.R*0.3;
                    double G = renk.G * 0.59;
                    double B = renk.B * 0.11;
                    int lumayöntemi = Convert.ToInt32(R) + Convert.ToInt32(G) + Convert.ToInt32(B);
                    Color gri = Color.FromArgb(lumayöntemi, lumayöntemi, lumayöntemi);
                    işlem.SetPixel(x,y, gri);
                }
            }
            islembox.Image = işlem;
        }

        private void bT709YöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int yükseklik = kaynak.Height;
            int genişlik = kaynak.Width;
            işlem = new Bitmap(yükseklik, genişlik);
            for (int i = 0; i < yükseklik; i++)
            {
                for (int j = 0; j < genişlik; j++)
                {

                    Color renk = kaynak.GetPixel(i, j);
                    double R = renk.R * 0.2125;
                    double G = renk.G * 0.7154;
                    double B = renk.B * 0.072;
                    int bt709 = Convert.ToInt32(R) + Convert.ToInt32(G) + Convert.ToInt32(B);
                    Color gri = Color.FromArgb(bt709, bt709, bt709);
                    işlem.SetPixel(i, j, gri);
                }
            }
            islembox.Image = işlem;
        }

        private void açıklıkYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int yükseklik = kaynak.Height;
            int genişlik = kaynak.Width;
            işlem = new Bitmap(yükseklik, genişlik);
            for (int i = 0; i <yükseklik ; i++)
            {
                for (int j = 0; j < genişlik; j++)
                {
                    Color renk = kaynak.GetPixel(i, j);
                    int R = renk.R;
                    int G = renk.G;
                    int B = renk.B;

                   if(R>G && R>B)
                   {
                       buyuk = R;
                   }
                   else if(G>B)
                   {
                       buyuk = G;

                   }
                   else
                   {
                       buyuk = B;
                   }
                   if (R < G && R < B)
                   {
                       kucuk = R;
                   }
                     
                   else if (G < B)
                   {
                       kucuk = G;
                   }
                       
                   else
                   {
                       kucuk = G;
                   }

                   acıklık = (buyuk + kucuk) / 2;


                    Color gri = Color.FromArgb(acıklık, acıklık, acıklık);
                    
                    işlem.SetPixel(i, j, gri);
                    

                }
            }
            
            islembox.Image = işlem;
        }

        private void kanalÇıkarımıYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int yükseklik = kaynak.Height;
            int genişlik = kaynak.Width;
            işlem = new Bitmap(yükseklik, genişlik);
            for (int i = 0; i < yükseklik; i++)
            {
                for (int j = 0; j < genişlik; j++)
                {
                    Color renk = kaynak.GetPixel(i, j);
                    int kanalcıkarımı = renk.R;
                    Color gri = Color.FromArgb(kanalcıkarımı, kanalcıkarımı, kanalcıkarımı);
                    işlem.SetPixel(i, j, gri);

                }
            }
            islembox.Image = işlem;
        }

        private void işlemlereGeriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
