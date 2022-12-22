using OBS.islemler;
using OBS.ogrenci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS.akademisyen
{
    public partial class akademisyenSifre : Form
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;
        public akademisyenSifre()
        {
            InitializeComponent();
        }
        public int sonuc = 0;

        public void SifreKontrol()
        {
            string sorgu = "select akdSifre from tbl_akademiyen where akdid=@user and akdSifre=@pass";
            con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", akademisyenGiris.gidenBilgi.ToString());
            cmd.Parameters.AddWithValue("@pass", textBoxEskiSifre.Text);

            con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
            string sorgu2 = "update tbl_akademisyen set akdSifre=@pass where akdid=@id";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id", akademisyenGiris.gidenBilgi.ToString());
            cmd.Parameters.AddWithValue("@pass", textBoxYeniSifre.Text);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu2;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("ŞİFRE DEĞİŞTİRİLDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label4.Text = "Şifreniz Güncellendi!";
        }

        private void akademisyenSifre_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int first = r.Next(0, 30);
            int second = r.Next(0, 30);
            sonuc = first + second;
            labelCaptcha.Text = first.ToString() + "+" + second.ToString() + "=";
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCaptcha.Text == sonuc.ToString())
            {
                label4.Text = "";
                if (textBoxYeniSifre.Text == textBoxTekrar.Text)
                {
                    SifreKontrol();
                }
                else
                {
                    label4.Text = "Yeni Şifre ve Tekrarı Uyumsuz!";
                }
            }
            else
            {
                label4.Text = "Doğrulama İşlemi Yanlış!";
            }

            textBoxEskiSifre.Clear();
            textBoxYeniSifre.Clear();
            textBoxTekrar.Clear();
            textBoxCaptcha.Clear();
        }
    }
}
