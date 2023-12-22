using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void od1do100()
        {
            Console.WriteLine("************ od 1 do 100 *********");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i + 1 + " ");
            }
        }

        public static void od100do1()
        {
            Console.WriteLine("********* od 100 do 1 ***********");
            for (int i = 100; i > 0; i--)
            {
                Console.Write(i + " ");
            }
        }

        public static void modulo()
        {
            Console.WriteLine("******************* modulo 7 *********");

            for (int i = 0; i < 101; i++)
            {
                if (i == 0) continue;
                if (i % 7 == 0) Console.Write(i + " ");

            }
        }

        public static void veciOd100()
        {
            Console.WriteLine("****************** veci od 100 **********");
            int counter = 1;
            
            
            Console.Write("Unesi broj: ");
            for(; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if(n < 100)
                {
                    counter++;
                    
                } else
                {
                    Console.WriteLine("Korisnik je imao " + counter + " unosa");
                    break;
                }
            }
            
            
            
            


        }
    }
}
