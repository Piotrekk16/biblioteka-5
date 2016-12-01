using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Autor : Osoba
    {
        private string narodowosc;

        public Autor()
        {
        }

        public Autor(string narodowosc) // czy taki konstruktor jest potrzebny?
        {
            this.narodowosc = narodowosc;
        }

        //konstruktor z 2 parametrami (bez narodowosci) - uwaga jw
        public Autor(string imie, string nazwisko)
            : base(imie, nazwisko)
        {
            narodowosc = "Polska";
        }

        public string PobierzAutora()
        {
            return imie + " " + nazwisko;
        }
    }
}
