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
using OBS.islemler;

namespace OBS.ogrenci
{
    public partial class ogrenciSifre : Form
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;

        public ogrenciSifre()
        {
            InitializeComponent();
        }
        public int sonuc = 0;

        public void SifreKontrol()
        {
            string sorgu = "select ogrSifre from tbl_ogrenci where ogrNo=@user and ogrSifre=@pass";
            con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", ogrenciGirisi.gidenBilgi.ToString());
            cmd.Parameters.AddWithValue("@pass", textBoxEskiSifre.Text);

            con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
            string sorgu2 = "update tbl_ogrenci set ogrSifre=@pass where ogrNo=@id";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id", ogrenciGirisi.gidenBilgi.ToString());
            cmd.Parameters.AddWithValue("@pass", textBoxYeniSifre.Text);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu2;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("ŞİFRE DEĞİŞTİRİLDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label4.Text = "Şifreniz Güncellendi!";
        }
        private void ogrenciSifre_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int first = r.Next(0, 30);
            int second = r.Next(0, 30);
            sonuc = first + second;
            labelCaptcha.Text=first.ToString()+ "+" + second.ToString()+"=";
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxCaptcha.Text == sonuc.ToString())
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
        }
    }
}
