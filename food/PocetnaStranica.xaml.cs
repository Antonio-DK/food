using Microsoft.Maui.Controls;

namespace food
{
    public partial class PocetnaStranica : ContentPage
    {
        public PocetnaStranica()
        {
            InitializeComponent();
            DnevnikCollection.SelectionChanged += OnDnevnikSelected;
        }
        private async void OnDodajDnevnikClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DodajDnevnikStranica());
        }
        private async void OnDnevnikSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                var dnevnik = e.CurrentSelection[0] as Dnevnik;
                if (dnevnik != null)
                {
                    await Navigation.PushAsync(new DetaljiDnevnikaStranica(dnevnik));
                    ((CollectionView)sender).SelectedItem = null;
                }
            }
        }
    }
}
