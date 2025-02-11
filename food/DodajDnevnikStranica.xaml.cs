using Microsoft.Maui.Controls;

namespace food
{
    public partial class DodajDnevnikStranica : ContentPage
    {
        public DodajDnevnikStranica()
        {
            InitializeComponent();
        }
        public async void OnSpremiDnevnikClicked(object sender, EventArgs e)
        {
            var naslov = NaslovUnos.Text;
            var opis = OpisEditor.Text;
            if (!string.IsNullOrWhiteSpace(naslov))
            {
                var dnevnik = new Dnevnik { Naslov = naslov, Opis = opis };
                DnevnikRepozitorij.Dodaj(dnevnik);
            }
            await Navigation.PopAsync();
        }
    }
}
