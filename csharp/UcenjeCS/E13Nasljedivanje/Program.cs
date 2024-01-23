using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Program
    {

        public static void Izvedi()
        {
            var p = new Polaznik()
            {
                Sifra = 1,
                Ime = "Pero",
                Prezime = "Peric",
                OIB = "12345678911",
                Email = "email",
                BrojUgovora = "24 / 2024 IP.KK"
            };

            Console.WriteLine(p.Sifra); 

            var pr1 = new Predavac();

            pr1.Ime = "Mario";

            var pr2 = new Predavac();

            pr2.Ime = "Mario";

            Console.WriteLine((pr1 == pr2) + " " + pr1.GetHashCode() + " /// " + pr2.GetHashCode());

        }


    }
}
