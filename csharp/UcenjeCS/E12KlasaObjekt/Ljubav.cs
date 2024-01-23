using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            
            int[] niz = new int[Imena.Length];
            int i = 0;

            foreach(char c in Imena)
            {
                int brojac = 0;
                foreach(char c2 in Imena)
                {
                    if (c == c2)
                    {
                        brojac++;
                    }
                }

                niz[i++] = brojac;
            }
            
            Console.WriteLine(string.Join(" ", niz));

            Console.ReadKey();

            return niz;  
        }

        private int Izracunaj(int[] brojevi)
        {
            int SpojeniBroj;
            int VelicinaNiza = 0;

            if (brojevi.Length == 2)
            {
                return  SpojeniBroj = brojevi[0] * 10 + brojevi[1];
            }


            // dolazi rekurzivni algoritam
            int min = 0;
            int max = brojevi.Length - 1;

            int[] novi = new int[brojevi.Length / 2];

            
                
                for(int i = min; i < brojevi.Length / 2; i++) {  

                int suma = brojevi[min] + brojevi[max];
                            

                novi[i] = suma;

                if (suma > 9)
                {
                    int dvoznamenkasti = suma / 10;
                    int jednoznameknasti = suma % 10;

                    novi[VelicinaNiza++] = dvoznamenkasti;
                    novi[VelicinaNiza++] = jednoznameknasti;
                  //  Array.Resize(ref novi, VelicinaNiza);
                }

                 suma = brojevi[min] + brojevi[max];

                min++;
                max--;
                
                }

         //  Array.Resize(ref novi, VelicinaNiza); 

         //  Console.WriteLine(string.Join(" ", novi));

            return Izracunaj(novi); // privremeno
        } 




    }
}
