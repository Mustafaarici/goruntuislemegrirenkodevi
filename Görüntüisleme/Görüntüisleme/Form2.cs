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
    public partial class Form2 : Form
    {
        Bitmap kaynak;

        public Form2()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if(sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakbox.Image = kaynak;
                renkGetirToolStripMenuItem.Enabled = true;
            }
        }

        private void renkGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xKor.Text);
            int y = int.Parse(yKor.Text);
            Color renk = kaynak.GetPixel(x, y);
            pictureBox1.BackColor = renk;
            Console.WriteLine("R : " + renk.R + "G : " + renk.G + "B : " + renk.B);
        }

        private void işlemlereGeriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();
            form.ShowDialog();
          
            
           
        }
    }
}
