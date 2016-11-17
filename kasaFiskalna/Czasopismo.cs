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

        public Czasopismo(int numer)
        {
            this.numer = numer;
        }

        protected internal void WypiszInfo()
        {
            Console.WriteLine("Numer czasopisma: {0}", numer);
        }
    }
}
