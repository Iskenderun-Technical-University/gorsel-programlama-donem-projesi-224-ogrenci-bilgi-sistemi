using OBS.akademisyen;
using OBS.ogrenci;

namespace OBS
{
    public partial class kullanicigirisekrani : Form
    {
        public kullanicigirisekrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // formlar arasý geçiþ
            akademisyenGiris goAkademisyenGirisEkrani = new akademisyenGiris(); // geçmek istediðimiz formu nesne haline getiriyoruz
            goAkademisyenGirisEkrani.Show();                                    // formu göster komutu
            this.Hide();                                                        // þu anki formu arka planda çalýþmaya gönder komutu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciGirisi tiklaGirOgrenci = new ogrenciGirisi();
            tiklaGirOgrenci.Show();
            this.Hide();
        }
    }
}