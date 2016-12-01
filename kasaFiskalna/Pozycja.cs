using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    abstract class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;


        public Pozycja()
        {
        }

        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        abstract public void WypiszInfo();

        //metoda pomocnicza do wyszukania po tytule
        public string PobierzTytul()
        {
            return tytul;
        }

        //metoda pomocnicza do wyszukania po id
        public int PobierzId()
        {
            return id;
        }
    }
}
