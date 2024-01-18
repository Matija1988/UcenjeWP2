using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Ljubav
    {

        public string PrvoIme { get; set; }
        public string DrugoIme { get; set; }

        //ovo je konstruktor - 5. vrsta metoda
        public Ljubav() {
        // ovdje se dolazi kada se izvodi kljucna rijec new 

        }
        
        public Ljubav(string prvoIme, string drugoIme) 
        { 
            PrvoIme = prvoIme;
            DrugoIme = drugoIme;
        
        }


        public string Rezultat()
        {
            return Izracunaj(SlovaUNiz(PrvoIme + DrugoIme)) + " %";
        }

        private int[] SlovaUNiz(string Imena)
        {


            return new int[2]; // privremeno 
        }

        private int Izracunaj(int[] brojevi)
        {
            // dolazi rekurzivni algoritam
            return 67; // privremeno
        } 




    }
}
