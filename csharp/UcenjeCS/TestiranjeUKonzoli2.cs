using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
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

           

           if(noviNiz.Length < 3)
            {
                return noviNiz;
            }

            Console.WriteLine(string.Join(" ", noviNiz));

            return JNizuM(noviNiz);
        }

        private static int[] KaklulacijeUNizu(int[] stari)
        {
            int min = stari.Length - stari.Length;
            int max = stari.Length;

            for(int i = min; i < max; i++)
            {
                int lijevi = stari[min];
                int desni = stari[max - 1];

                if (i == max)
                {
                    continue;
                }
                stari[i] = lijevi + desni;

                min++;
                max--;
            }

            return stari; 
        }

    }


}



