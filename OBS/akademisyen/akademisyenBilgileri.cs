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
    public partial class akademisyenBilgileri : Form
    {
        public akademisyenBilgileri()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K2C3H0A;Initial Catalog = Universite_Obs; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();

        private void akademisyenBilgileri_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            labelGelenBilgi.Text = akademisyenGiris.gidenBilgi.ToString();
            cmd.CommandText = "select * from tbl_akademisyen where akdid=@p1";
            cmd.Parameters.AddWithValue("@p1", labelGelenBilgi.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textNO.Text = dr[0].ToString();
                textBoxAd.Text = dr[1].ToString();
                textBoxSoyad.Text=dr[2].ToString();
                maskedTextBoxTc.Text = dr[4].ToString();
                textBoxDy.Text = dr[6].ToString();
                dateTimePickerDt.Text=dr[5].ToString();
                textBoxFakulte.Text = dr[7].ToString();
                textBoxBolum.Text = dr[8].ToString();
                textBoxDanısman.Text = dr[9].ToString();
                textBoxTel.Text = dr[10].ToString();
                textBoxMail.Text = dr[11].ToString();
                richTextBox1.Text = dr[12].ToString();
            }
            con.Close();

            // form acildiginda belirtilen textboxların enabled ozelligi false olarak atanir

            textBoxTel.Enabled = false;
            textBoxMail.Enabled = false;
            richTextBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            akademisyenMenu tiklaGeriDon = new akademisyenMenu();
            tiklaGeriDon.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* form acildiginda false olarak atanan enabled ozellikleri butona tiklandiginda true olarak deigstirilir ve 
              databasede degisiklik yapabilme ozelligi aktif hale gelir. */

            textBoxTel.Enabled = true;
            textBoxMail.Enabled = true;
            richTextBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxTel.Text == " ")
            {
                MessageBox.Show("Herhangi Bir Değişiklik Yapmadınız!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
                string sql = "update tbl_akademisyen set akdTel=@tel,akdMail=@mail,akdAdres=@adress where akdid=@no";
                cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@no", textNO.Text);
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
        }
    }
}
