using System;
using System.Collections;
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
            return string.Join(" ", Izracunaj(SlovaUNiz(PrvoIme + DrugoIme))) + " %";
        }

        private int[] SlovaUNiz(string Imena)
        {
            Imena = PrvoIme + DrugoIme;

            int[] niz = new int[Imena.Length];
            int i = 0;

            foreach(char c in Imena)
            {
                int brojac = 0;
                foreach(char c2 in niz)
                {
                    if(c == c2)  brojac++;
                }

                niz[i++] = brojac;
            }

            return niz; // privremeno 
        }

        private int Izracunaj(int[] brojevi)
        {
            // dolazi rekurzivni algoritam
            int min = 0;
            int max = brojevi.Length - 1;

            int[] novi = new int[brojevi.Length / 2];

            while(brojevi.Length < 2 ) { 
                
                for(int i = min; i < novi.Length; i++) {  

                int suma = brojevi[min] + brojevi[max];

                brojevi[i] = suma;

                min++;
                max--;
                }
            }

            return 67; // privremeno
        } 




    }
}
