using Microsoft.Maui.Controls;

namespace food
{
    public partial class DetaljiDnevnikaStranica : ContentPage
    {
        Dnevnik _dnevnik;
        public DetaljiDnevnikaStranica(Dnevnik dnevnik)
        {
            InitializeComponent();
            _dnevnik = dnevnik;
            NaslovUnos.Text = _dnevnik.Naslov;
            DatumOznaka.Text = _dnevnik.Datum.ToString("dd.MM.yyyy HH:mm");
            OpisEditor.Text = _dnevnik.Opis;
        }
        private async void OnSpremiPromjeneClicked(object sender, EventArgs e)
        {
            _dnevnik.Naslov = NaslovUnos.Text;
            _dnevnik.Opis = OpisEditor.Text;
            await Navigation.PopAsync();
        }
        private async void OnObrisiClicked(object sender, EventArgs e)
        {
            DnevnikRepozitorij.Obrisi(_dnevnik);
            await Navigation.PopAsync();
        }
    }
}
