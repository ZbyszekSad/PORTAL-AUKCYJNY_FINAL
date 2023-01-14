using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tymczasowa klasa aby zobaczyć czy płatność przechodzi
namespace PORTAL_AUKCYJNY
{
    public class Przedmiot
    {
        public string? Item { get; set; }
        public string? Kategoria { get; set; }
        public int Cena { get; set; }

        public void StworzPrzedmiot()
        {
            Przedmiot test = new Przedmiot();
            test.Item = "Test";
            test.Kategoria = "Kategoria";
            test.Cena = 99;
        }
    }
}
