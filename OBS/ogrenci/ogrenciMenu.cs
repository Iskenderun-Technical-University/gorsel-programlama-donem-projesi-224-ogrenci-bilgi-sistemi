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
    }
}
