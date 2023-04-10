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
    public partial class ogrenciDersKayıit : Form
    {
        public ogrenciDersKayıit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciMenu tiklaDonMenu = new ogrenciMenu();
            tiklaDonMenu.Show();
            this.Hide();
        }
    }
}
