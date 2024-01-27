using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    internal class Pomocno
    {

        public static string UcitajString(string Poruka)
        {
            string s;
            while (true)
            {
                Console.Write(Poruka);
                s = Console.ReadLine(); 
                if(s.Trim().Length == 0) 
                { 
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s; 
            }


        }

        public static int UcitajInt(string v) 
        
        {
            while (true) {
                Console.Write(v);
                try
            {
                int a = int.Parse(Console.ReadLine());
                    return a;

                } catch
            {
                Console.WriteLine("Krivi unos");
            }

            }

             
        }

    }
}
