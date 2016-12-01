using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo()
        {
        }

        public Czasopismo(int numer) //nie wiem czy to potrzebne, tego nie ma w poleceniu
        {
            this.numer = numer;
        }

        //konstruktor parametryczny 
        public Czasopismo(int numer, string tytuł, int id, string wydawnictwo, int rokWydania)
            : base(tytuł, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }

        //brak override
        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}", tytul);
            Console.WriteLine("Numer: {0}", numer);
            Console.WriteLine("Nr katalogowy: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydaniwa: {0}", rokWydania);
        }
    }
}
