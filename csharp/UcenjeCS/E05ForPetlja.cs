using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05ForPetlja
    {
        public static void Izvedi()
        {
            // ispisati 10 puta Edunova
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Edunova");
            }
            int t; 
            for (t=0; t < 10; t++)
            {
                Console.WriteLine("Edunova T");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }

            for(int i = 10;  i > 0; i--)
            {
                Console.WriteLine(i); 
            }
            
            for(int i = 0; i < 20; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**********************");

            int ukpb = 78;
            int ukdb = 24; 

            int manji = ukpb < ukdb ? ukpb : ukdb;
            int veci = ukpb > ukdb ? ukpb : ukdb;

            if(manji == veci)
            {
                Console.WriteLine("Unijeli ste iste brojeve. Nema ispisa " +
                    "parnih brojeva");
            }

            for (int i = manji; i <= veci; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("+++++++++++++++++++++");
            for (int i = 0; i < 10; i++ )
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write((i+1) * (j+1) + " ");
                }
                Console.WriteLine();
                //DZ popraviti formatiranje
                //DZ nasilno prekinuti iz unutarnje petlje prekinuti vanjsku
            }
            Console.WriteLine("******************");
            for (int i = 0; i < 10; ++i )
            {
                if(i % 3 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            // petlja se moze nasilno prekinuti 
            Console.WriteLine("******************");
            for (int i = 0; i <10; i ++)
            {
                if(i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            //for(; ;  )
            //{
            //    Console.WriteLine(new Random().Next(10,100));
            //    Thread.Sleep(50);
            //}

            // Za uneseni broj izmedu 1 i 10 ispisi taj broj na kvadrat
            Console.WriteLine("******************");
            int broj; 

            for(; ;  )
            {
                Console.WriteLine("Unesi broj izmedu 1 i 10");
                broj =  int.Parse(Console.ReadLine());

                if(broj >= 1 && broj <= 10) { break; }
                Console.WriteLine("Krivi unos");
            }




            // Kraj metode
        }
    }
}
