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

        public Autor(string narodowosc)
        {
            this.narodowosc = narodowosc;
        }
    }
}
