using OBS.akademisyen;

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
    }
}