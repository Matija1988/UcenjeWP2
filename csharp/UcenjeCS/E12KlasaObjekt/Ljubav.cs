using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Ljubav
    {

        public string PrvoIme { get; set; }
        public string DrugoIme { get; set; }

        //ovo je konstruktor - 5. vrsta metoda
        public Ljubav()
        {
            // ovdje se dolazi kada se izvodi kljucna rijec new 

        }

        public Ljubav(string prvoIme, string drugoIme)
        {
            PrvoIme = prvoIme;
            DrugoIme = drugoIme;

        }


        public string Rezultat()
        {
            return string.Join(" ", Izracunaj(SlovaUNiz(PrvoIme.ToLower() + DrugoIme.ToLower()))) + " %";
        }

        private int[] SlovaUNiz(string Imena)
        {
            

            int[] niz = new int[Imena.Length];
            int i = 0;

            foreach (char c in Imena)
            {
                int brojac = 0;
                foreach (char c2 in Imena)
                {
                    if (c == c2)
                    {
                        brojac++;
                    }
                }

                niz[i++] = brojac;
            }

            Console.WriteLine(string.Join(" ", niz));

            

            return niz;
        }

        private int Izracunaj(int[] brojevi)
        {
            int suma;
            // dolazi rekurzivni algoritam

            int SpojeniBroj;
            
            int min = 0;
            int max = brojevi.Length - 1;

            int[] novi = new int[brojevi.Length / 2 + brojevi.Length % 2];

            if (brojevi.Length > 2)
            {

                for (int i = 0; i < novi.Length; i++)
           
                {

                    if (min == max)
              
                    {

                        novi[i] = brojevi[i];
              
                    }
              
                    else
               
                    {
                
                        suma = brojevi[i] + brojevi[max];
                 
                        novi[i] = suma;
                                 
                 
                        max--;
                        min++;

                    }
          
                }

        }
        // brojim brojeve vece od 10 u primljenom nizu, ako ih nema upisujem broj iz primljenog niza, aki ih ima razdvajam i stavljam u niz
        int modifikator = 0;
            int brojac = 0;
            int[] nizRazdavjanjeBrojeva = new int[novi.Length + brojac];

           
            foreach (int a in novi)
            {
               
                if (a < 10)
                {
                    brojac++;
                    Array.Resize(ref nizRazdavjanjeBrojeva, brojac);
                    nizRazdavjanjeBrojeva[modifikator++] = a;
                }
                else
                {
                    brojac++;
                    int dvoznam = a / 10;
                    int jedno = a % 10;

                    Array.Resize(ref nizRazdavjanjeBrojeva, brojac);

                    nizRazdavjanjeBrojeva[modifikator++] = dvoznam;
                    brojac++;

                    Array.Resize(ref nizRazdavjanjeBrojeva, brojac);


                    nizRazdavjanjeBrojeva[modifikator++] = jedno;

                  
                }

            }
           
            Console.WriteLine(string.Join(" ", nizRazdavjanjeBrojeva));

            //uzima broj na indeksu 0 mnozi ga sa 10 te zbraja sa brojem na indeksu 1
           SpojeniBroj = nizRazdavjanjeBrojeva[0] * 10 + nizRazdavjanjeBrojeva[1];

            //ako je niz velicine dva vraca spojeni broj
            if (nizRazdavjanjeBrojeva.Length == 2)
            {
                return SpojeniBroj;
            }

            return Izracunaj(nizRazdavjanjeBrojeva); // privremeno
        }

    }
}
