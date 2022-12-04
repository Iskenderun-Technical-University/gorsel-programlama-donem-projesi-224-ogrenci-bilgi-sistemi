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
    public partial class ogrenciBilgileri : Form
    {
        public ogrenciBilgileri()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void ogrenciBilgileri_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciMenu tiklaGeriDon = new ogrenciMenu();
            tiklaGeriDon.Show();
            this.Hide();
        }
    }
}
