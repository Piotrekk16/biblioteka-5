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
            autor = new Autor();//dobra praktyka
        }

        public Ksiazka(int liczbaStron) //tez moze byc zbedne
        {
            this.liczbaStron = liczbaStron;
            autor = new Autor();//to jest dobra praktyką
        }

        //konstruktor parametryczny - ustawia wszystko a nie smą liczbę stron
        public Ksiazka(string imie, string nazwisko, string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
            autor = new Autor(imie, nazwisko);
        }

        //brakuje ovverride, przydałoby sie wiecej info
        public override void WypiszInfo() 
        {
            Console.WriteLine("Tytuł: {0}", tytul);
            Console.WriteLine("Autor: {0}", autor.PobierzAutora());
            Console.WriteLine("Nr katalogowy: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydaniwa: {0}", rokWydania);
            Console.WriteLine("Liczba stron: {0}", liczbaStron);
        }
    }
}
