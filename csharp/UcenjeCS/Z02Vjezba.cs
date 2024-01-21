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


        }

       

        private static int[] UcitajBroj(string v)
        {
            Console.WriteLine(v);
                              
            int sum = 0;
            int[] niz = new int[0];
           

            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int a)) {

                    if (a <= -1)
                    {
                        break;
                    }


                    niz = JNizuM(niz, niz.Length + 1);
             
                    niz[niz.Length - 1] = a;
                            
               
                   Console.WriteLine("Brojevi u nizu: " + string.Join(" ", niz));
                


                }
                
            }

           

            Console.WriteLine(VratiZbroj(niz));
            Console.WriteLine(NajmanjiBroj(niz));
            Console.WriteLine(NajveciBroj(niz));
            Console.WriteLine(Prosjek(niz));
            Console.ReadKey();
          

            return niz;

        }

        private static int[] JNizuM(int[] stari, int novaVelicina)
        {
            int[] noviNiz = new int[novaVelicina];
            Array.Copy(stari, noviNiz, Math.Min(stari.Length, novaVelicina));

            return noviNiz;
        }
        private static string VratiZbroj(int[] ints)
        {
            int sum = ints.Sum();

            return "Suma: " + sum.ToString();
        }

        private static string NajmanjiBroj(int[] ints)
        {
            int najmanji = ints[0];

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < najmanji)
                {
                    najmanji = ints[i];
                }
            } 

            return "Najmanji broj u nizu je: " + najmanji.ToString(); 
        }

        private static string NajveciBroj(int[] ints)
        {
            int najveci = ints[0];

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > najveci)
                {
                    najveci = ints[i];
                }
            }

            return "Najveci broj u nizu je: " + najveci.ToString();
        }

        private static string Prosjek(int[] ints)
        {

            double prosjek = Queryable.Average(ints.AsQueryable()); 
           
            return "Prosjek: " + prosjek.ToString();
        }

    }
}
