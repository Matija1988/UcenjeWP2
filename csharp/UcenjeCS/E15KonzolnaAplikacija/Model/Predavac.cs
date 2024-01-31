using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacija.Model
{
    internal class Predavac : Osoba
    {
        public string IBAN { get; set; }

        public override string ToString ()
        {
            return Ime + " || " + Prezime + " || " + Oib + " || " + Email + " || " + IBAN;
        }

    }
}
