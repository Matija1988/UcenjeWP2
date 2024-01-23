using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KlaseTestiranje
{
    internal class TestiranjeNizUIntUUvjet
    {

        public static void Izvedi()
        {

            int[] niz = { 7, 1 };

            Console.WriteLine(SpojiBroj(niz));

            Console.WriteLine(Uvjet(SpojiBroj(niz))); 
        }

        private static  int SpojiBroj(int[] niz)
        {
            

           int SpojeniBroj = niz[0] * 10 + niz[1];
            

            return SpojeniBroj;

        }

        private static string Uvjet(int a)
        {
            string Recenica = " "; 

            if (a <= 100 && a > 90)
            {
                Recenica 
                        = "Da smo se voljeli manje\r\nBilo bi nas još i sad";
            } else if (a < 89 && a > 70)
            {
                Recenica
                        = "Pametna ljubav";
            } else if (a < 69 && a > 50)
            {
                Recenica 
                        = "Može proći";
            } else if (a < 49 && a > 30)
            {
                Recenica 
                        = "Želje su jedno, a mogućnosti nešto sasvim drugo";
            } else if (a < 29 && a > 11)
            {
                Recenica
                        = ("Bolje ne!");
            } else
            {
                Recenica = "Samo nemojte pravit djecu.";
            }



            return Recenica;
        } 

    }
}
