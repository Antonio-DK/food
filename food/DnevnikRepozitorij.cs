using System.Collections.ObjectModel;

namespace food
{
    public static class DnevnikRepozitorij
    {
        public static ObservableCollection<Dnevnik> Dnevnici { get; } = new ObservableCollection<Dnevnik>();
        public static void Dodaj(Dnevnik dnevnik)
        {
            Dnevnici.Add(dnevnik);
        }
        public static void Obrisi(Dnevnik dnevnik)
        {
            Dnevnici.Remove(dnevnik);
        }
    }
}
