using System;

namespace food
{
    public class Dnevnik
    {
        public Guid Id { get; set; }
        public string Naslov { get; set; } = string.Empty;
        public string Opis { get; set; } = string.Empty;
        public DateTime Datum { get; set; }
        public Dnevnik()
        {
            Id = Guid.NewGuid();
            Datum = DateTime.Now;
        }
    }
}
