using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16Lambda
{
    internal class Program
    {

        public Program() 
        {

            Console.WriteLine(KlasicnaMetoda(3));

            var kvadrat = (int b) =>  b* b;

            Console.WriteLine(kvadrat(3));

            var algoritam =(int x, int y) => 
                { 
            
            var t = x++ - y;
                    return x + y + t;
            
            };

            Console.WriteLine(algoritam(2,3));

            var list = new List<Smjer>()
            {
                new Smjer() { naziv = "prvi" },
                new Smjer() { naziv = "drugi" },

            };

            list.ForEach(s => Console.WriteLine(s.naziv));

            list.ForEach(Console.WriteLine);

        }




        private int KlasicnaMetoda(int b) { return b*b; }



    }
}
