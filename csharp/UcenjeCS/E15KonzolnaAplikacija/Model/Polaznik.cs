using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacija.Model
{
    internal class Polaznik : Osoba
    {
        public string BrojUgovora { get; set; }

        public override string ToString ()
        {
            return Ime + " || " + Prezime + " || " + Oib + " || " + Email + " || " + BrojUgovora;
        }
    }
}
