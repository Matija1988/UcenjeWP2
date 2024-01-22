using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KlaseTestiranje
{
    internal class TestiranjeUKonzoli3
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

            Console.WriteLine(spojenaImena + "\n " + string.Join(" ", niz));

            return niz;

        }

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

            return RazdvanjanjeBrojeva(noviNiz);
        }


    }
}
