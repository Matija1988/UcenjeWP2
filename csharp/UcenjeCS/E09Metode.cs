using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09Metode
    {

        public static void Izvedi()
        {
            // do OPP-a sve metode ce biti static u ovom projektu Ucenje CS
            // Poziv metode 
            Tip1();
            Tip2(2, 12);
            
            // kljucna rijec var uzima tip podatka s desne strane
            var i = ImeRacunala();  // tip 3
            Console.WriteLine(i);
            // bolje
            Console.WriteLine(ImeRacunala());
        }

        // 1. vrsta tipa void, ne prima vrijednost, prima praznu listu parametara
        // Tijelo metode 
        static void Tip1()
        {

            Console.WriteLine("Hello iz tip 1");

        }

        // 2. vrsta tipa void, prima parametre 

        static void Tip2(int Od, int Do)
        {

            // ispisite sve parne broje izmedu 2 primljena parametra 

            for (int i = Od; i < Do; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            // short circut petlje 
            //for (int i = Od; i < Do; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
        }

        // 3. vrsta: odredenog tipa koji vraca pozivatelju i ne prima parametre

        static string ImeRacunala()
        {

            return System.Net.Dns.GetHostName(); 
        } 


    }


}


