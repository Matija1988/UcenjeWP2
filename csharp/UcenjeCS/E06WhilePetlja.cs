using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06WhilePetlja
    {
        public static void Izvedi()

        {
            bool uvjet = true;

            int i = 0;

            while (uvjet)
            {
                Console.WriteLine(i);

                uvjet = ++i < 10;
            }

            Console.WriteLine("-----------------------------");

            i = 0;

            while (i++ < 10)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------");

            // continue 

            i = 0;

            while (++i < 10) {

                if (i == 2) // prilikom ispisa preskace se vrijednost 2
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------");

            // break
            while (true)
            {
                Console.WriteLine("Edunova");
                break; // 1 ispis
            }
            Console.WriteLine("-----------------------------");

            // nesting
            i = 0;
            while(++i < 10)
            {
                while(true) { 
                Console.WriteLine(i);
                break;
                }
            }

            // zadatak: Korisnik unosi broj, program ispisuje sve brojeve od unesenog do 100

            Console.WriteLine("Unesi jedan broj");
            int a = int.Parse(Console.ReadLine());

            while (a++ < 100)
            {   
               Console.WriteLine(a);
                
            }
            while (a-- > 100)
            {
                Console.WriteLine(a);

            }




        }

    }


}

    

