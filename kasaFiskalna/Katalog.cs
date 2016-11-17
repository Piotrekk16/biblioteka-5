using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Katalog : IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;

        public List<Pozycja> listaPozycji;

        public Katalog()
        {
        }

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }

        public void DodajPozycje()
        {

        }
    }

}
