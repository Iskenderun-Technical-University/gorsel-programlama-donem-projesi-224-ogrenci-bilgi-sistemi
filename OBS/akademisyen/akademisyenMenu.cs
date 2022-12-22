using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBS.ogrenci;

namespace OBS.akademisyen
{
    public partial class akademisyenMenu : Form
    {
        public akademisyenMenu()
        {
            InitializeComponent();
        }
        public void sayfaGecis()
        {
            ogrenciEklemeGüncellemeSilme tiklaGir = new ogrenciEklemeGüncellemeSilme();
            tiklaGir.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kullanicigirisekrani tiklaGirDon = new kullanicigirisekrani();
            tiklaGirDon.Show();
            this.Hide();
        }

        private void öğrenciKayıtEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaGecis();
        }

        private void öğrenciKayıtSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaGecis();
        }

        private void öğrenciBilgileriGörüntüleGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sayfaGecis();
        }

        private void akademisyenBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            akademisyenBilgileri tiklaGir = new akademisyenBilgileri();
            tiklaGir.Show();
            this.Hide();
        }
    }
}
