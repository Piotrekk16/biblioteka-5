using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;

        public Autor autor;

        public Ksiazka()
        {
        }

        public Ksiazka(int liczbaStron)
        {
            this.liczbaStron = liczbaStron;
        }

        protected internal void WypiszInfo()
        {
            Console.WriteLine("Liczba stron: {0}", liczbaStron);
        }
    }
}
