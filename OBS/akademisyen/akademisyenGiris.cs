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

namespace OBS.akademisyen
{
    public partial class akademisyenGiris : Form
    {
        public akademisyenGiris()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanicigirisekrani goKullaniciGirisEkrani = new kullanicigirisekrani();
            goKullaniciGirisEkrani.Show();
            this.Hide();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (girisKontrol.akademisyenGirisi(textBox1.Text, textBox2.Text))
            {
                akademisyenMenu girAkademisyenMenu = new akademisyenMenu();
                MessageBox.Show("Giriş Başarılı! Akademisyen Bilgi Sistemine Yönlendiriliyorsunuz...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                girAkademisyenMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
