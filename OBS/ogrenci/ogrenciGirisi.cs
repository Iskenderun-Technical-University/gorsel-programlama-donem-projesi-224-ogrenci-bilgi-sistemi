using OBS.akademisyen;
using OBS.islemler;
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
    public partial class ogrenciGirisi : Form
    {
        public ogrenciGirisi()
        {
            InitializeComponent();
        }
        public static string gidenBilgi = "";
        private void button3_Click(object sender, EventArgs e)
        {
            kullanicigirisekrani goKullaniciGirisEkrani = new kullanicigirisekrani();
            goKullaniciGirisEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (girisKontrol.ogrenciGirisi(textBox1.Text, textBox2.Text))
            {
                ogrenciMenu tiklaGirMenu = new();
                MessageBox.Show("Giriş Başarılı! Öğrenci Bilgi Sistemine Yönlendiriliyorsunuz...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gidenBilgi = textBox1.Text;
                this.Hide();
                tiklaGirMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
