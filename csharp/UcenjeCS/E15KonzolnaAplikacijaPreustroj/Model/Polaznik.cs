using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacijaPreustroj.Model
{
    internal class Polaznik : Osoba
    {
        public string BrojUgovora { get; set; }

        public override string ToString ()
        {
            return Ime + " " + Prezime + " || " + "Oib: " + Oib + " || " + "Email: " + Email + " || " + "Broj ugovora: " + BrojUgovora;
        }
    }
}
