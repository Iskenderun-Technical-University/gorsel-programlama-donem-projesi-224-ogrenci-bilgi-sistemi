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
            // formlar aras� ge�i�
            akademisyenGiris goAkademisyenGirisEkrani = new akademisyenGiris(); // ge�mek istedi�imiz formu nesne haline getiriyoruz
            goAkademisyenGirisEkrani.Show();                                    // formu g�ster komutu
            this.Hide();                                                        // �u anki formu arka planda �al��maya g�nder komutu
        }
    }
}