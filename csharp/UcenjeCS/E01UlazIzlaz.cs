using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {
        public static void izvedi() 
        {
            //Console.WriteLine("Hello, Matija!");


            //Console.Write("Unesi ime: ");
            //string ime = Console.ReadLine();

            //Console.WriteLine("Pozdrav " + ime);

            //Console.Write("Unesi visine u cm: ");
            //int Visina = int.Parse(Console.ReadLine());
            //Console.WriteLine("Visoki ste " +  (float)Visina / 100   + " metara");

            //float x = float.Parse(Console.ReadLine());

            Console.Write("Unesi duzinu prostorije: ");
            double duzina = double.Parse(Console.ReadLine());
            Console.Write("Unesi sirinu prostorije: ");
            double sirina = double.Parse(Console.ReadLine());
            Console.WriteLine("Povrsina prostorije je: " + duzina * sirina);

        }
    }
}
