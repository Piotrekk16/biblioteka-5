using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    interface IZarzadzanieKatalogiem
    {
        //tu dodajemy tylko deklarację (bez nawiasów klamrowych), przy dwóch metoda przydałyby się parametry
        void WyszukajPoTytule(string tytuł);
        void WyszukajPoId(int id);
        void WypiszWszystko();
    }
}
