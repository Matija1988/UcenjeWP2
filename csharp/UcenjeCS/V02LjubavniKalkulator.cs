using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class V02LjubavniKalkulator
    {
        public static void Izvedi()
        {
            Console.Write("Unesi prvo ime: ");
            string PrvoIme = Console.ReadLine();
            Console.Write("Unesi prvo ime: ");
            string DrugoIme = Console.ReadLine();

            string a = PrvoIme + " i " + DrugoIme + " vole se " + string.Join("", IzracunNiz(VratiNiz(PrvoIme, DrugoIme))) + " %";

            Console.WriteLine(a);

          


        }

        // Metoda uzima dva stringa i vraca int[] duzine spojenih slova i vrijednosti zbroja individualnih slova
        private static int[] VratiNiz(string PrvoIme, string DrugoIme)
        {
            string spojenaImena = PrvoIme.ToLower() + DrugoIme.ToLower();
            int[] niz = new int[spojenaImena.Length];
            int i = 0;

            foreach (char c in spojenaImena)
            {
                int brojac = 0;
                foreach (char d in spojenaImena)
                {
                    if (c == d)
                    {
                        brojac++;
                    }
                }
                niz[i++] = brojac;
            }

            Console.WriteLine(spojenaImena + "\n" + string.Join(" ", niz));

            return niz;

        }

        // Ova metoda uzima niz, reze ga na novu velicinu, obavlja izracune te stvara novi niz u rekurziji dok ne ostanu 2 clana niza

        private static int[] IzracunNiz(int[] niz)
        {

            int novaVelicina = niz.Length / 2 + niz.Length % 2;
            int[] noviNiz = new int[novaVelicina];


            if (niz.Length == 2)
            {
                return niz;
            }

            KalkulacijeUNizu(niz);

            Array.Copy(niz, noviNiz, Math.Min(niz.Length, novaVelicina));

            Console.WriteLine(string.Join(" ", noviNiz));

            return IzracunNiz(RazdvanjanjeBrojeva(noviNiz));
        }


        // Ova metoda zbraja prvi i zadnji broj u primljenom nizu
        private static int[] KalkulacijeUNizu(int[] stari)
        {
            int min = 0;
            int max = stari.Length - 1;

            int[] novi = new int[stari.Length / 2];

            for (int i = min; i < novi.Length; i++)
            {
             
                int suma = stari[min] + stari[max];

                stari[i] = suma;

                min++;
                max--;
            }

            return stari;
        }
        // Ova metoda razdvaja dvoznamenkaste brojeve te pomice niz udesno te vraca novi niz jednoznamenkastih brojeva 
        private static int[] RazdvanjanjeBrojeva(int[] stari)
        {
            int dvoznambroj = Array.FindIndex(stari, n => n >= 10 && n <= 99);
            int[] noviNiz = new int[stari.Length + 1];

            if (dvoznambroj == Array.FindIndex(stari, n => n >= 10 && n <= 99))
            {

                if (dvoznambroj == -1)
                {
                    return stari;
                }


                int brojDvijeZnam = stari[dvoznambroj];
                int dvoznamenkasti = brojDvijeZnam / 10;
                int jednoznamenkasti = brojDvijeZnam % 10;


                Array.Copy(stari, noviNiz, dvoznambroj);


                noviNiz[dvoznambroj] = dvoznamenkasti;


                noviNiz[dvoznambroj + 1] = jednoznamenkasti;


                Array.Copy(stari, dvoznambroj + 1, noviNiz, dvoznambroj + 2, stari.Length - dvoznambroj - 1);

            }

          //  Console.WriteLine(string.Join(" ",  noviNiz));

            return RazdvanjanjeBrojeva(noviNiz);
        }
       
    }
}
