using OBS.akademisyen;
using OBS.islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OBS.ogrenci
{
    public partial class ogrenciEklemeGüncellemeSilme : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public ogrenciEklemeGüncellemeSilme()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            akademisyenMenu tiklaGeriDon = new akademisyenMenu();
            tiklaGeriDon.Show();
            this.Hide();
        }
        public void txtTemizlemeFonk()
        {
            textBoxNO.Clear();
            textBoxAD.Clear();
            textBoxSOYAD.Clear();
            textBoxSİFRE.Clear();
            maskedTextBoxTC.Clear();
            textBoxTEL.Clear();
            textBoxMAİL.Clear();
            textBoxADRES.Clear();
            textBoxDANISMAN.Clear();
            dateTimePickerDT.Text = DateTime.Now.ToString();
            dateTimePickerKT.Text = DateTime.Now.ToString();
            comboBoxBOLUM.Text = "";
            comboBoxDY.Text = "";
            comboBoxFAKULTE.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtTemizlemeFonk();
        }

        //database'e ogrenci ekleme islemi
        private void button2_Click(object sender, EventArgs e)
        {

            
            cmd = new SqlCommand();
            string sqlSorgu1 = "insert into tbl_ogrenci(ogrAd,ogrSoyad,ogrSifre,ogrTc,ogrDt,ogrDy,ogrTel,ogrAdres,ogrMail,ogrFakulte,ogrBolum,ogrDanışman,ogrKayit) values(@name,@surname,@pass,@tc,@dt,@dy,@tel,@adress,@mail,@fakulte,@bolum,@danısman,@kt)";
                
            //textboxlardan herhangi birinin boş kalması durumunda uyarı veren if yapısı
                if (textBoxAD.Text != "" && textBoxSOYAD.Text != "" && textBoxSİFRE.Text != "" && maskedTextBoxTC.Text != "" && comboBoxDY.Text != "" && textBoxTEL.Text != "" && textBoxADRES.Text != "" && textBoxMAİL.Text != "" && comboBoxFAKULTE.Text != "" && comboBoxBOLUM.Text != "" && textBoxDANISMAN.Text != "" )
                {
                    cmd.Parameters.AddWithValue("@name", textBoxAD.Text);
                    cmd.Parameters.AddWithValue("@surname", textBoxSOYAD.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@pass", textBoxSİFRE.Text);
                    cmd.Parameters.AddWithValue("@tc", maskedTextBoxTC.Text);
                    cmd.Parameters.AddWithValue("@dt", DateTime.Now);
                    cmd.Parameters.AddWithValue("@dy", comboBoxDY.Text);
                    cmd.Parameters.AddWithValue("@tel", textBoxTEL.Text);
                    cmd.Parameters.AddWithValue("@adress", textBoxADRES.Text);
                    cmd.Parameters.AddWithValue("@mail", textBoxMAİL.Text);
                    cmd.Parameters.AddWithValue("@fakulte", comboBoxFAKULTE.Text);
                    cmd.Parameters.AddWithValue("@bolum", comboBoxBOLUM.Text);
                    cmd.Parameters.AddWithValue("@danısman", textBoxDANISMAN.Text);
                    cmd.Parameters.AddWithValue("@kt", DateTime.Now);

                    Veri_Islemleri.veriAktarma(sqlSorgu1, cmd);
                    Veritabani_Baglantisi.gridVeriAktarimi(dataGridView1, "select * from tbl_ogrenci");

                    MessageBox.Show("Öğrenci Kaydedildi!", "KAYIT EKLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtTemizlemeFonk();
                }
            else
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
            }
                
            
            
            

        

    
        //database'deki verileri guncelleme islemi
        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
            string sqlSorgu2 = "update tbl_ogrenci set ogrAd=@name,ogrSoyad=@surname,ogrSifre=@pass,ogrTc=@tc,ogrDt=@dt,ogrDy=@dy,ogrTel=@tel,ogrAdres=@adress,ogrMail=@mail,ogrFakulte=@fakulte,ogrBolum=@bolum,ogrDanışman=@danisman,ogrKayit=@kt where ogrNo=@nmra";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@nmra", textBoxNO.Text);
            cmd.Parameters.AddWithValue("@name", textBoxAD.Text);
            cmd.Parameters.AddWithValue("@surname", textBoxSOYAD.Text.ToUpper());
            cmd.Parameters.AddWithValue("@pass", textBoxSİFRE.Text);
            cmd.Parameters.AddWithValue("@tc", maskedTextBoxTC.Text);
            cmd.Parameters.AddWithValue("@dt", DateTime.Now);
            cmd.Parameters.AddWithValue("@dy", comboBoxDY.Text);
            cmd.Parameters.AddWithValue("@tel", textBoxTEL.Text);
            cmd.Parameters.AddWithValue("@adress", textBoxADRES.Text);
            cmd.Parameters.AddWithValue("@mail", textBoxMAİL.Text);
            cmd.Parameters.AddWithValue("@fakulte", comboBoxFAKULTE.Text);
            cmd.Parameters.AddWithValue("@bolum", comboBoxBOLUM.Text);
            cmd.Parameters.AddWithValue("@danisman", textBoxDANISMAN.Text);
            cmd.Parameters.AddWithValue("@kt", DateTime.Now);
            Veri_Islemleri.veriAktarma(sqlSorgu2, cmd);
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView1, "select * from tbl_ogrenci");

            MessageBox.Show("Güncelleme İşlemi Gerçekleşti!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtTemizlemeFonk();
        }   

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxNO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSOYAD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxSİFRE.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBoxTC.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePickerDT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBoxDY.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxTEL.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTimePickerKT.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBoxMAİL.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBoxADRES.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBoxFAKULTE.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            comboBoxBOLUM.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBoxDANISMAN.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void ogrenciEklemeGüncellemeSilme_Load(object sender, EventArgs e)
        {
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView1, "select * from tbl_ogrenci");
        }

        //database'den veri silme islemi
        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
            string sqlSorgu3 = "delete from tbl_ogrenci where ogrNo=@no";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@no", textBoxNO.Text);
            Veri_Islemleri.veriAktarma(sqlSorgu3, cmd);
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView1, "select * from tbl_ogrenci");

            MessageBox.Show("Öğrenci Kaydı Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTemizlemeFonk();
        }
    }
}
