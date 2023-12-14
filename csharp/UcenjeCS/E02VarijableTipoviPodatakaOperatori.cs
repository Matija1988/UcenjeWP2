using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        public static void izvedi()
        {
            int Varijabla = 3;

            Console.WriteLine(Varijabla);

            if (Varijabla == 3)
            {
                Console.WriteLine("Tri puta je tri puta");

            }

            int i=1, j=0, k;

            Console.WriteLine("{0},{1}", i,j);

            bool Istina = i == 1;

            Console.WriteLine(Istina);

            double Broj = 5.75;
            decimal DeciBroj = 2.99M;

            Console.WriteLine(int.MaxValue);
            int Mb = int.MaxValue;
            Console.WriteLine(Mb + 1);

            i = 3; j = 2; k =1;

            Console.WriteLine(i + j);
            Console.WriteLine(i - j);
            Console.WriteLine(i * j);
            Console.WriteLine(i / j);
            Console.WriteLine((float) i / j);

            int db = 46;

            Console.WriteLine(db / 10);

            bool uvjet = i > j;
            uvjet = i >= j;
            uvjet = i <= j;
            uvjet = i < j;
            uvjet = i > j;
            uvjet = i == j;
            uvjet = i != j;

            //operator modulo - ostatak nakon cjelobrojnog djelenja 

            int ostatak = 9 % 2;

            Console.WriteLine(ostatak);

            Console.WriteLine(52 % 10);

            i = 1;
            Console.WriteLine(i);
            i = i + 1;
            Console.WriteLine(i);
            i += i + 1;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);

            // prvo koristi trenutnu vrijednost pa onda uveca
            Console.WriteLine(i++);
            Console.WriteLine(i);
            // ++i prvo uveca pa onda koristi

            Console.WriteLine(++i);

            int t = 1, l = 2;

            t = ++t - l; // 0
            l -= t - l; // -2 
            Console.WriteLine(++t - --l); // 0


        }

     
    }
}
