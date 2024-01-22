using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UcenjeCS.KlaseTestiranje
{
    internal class TestiranjeUKonzoli2
    {

        public static void Izvedi()
        {

            Console.WriteLine("Unesi prvo ime: ");
            string PrvoIme = Console.ReadLine();
            Console.WriteLine("Unesi drugo ime: ");
            string DrugoIme = Console.ReadLine();

            string a = string.Join(" ", JNizuM(VratiNiz(PrvoIme, DrugoIme)));
            Console.WriteLine(a);

            Console.ReadKey();
        }



        private static int[] VratiNiz(string prvoIme, string drugoIme)
        {
            string spojenaImena = prvoIme + drugoIme;
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

            Console.WriteLine(spojenaImena + "\n " + string.Join(" ", niz));

            return niz;

        }

        private static int[] JNizuM(int[] stari)
        {
            int novaVelicina = stari.Length / 2 + stari.Length % 2;

            int[] noviNiz = new int[novaVelicina];

            KaklulacijeUNizu(stari);



            Array.Copy(stari, noviNiz, Math.Min(stari.Length, novaVelicina));

            if (noviNiz.Length == 2)
            {

                return noviNiz;
            }



            Console.WriteLine(string.Join(" ", noviNiz));

            return JNizuM(noviNiz);
        }


        private static int[] KaklulacijeUNizu(int[] stari)
        {
            int min = 0;
            int max = stari.Length;



            int[] novi = new int[stari.Length / 2];

            for (int i = min; i < novi.Length; i++)
            {

                int suma = stari[min] + stari[max - 1];

                stari[i] = suma;

                min++;
                max--;
            }


            return stari;
        }
        private static int[] SplitTwoDigitNumberInArray(int[] stari)
        {
            int dvoznambroj = Array.FindIndex(stari, n => n >= 10 && n <= 99);

            if (dvoznambroj == -1)
            {
                return stari;
            }


            int brojDvijeZnam = stari[dvoznambroj];
            int dvoznamenkasti = brojDvijeZnam / 10;
            int jednoznamenkasti = brojDvijeZnam % 10;


            int[] noviNiz = new int[stari.Length + 1];


            Array.Copy(stari, noviNiz, dvoznambroj);


            noviNiz[dvoznambroj] = dvoznamenkasti;


            noviNiz[dvoznambroj + 1] = jednoznamenkasti;


            Array.Copy(stari, dvoznambroj + 1, noviNiz, dvoznambroj + 2, stari.Length - dvoznambroj - 1);



            return SplitTwoDigitNumberInArray(noviNiz);
        }


    }
}



