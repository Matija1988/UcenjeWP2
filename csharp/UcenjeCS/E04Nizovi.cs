using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Nizovi
    {
        public static void Izvedi()
        {
            int[] Temperature = new int[12];
            // prvi element niza je na indexu nula 
            // sijecanj
            Temperature[0] = 2;
            // veljaca
            Temperature[1] = 1;
            // ...
            Temperature[11] = 7;

            Console.WriteLine(Temperature);
            Console.WriteLine(string.Join(",", Temperature));

            // visediomenzionalni nizovi

            int[,] tablica = { 
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            
            };

            Console.WriteLine(tablica[1,1]);
            Console.WriteLine(tablica[2,2]);

            // trodimenzionalni niz kocka

            int[,,] Kocka;

            // Zvijezdane staze

            int[,,,,,,] ZvjezdaneStaze; 


        }

    }
}
