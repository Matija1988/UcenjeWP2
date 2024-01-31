using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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

        internal static float UcitajFloat (string v)
        {
            while (true)
            {
                Console.Write(v);
                try
                {
                    float a = float.Parse(Console.ReadLine());
                    return a;

                }
                catch
                {
                    Console.WriteLine("Krivi unos");
                }

            }
        }

        internal static bool UcitajBool (string v)
        {
            while (true)
            {
                Console.Write(v);
                try
                {
                    int a = int.Parse(Console.ReadLine());

                 

                    switch (a)
                    {
                        case 1: 
                            return true;
                          
                            case 2:
                            return false;

                            default:
                            Console.WriteLine("Krivi unos!");
                            break;
                    }

                 
                }
                catch
                {
                    Console.WriteLine("Krivi unos");
                }

            }

        }
        
        internal static string UcitajOIB (string v)
        {
            string oib;
            
           
            while (true)
            {
                
                Console.Write(v);
                oib = Console.ReadLine();
                bool prolaz = true;
                foreach (char c in oib)
                {
                    if(!char.IsNumber(c) && !char.IsDigit(c) && !char.IsControl(c))
                    {
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! UNOSITE SAMO BROJEVE !!!!!!!!!!!!!!!!!!!!!!!");
                        prolaz = false; 
                        break; 
                    }
                  
                }

                

                if (oib.Length == 11 && prolaz == true)
                {
                   
                    return oib;
                } else
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!! " + "Obavezan unos " + "!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("!!!!!!!!!!!!!!! " + "Provjerite ispravnost svog unosa" + " !!!!!!!!!!!!!!!!");
                    
                }

                
            }
        }

        internal static DateTime UcitajDatum (string v)
        {
            while (true)
            {
                try
                {
                    Console.Write(v);
                    return DateTime.Parse(Console.ReadLine());

                }
                catch (Exception ex){
                    Console.WriteLine("!!!!!!!!!!!!!!! " + "Provjerite ispravnost svog unosa" + " !!!!!!!!!!!!!!!!");

                }
            }
        }

        internal static int UcitajRasponBrojeva (string poruka, int pocetakNiza, int krajNiza)
        {
            int b;

            while (true)
            {
                Console.Write(poruka);
                try
                {
                    b = int.Parse(Console.ReadLine());
                    if(b >= pocetakNiza && b <= krajNiza)
                    {
                        return b;
                    }
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! POGRESKA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("!!!!!!!!!!!!!!! " + "Provjerite ispravnost svog unosa" + " !!!!!!!!!!!!!!!!");

                } catch 
                {

                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! POGRESKA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("!!!!!!!!!!!!!!! " + "Provjerite ispravnost svog unosa" + " !!!!!!!!!!!!!!!!");

                }

            }

        }
    }
}
