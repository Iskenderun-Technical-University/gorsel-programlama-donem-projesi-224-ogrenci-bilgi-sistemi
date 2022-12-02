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
    public partial class ogrenciNotSayfasi : Form
    {
        public ogrenciNotSayfasi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciMenu tiklaDonAnaMenu = new ogrenciMenu();
            tiklaDonAnaMenu.Show();
            this.Hide();
        }

        private void ogrenciNotSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
