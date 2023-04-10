using OBS.islemler;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OBS.akademisyen
{
    public partial class akademisyenNotGirisi : Form
    {
        public akademisyenNotGirisi()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            akademisyenMenu tiklaGeriDon = new();
            tiklaGeriDon.Show();
            this.Hide();
        }

        // formdaki arama textbox'una ogrenci no veya ad ile aranılan öğrencinin hem bilgileri hem notları datagride aktarılır.
        private void textBoxArama_TextChanged(object sender, EventArgs e)
        {
            string ogrenciNO = textBoxArama.Text.ToString();
            string sqlSorgusu1 = "select dersAdı,dersVize,dersFinal,dersOrtalama, dersHarfNot,dersDurum from tbl_ogrenci inner join tbl_notlar on tbl_ogrenci.ogrNo=tbl_notlar.dersOgrId where dersOgrId=" + ogrenciNO;
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView2, sqlSorgusu1);
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView1,"select * from tbl_ogrenci where ogrNo like '%"+textBoxArama.Text+"%' or ogrAd like '%"+textBoxArama.Text+"%'");
            textBoxNO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        //datagridview'e çift tıklandığında değerleri ilgili textboxlara aktarır.
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string ogrenciNo = textBoxNO.Text.ToString();
            string sqlSorgusu2 = "select dersAdı,dersVize,dersFinal,dersOrtalama, dersHarfNot,dersDurum from tbl_ogrenci inner join tbl_notlar on tbl_ogrenci.ogrNo=tbl_notlar.dersOgrId where dersOgrId=" + ogrenciNo;
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView2, sqlSorgusu2);
        }

        private void akademisyenNotGirisi_Load(object sender, EventArgs e)
        {
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView1, "select ogrNo,ogrAd,ogrSoyad from tbl_ogrenci");
        }

        // not ekleme işlemi
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            string sqlSorgusu3 = "insert into tbl_notlar (dersOgrId,dersAdı,dersVize,dersFinal,dersOrtalama,dersHarfNot,dersDurum) values (@ogrId,@dersAd,@vize,@final,@ort,@harf,@durum)";
            cmd.Parameters.AddWithValue("@ogrId", textBoxNO.Text);
            cmd.Parameters.AddWithValue("@dersAd", comboBox1.Text);
            cmd.Parameters.AddWithValue("@vize", textBoxVize.Text);
            cmd.Parameters.AddWithValue("@final", textBoxFinal.Text);
            double ortalama = Convert.ToInt32(textBoxVize.Text) * 0.4 + Convert.ToInt32(textBoxFinal.Text) * 0.6;
            cmd.Parameters.AddWithValue("ort", ortalama);
            string harfnot;
            string durum;
            if (ortalama < 50)
            {
                harfnot = "FF";
                durum = "KALDI";
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                harfnot = "CC";
                durum = "GEÇTİ";
            }
            else if (ortalama >= 60 && ortalama < 70)
            {
                harfnot = "CB";
                durum = "GEÇTİ";
            }
            else if (ortalama >= 70 && ortalama < 80)
            {
                harfnot = "BB";
                durum = "GEÇTİ";
            }
            else if (ortalama >= 80 && ortalama < 90)
            {
                harfnot = "BA";
                durum = "GEÇTİ";
            }
            else
            {
                harfnot = "AA";
                durum = "GEÇTİ";
            }
            cmd.Parameters.AddWithValue("@harf", harfnot);
            cmd.Parameters.AddWithValue("@durum", durum);
            Veri_Islemleri.veriAktarma(sqlSorgusu3, cmd);

            int ogrenciID = Convert.ToInt32(textBoxNO.Text);
            string sorgu = "select dersAdı,dersVize, dersFinal, dersOrtalama,dersHarfNot,dersDurum from tbl_ogrenci right join tbl_notlar on tbl_ogrenci.ogrNo = tbl_notlar.dersOgrId where dersOgrId=" + ogrenciID;
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView2, sorgu);
            textBoxVize.Clear();
            textBoxFinal.Clear();

        }

        //not güncelleme işlemi
        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
            string sqlSorgusu4 = "update tbl_notlar set dersAdı=@dersAd,dersVize=@vize,dersFinal=@final,dersOrtalama=@ort,dersHarfNot=@harf,dersDurum=@dersDurum where dersOgrId = @ogrId and dersAdı=@dersAd";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@ogrID", textBoxNO.Text);
            cmd.Parameters.AddWithValue("@dersAD", comboBox1.Text);
            cmd.Parameters.AddWithValue("@vize", textBoxVize.Text);
            cmd.Parameters.AddWithValue("@final", textBoxFinal.Text);
            double ortalama = Convert.ToInt32(textBoxVize.Text) * 0.4 + Convert.ToInt32(textBoxFinal.Text) * 0.6;
            cmd.Parameters.AddWithValue("@ort", ortalama);
            string harfnot;
            string durum;
            if (ortalama < 50)
            {
                harfnot = "FF";
                durum = "KALDI";
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                harfnot = "CC";
                durum = "GEÇTİ";
            }
            else if (ortalama >= 60 && ortalama < 70)
            {
                harfnot = "CB";
                durum = "GEÇTİ";
            }
            else if (ortalama >= 70 && ortalama < 80)
            {
                harfnot = "BB";
                durum = "GEÇTİ";
            }
            else if (ortalama >= 80 && ortalama < 90)
            {
                harfnot = "BA";
                durum = "GEÇTİ";
            }
            else
            {
                harfnot = "AA";
                durum = "GEÇTİ";
            }
            cmd.Parameters.AddWithValue("@harf", harfnot);
            cmd.Parameters.AddWithValue("@dersDurum", durum);



            Veri_Islemleri.veriAktarma(sqlSorgusu4, cmd);

            int ogrenciID = Convert.ToInt32(textBoxNO.Text);
            string sorgu = "select dersAdı,dersVize, dersFinal, dersOrtalama,dersHarfNot,dersDurum from tbl_ogrenci right join tbl_notlar on tbl_ogrenci.ogrNo = tbl_notlar.dersOgrId where dersOgrId=" + ogrenciID;
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView2, sorgu);
            textBoxVize.Clear();
            textBoxFinal.Clear();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBoxVize.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBoxFinal.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

    }
}
