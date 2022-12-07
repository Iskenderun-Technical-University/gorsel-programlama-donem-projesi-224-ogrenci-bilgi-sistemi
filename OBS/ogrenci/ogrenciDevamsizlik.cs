using OBS.islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS.ogrenci
{
    public partial class ogrenciDevamsizlik : Form
    {
        public ogrenciDevamsizlik()
        {
            InitializeComponent();
        }

        private void ogrenciDevamsizlik_Load(object sender, EventArgs e)
        {
            
            string ogrenciNo = ogrenciGirisi.gidenBilgi.ToString();     //giris sayfasindan alinan bilgilye göre sisteme hangi ogrenci girmisse ona gore database'den bilgi aktarir
            string sqlSorgu = "select dersId,devamsizlikDurum,devamsizlikBilgi from tbl_devamsizlik where ogrNo= " + ogrenciNo;     // sql sorgusu ogrenci no'ya göre bilgiyi database'den ceker
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView1, sqlSorgu);        // veritabani_baglantisi class'indan datagrid doldur methodu ile datagridview doldurulur
            dataGridView1.Columns[0].Width = 350;   //datagridview'in her bir sutünun genisligini belirler
            dataGridView1.Columns[1].Width = 350;       
            dataGridView1.Columns[2].Width = 350;
            dataGridView1.Columns[0].HeaderText = "Ders Adı";       // datagridview'in basliklarini düzenleme
            dataGridView1.Columns[1].HeaderText = "Devamsızlık Bilgisi";
            dataGridView1.Columns[2].HeaderText = "Kullanılan Devamsızlık Hakkı";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciMenu tiklaGeriDonMenu = new ogrenciMenu();
            tiklaGeriDonMenu.Show();
            this.Hide();
        }
    }
}
