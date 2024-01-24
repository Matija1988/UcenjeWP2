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
           
            int suma;

            // dolazi rekurzivni algoritam
            int modifikator2 = 0;

         

            int[] nizRazdavjanjeBrojeva = new int[brojevi.Length + 1];



          

            int modifikator = 0;
           
            int SpojeniBroj;

           
            // brojim brojeve vece od 10 u primljenom nizu, ako ih ima razdvajam, ako ih nema upisujem broj iz primljenog niza
            foreach (int a in brojevi)
            {

                if (a >= 10)
                {
                    int dvoznam = a / 10;
                    int jedno = a % 10;

                    nizRazdavjanjeBrojeva[modifikator++] = dvoznam;
                    nizRazdavjanjeBrojeva[modifikator++] = jedno;
                               

                } else
                {
                    nizRazdavjanjeBrojeva[modifikator++] = a; 
                }

            }
            Console.WriteLine("Rastavljeni niz > " + string.Join(" ", nizRazdavjanjeBrojeva));

            int min = 0;
            int max = brojevi.Length - 1;



            int[] novi = new int[nizRazdavjanjeBrojeva.Length / 2 + nizRazdavjanjeBrojeva.Length % 2];

            for (int i = min; i < nizRazdavjanjeBrojeva.Length / 2; i++) {

                if (min == max)
                {

                    novi[i] = brojevi[i];

                }
                else {

                    suma = nizRazdavjanjeBrojeva[min] + nizRazdavjanjeBrojeva[max];

                    novi[i] = suma;
                     
                    min++;
                    max--;
                }
                               

            }

            SpojeniBroj = novi[0] * 10 + novi[1];

          //  Console.WriteLine("Razdvojeni brojevi " + string.Join(" ", nizRazdavjanjeBrojeva));
         //   Console.WriteLine(string.Join(" ", novi));

            if (novi.Length == 2 && SpojeniBroj < 100)
            {
                return SpojeniBroj;
            }



            Console.WriteLine("Novi > " + string.Join(" ", novi));


            return Izracunaj(novi); // privremeno
        } 




    }
}
