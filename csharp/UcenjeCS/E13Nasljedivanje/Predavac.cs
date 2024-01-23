using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Predavac : Osoba
    {
     
        public string IBAN { get; set; }


        public override string ToString()
        {
            return new StringBuilder(Ime).Append(' ').Append(Prezime).ToString();
        }
    }
}
