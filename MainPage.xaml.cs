  
using obsSistemi.Sayfalar;
using obsSistemi.Servis;

namespace obsSistemi
{
    public partial class MainPage : ContentPage
    {
        OgrenciServis ogrenciServis =new OgrenciServis();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGiris_Clicked(object sender, EventArgs e)
        {
            var ogrNum = ogrenciNumara.Text;
            var ogrSifre = ogrenciSifre.Text;


            if(ogrNum == null || ogrSifre == null) {

                await DisplayAlert("Hata", "Öğrenci numarası ve Şifre boş olamaz", "Tamam");
            }
            else
            {
                var sonuc = await ogrenciServis.Login(ogrNum, ogrSifre);
                
                await Navigation.PushAsync(new AnaSayfa());          
            }
        }
    }
}
