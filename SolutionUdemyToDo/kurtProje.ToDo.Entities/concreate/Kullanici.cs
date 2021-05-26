using kurtProje.ToDo.Entities.interfaces;
using System.Collections.Generic;

namespace kurtProje.ToDo.Entities.concreate
{
    public class Kullanici : ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public List<Calisma> calismalar { get; set; }

    }
}
