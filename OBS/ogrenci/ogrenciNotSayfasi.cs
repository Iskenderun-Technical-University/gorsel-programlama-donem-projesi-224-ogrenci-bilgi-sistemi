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
    public partial class ogrenciNotSayfasi : Form
    {
        public ogrenciNotSayfasi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Veritabani_Baglantisi.sqlCon);
        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciMenu tiklaDonAnaMenu = new ogrenciMenu();
            tiklaDonAnaMenu.Show();
            this.Hide();
        }

        private void ogrenciNotSayfasi_Load(object sender, EventArgs e)
        {
            string ogrenciId = ogrenciGirisi.gidenBilgi.ToString();
            string sorgu = "select dersAdı,dersVize, dersFinal, dersOrtalama,dersHarfNot,dersDurum from tbl_ogrenci inner join tbl_notlar on tbl_ogrenci.ogrNo = tbl_notlar.dersOgrId where dersOgrId=" + ogrenciId;
            Veritabani_Baglantisi.gridVeriAktarimi(dataGridView1, sorgu);
            dataGridView1.Columns[0].Width = 310;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 150;

        }
    }
}
