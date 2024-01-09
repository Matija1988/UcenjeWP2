using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08ForEach
    {
        public static void Izvedi()
        {

            int[] niz = { 1, 2, 3 }; 

            for(int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }

            Console.WriteLine("-----------------------------");
            // gornji kod je ekvivalent donjem
            foreach(int element in niz)
            { Console.WriteLine(element); }

            // sve ostale znacajke petlji jednako funkcioniraju 

            Console.WriteLine("-----------------------------");

            string ime = "Edunova a";

            Console.WriteLine(ime);

            foreach(char c in ime) { Console.WriteLine(c + ":  " + (int)c); }

            Console.WriteLine("-----------------------------");

            // Korisnik unosi teskt a program ispisuje koje slovo je unio koliko puta
            Console.Write("Unesi tekst: ");
            string input = Console.ReadLine();

            int[] slova = new int[input.Length];
            int index = 0;
            int ukupno = 0;


            foreach (char c in input)
            {
                ukupno = 0;
                foreach(char cc in input)
                {
                    if(c == cc)
                    {
                        ukupno++;
                    }

                }
                slova[index++] = ukupno;
            }

            Console.WriteLine(string.Join(",", slova));

            char[] JedinstvenaSlova = new char[input.Length]; // ne treba toliko prostora, ali treba deklarirat velicinu niza

            bool postoji;
            index = 0;

            foreach (char c in input)
            {
                postoji = false;

                foreach (char cc in JedinstvenaSlova)
                {
                    if (c == cc)
                    {
                        postoji = true;
                        break;
                    }

                }

                if(!postoji)
                {
                    JedinstvenaSlova[index++] = c;
                }

            }
            Console.WriteLine(string.Join(",", JedinstvenaSlova));

            foreach(char c in JedinstvenaSlova)
            {
                Console.Write(c + " ");
                index = 0;

                foreach(char cc in input)
                {
                    if(c == cc)
                    {
                        Console.WriteLine(slova[index]);
                        break; 
                    }
                    index++; 
                }
            }


        }
        

    }
}
