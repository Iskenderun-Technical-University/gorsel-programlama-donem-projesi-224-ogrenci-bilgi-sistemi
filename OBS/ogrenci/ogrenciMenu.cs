using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OBS.ogrenci
{
    public partial class ogrenciMenu : Form
    {
        public ogrenciMenu()
        {
            InitializeComponent();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kullanicigirisekrani tiklaGeriDonGirisEkrani = new kullanicigirisekrani();
            MessageBox.Show("Kullanici Giriş Ekranına Yönlendiriliyorsunuz...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tiklaGeriDonGirisEkrani.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciNotSayfasi tiklaGirNotSayfasi = new ogrenciNotSayfasi();
            tiklaGirNotSayfasi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciTranskript tiklaGirTranskriptSayfasi = new ogrenciTranskript();
            tiklaGirTranskriptSayfasi.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ogrenciDersKayıit tiklaGirDersKayıt = new ogrenciDersKayıit();
            tiklaGirDersKayıt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ogrenciDersler tiklaGirDersler = new ogrenciDersler();
            tiklaGirDersler.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrenciDevamsizlik tiklaGirDevamsizlik = new ogrenciDevamsizlik();
            tiklaGirDevamsizlik.Show();
            this.Hide();
        }
        
    }
}
