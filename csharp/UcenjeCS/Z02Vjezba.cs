using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z02Vjezba
    {

        public static void Izvedi()
        {
            //program ucitava brojeve sve dok dok se ne unese broj -1
            //program ispisuje 1. Zbroj unesenih brojeva, 2. Najmanji broj, 3. Najveci broj
            // 4 Prosjek svih unesenih brojeva 

            // Koristiti metode i broadu iznimki

            UcitajBroj("Unesi broj: "); 
            

            //int Zbroj = ZbrojBrojeva(PrviBroj, DrugiBroj);
            //Console.WriteLine("Zbroj je " + Zbroj);

            //int Najmanji = NajmanjiBroj(PrviBroj, DrugiBroj);
            //Console.WriteLine("Najmanji broj je: " + Najmanji);

            //int Najveci = NajveciBroj(PrviBroj, DrugiBroj);
            //Console.WriteLine("Najveci broj je " + Najveci);




        }

       

        private static int[] UcitajBroj(string v)
        {
            Console.WriteLine(v);
                              
            int sum = 0;
            int[] niz = new int[0];
           

            while (true)
            {
                int a = int.Parse(Console.ReadLine());

                if(a == -1)
                {
                    break; 
                }

                niz = JNizuM(niz, niz.Length + 1);
                
                niz[niz.Length - 1] = a;
                              
                sum = niz.Sum();
              
                Console.WriteLine("Suma: " + sum.ToString());
                Console.WriteLine("Brojevi u nizu: " + string.Join(" ", niz));
            }

            return niz; 
        }

        private static int[] JNizuM(int[] stari, int novaVelicina)
        {
            int[] noviNiz = new int[novaVelicina];
            Array.Copy(stari, noviNiz, Math.Min(stari.Length, novaVelicina));

            return noviNiz;
        }

    }
}
