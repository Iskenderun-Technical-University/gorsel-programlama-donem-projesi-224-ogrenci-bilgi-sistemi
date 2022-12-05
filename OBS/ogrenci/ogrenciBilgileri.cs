using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OBS.islemler;
namespace OBS.ogrenci
{
    public partial class ogrenciBilgileri : Form
    {
        public ogrenciBilgileri()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K2C3H0A;Initial Catalog = Universite_Obs; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void ogrenciBilgileri_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            labelGelenBilgi.Text = ogrenciGirisi.gidenBilgi.ToString();
            cmd.CommandText = "select * from tbl_ogrenci where ogrNo=@p1";
            cmd.Parameters.AddWithValue("@p1", labelGelenBilgi.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxOgrenciNo.Text = dr[0].ToString();
                textBoxAd.Text = dr[1].ToString();
                textBoxSoyad.Text=dr[2].ToString();
                maskedTextBoxTc.Text=dr[4].ToString();
                textBoxDy.Text=dr[6].ToString();
                dateTimePickerDt.Text=dr[5].ToString();
                textBoxFakulte.Text = dr[10].ToString();
                textBoxBolum.Text = dr[11].ToString();
                textBoxDanısman.Text = dr[12].ToString();
                dateTimePickerKt.Text = dr[13].ToString();
                textBoxTel.Text = dr[7].ToString();
                textBoxMail.Text = dr[9].ToString();
                richTextBox1.Text = dr[8].ToString();
                
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciMenu tiklaGeriDon = new ogrenciMenu();
            tiklaGeriDon.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxTel.Clear();
            textBoxMail.Clear();
            richTextBox1.Clear(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* bilgileri güncelle butonuna tıklandığında tüm bilgileri silmektedir. Alt tarafta ise sadece
            telefon bilgisine göre if bloğuna girip güncelleme yapmaktadır. Var olan bilgiye herhangi bir değişiklik yapıldığında
            sistem hata vermektedir, çözümü textboxların boş olup olmadığını tek tek kontrol edip ona göre veritabanında güncelleme
            yapmaktır.
            */

            if (textBoxTel.Text == " ")
            {
                con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
                string sql = "update tbl_ogrenci set ogrTel=@tel,ogrMail=@mail,ogrAdres=@adress where ogrNo=@no";
                cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@no", textBoxOgrenciNo.Text);
                cmd.Parameters.AddWithValue("@tel", textBoxTel.Text);
                cmd.Parameters.AddWithValue("@mail", textBoxMail.Text);
                cmd.Parameters.AddWithValue("@adress", richTextBox1.Text);
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Bilgileriniz Başarıyla Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Herhangi Bir Değişiklik Yapmadınız!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciSifre tiklaGir = new ogrenciSifre();
            tiklaGir.ShowDialog();
        }
    }
}
