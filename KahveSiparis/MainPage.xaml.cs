
namespace KahveSiparis;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void SekerSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        SekerLabel.Text = $"Şeker miktarı: {(int)e.NewValue}";
    }

    private void SiparisButton_Clicked(object sender, EventArgs e)
    {
        string ad = AdEntry.Text?.Trim() ?? "";
        string kahve = KahveEntry.Text?.Trim() ?? "";
        int seker = (int)SekerSlider.Value;

        if (ad == "" || kahve == "")
        {
            SonucLabel.Text = "Lütfen adınızı ve kahve türünü girin.";
            return;
        }

        SonucLabel.Text =
            $"Sayın {ad}, siparişiniz alındı!\n" +
            $"Kahve: {kahve}\n" +
            $"Şeker miktarı: {seker}";
    }
}
