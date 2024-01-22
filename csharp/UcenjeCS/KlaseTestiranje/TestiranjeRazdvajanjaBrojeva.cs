using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KlaseTestiranje
{
    internal class TestiranjeRazdvajanjaBrojeva
    {
        public static void Izvedi()
        {

            int[] Niz = { 5, 10, 4, 37, 22, 15 };


            int[] Niz2 = SplitTwoDigitNumberInArray(Niz);



            Console.WriteLine("Niz: " + string.Join(", ", Niz));
            Console.WriteLine("Niz 2 nakon izmjene: " + string.Join(", ", Niz2));


            Console.ReadLine();
        }


        private static int[] SplitTwoDigitNumberInArray(int[] stari)
        {
            int dvoznambroj = Array.FindIndex(stari, n => n >= 10 && n <= 99);
            int[] noviNiz = new int[stari.Length + 1];

            if (dvoznambroj == Array.FindIndex(stari, n => n >= 10 && n <= 99))
            {

                if (dvoznambroj == -1)
                {
                    return stari;
                }


                int brojDvijeZnam = stari[dvoznambroj];
                int dvoznamenkasti = brojDvijeZnam / 10;
                int jednoznamenkasti = brojDvijeZnam % 10;





                Array.Copy(stari, noviNiz, dvoznambroj);


                noviNiz[dvoznambroj] = dvoznamenkasti;


                noviNiz[dvoznambroj + 1] = jednoznamenkasti;


                Array.Copy(stari, dvoznambroj + 1, noviNiz, dvoznambroj + 2, stari.Length - dvoznambroj - 1);
            }


            return SplitTwoDigitNumberInArray(noviNiz);
        }

    }
}
