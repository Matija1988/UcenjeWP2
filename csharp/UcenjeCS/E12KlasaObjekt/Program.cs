using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Program
    {
        public static void Izvedi()
        {
            // Objekt je pojavnost (istanca) klase
            // najcesci nacin deklaracije
            // umjesto Osoba osoba = new Osoba();
            
            Osoba o = new Osoba();

            Grad g = new()
            {
                //Naziv= "Osijek",
                BrojStanovnika = 100000
            };

            o.Grad = g;

            Console.WriteLine(o.Grad?.Naziv);

        }

        private static void E04LjubavniPoziv()
        {
            Ljubav ljubav = new(); // s new se poziva konstruktor


            ljubav.PrvoIme = Unos("Unesi ime prve osobe: ");
            ljubav.DrugoIme = Unos("Unesi ime druge osobe: ");

            Console.WriteLine(ljubav.Rezultat());

            Console.WriteLine(new Ljubav(Unos("PI"), Unos("DI")).Rezultat());
        }

        private static string Unos(string poruka)
        {

            string unos; 
            for(; ; ) { 
            Console.WriteLine(poruka);
            unos = Console.ReadLine();
                if(unos.Trim().Length == 0 )
                {
                    Console.WriteLine("Unos obavezan");
                    continue;
                }

            return unos;

            }
        }

        private static void E03Najcesce()
        {
            Osoba osoba = new();

            var pjevac = new Osoba();

            //pjevac.Ime = "Mirko";

            Console.WriteLine(pjevac.Ime?.Substring(0, 1));
        }

        public static void E02DrugaSintaksa() 
        {
            Osoba o = new Osoba
            {
                Ime = Console.ReadLine(),
                Prezime = Console.ReadLine()
            };

            Console.WriteLine(o.ImePrezime());

        }

        private static void E01OsnovnaSintaksa()
        {
            Osoba osoba = new Osoba();

            osoba.Ime = "Perica";
            osoba.Prezime = "Peric";

            Console.WriteLine(osoba.Ime);
        }
    }
}
