using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07DoWhile
    {

        public static void Izvedi()
        {

            // da li se u fot i while petlje mora uci? NE
            // Ako uvje na pocetku nije zadovoljen ne ulazi se 

            // do while osigurava minimalno jedno izvodenje
            // uvjet je na kraju petlje 


            do
            {
                Console.WriteLine("Edunova");

            } while (false);

            // continue, break i nesting isto kao kao i for i while 

            Console.WriteLine("-----------------------------");
            
            // prekidanje vanjske petlje

            for(; ;  )
            {
                while (true)
                {
                    do
                    {

                        //break; // 1
                        // kako prekinuti vanjski for
                        goto nakonfor; 
                    } while (true);

                    // ovdje se nastavlja 1

                    break; // 2
                }
                // ovdje se nastavlja 2

            }
            nakonfor: // : oznacava tekst kao  label // ovo se smatra losim kodom
            Console.WriteLine("Odradio");

        }


    }
}
