using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS.akademisyen
{
    public partial class akademisyenMenu : Form
    {
        public akademisyenMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kullanicigirisekrani tiklaGirDon = new kullanicigirisekrani();
            tiklaGirDon.Show();
            this.Hide();
        }

       
    }
}
