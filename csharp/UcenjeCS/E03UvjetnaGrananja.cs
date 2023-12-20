using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnaGrananja
    {

        public static void Izvedi()
        {
            int i = 7;

            bool uvjet = i == 7;

            if (uvjet)
            {
                Console.WriteLine("The value is true");
            }

            if (i == 7)
            {
                Console.WriteLine("Isti uvjet kao i prethodno");

            } else
            {
                Console.WriteLine("The value is false");
            }

            if (i < 5) Console.WriteLine("Uvjet je manji od 5");

            else Console.WriteLine("I nije manje od 5");

            if (i == 2)
            {
                Console.WriteLine("I = 2");

            } else if (i == 3)
            {
                Console.WriteLine("I = 3");
            }
            else
            {
                Console.WriteLine("I nije 2 niti je 3");
            }

            int j = 2;
            if (i == 7)
            {
                if (j == 2) {
                    Console.WriteLine("Oba uvjeta su zadovoljena, nested");
                }
            }

            if (i == 7 & j == 2)
            {
                Console.WriteLine("Oba uvjeta su zadovoljena");
            }
            // ako padne prvi uvjet provjerava se drugi

            if (i == 7 && j == 2)
            {
                Console.WriteLine("Oba uvjeta su zadovoljena");
            }
            // ukoliko ako padne na prvom uvjetu ne provjerava se drugi

            if ((i == 5) | j == 1)
            {
                Console.WriteLine("Dovoljno je da je jedan od uvjeta zadovoljen");
            }
            // | provjeraba oba uvjeta bez obzira ako je prvi prosao

            if (i == 5 || j == 1)
            {
                Console.WriteLine("Prvi uvjet zadovoljen, drugi se ne provjerava");
            }

            // || ukoliko prvi uvjet dode drugi se ne provjerava

            if ((i == 4 || j == 1) && !(i > 5 || j < 8))
            {
                Console.WriteLine("Komplicirani izraz");
            }

            Console.Write("Upisi cijeli broj: ");
            int x = int.Parse(Console.ReadLine());

            if (x > 10)
            {
                Console.WriteLine("Osijek");
            } else
            {
                Console.WriteLine("Zagreb");
            }
            // u slucaju istog ponasanja s razlicitim vrijednostima u if 
            // mozemoi pisati krace

            // inline if
            Console.WriteLine(i > 10 ? "Osijek" : "Zagreb");


            // visestruko grananje
            int ocjena = 4;

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    case 3:
                    Console.WriteLine("Dovoljno ili dobro");
                    break;
                case 4: case 5:
                    Console.WriteLine("To je ocjena");
                    break;  
                    default: Console.WriteLine("Nije ocjena");
                    break;
            }

            string ime = "Pero";
            switch (ime) {
                case "Marko":
                    Console.WriteLine("OK");
                    break;
                case "Pero":
                    Console.WriteLine("Super");
                    break;
            }


        }




    }
}
