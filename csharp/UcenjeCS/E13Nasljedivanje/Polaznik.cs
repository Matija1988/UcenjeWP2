using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Polaznik:Osoba // nasljeduje sva javna i zasticena svojstva iz klase osoba
    {

        public string BrojUgovora { get; set; }


        public Polaznik(int sifra,string ime, string prezime, string oib,
            string email, string brojUgovora) : base(sifra, ime,  prezime,  oib,
             email)
        {
            BrojUgovora = brojUgovora; 
        }

        public override string ToString()
        {
            return new StringBuilder(base.ToString()).Append(',').Append(BrojUgovora).ToString();
        }

        //public void ProvjeraVidljivosti()
        //{
        //    Vidim = 2; // ovo je u mojoj klasi
        //    base.Sifra = 2; 
        //    base.Vidim = 7;  // ovo je u nadklasi 
        //    this.Vidim = 8; // ovo je u mojoj klasi  
        //    //NeVidim iz Osoba se ne vidi



        //}

    }
      
    
}
