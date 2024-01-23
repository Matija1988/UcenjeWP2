using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal abstract class Osoba : Entitet
    {
        private int NeVidim;
        protected int Vidim; 
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string OIB { get; set; }

        public string Email { get; set; }

        public Osoba(int sifra, string ime, string prezime, string oib, string email):base(sifra)
        {
            Ime = ime; Prezime = prezime; OIB = oib; Email = email;
        }

        public override string ToString()
        {
            return new StringBuilder(Ime).Append(' ').Append(Prezime).ToString();
        }

    }
}
