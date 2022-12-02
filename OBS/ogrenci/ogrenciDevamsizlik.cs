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
    public partial class ogrenciDevamsizlik : Form
    {
        public ogrenciDevamsizlik()
        {
            InitializeComponent();
        }

        private void ogrenciDevamsizlik_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciMenu tiklaGeriDonMenu = new ogrenciMenu();
            tiklaGeriDonMenu.Show();
            this.Hide();
        }
    }
}
