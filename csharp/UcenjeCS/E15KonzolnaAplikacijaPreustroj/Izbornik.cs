﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacijaPreustroj
{
    internal class Izbornik
    {
        public ObradaSmjer ObradaSmjer { get; }
        public ObradaPredavac ObradaPredavac { get; }

        public ObradaPolaznik ObradaPolaznik { get; }
      
        public Izbornik() 
        
        {
            ObradaSmjer = new ObradaSmjer();    
            ObradaPredavac = new ObradaPredavac();
            ObradaPolaznik = new ObradaPolaznik();

            PozdravnaPoruka(); 
            
        }
        public void PozdravnaPoruka ()
        {
            Console.WriteLine("*+********************************");
            Console.WriteLine("* EDUNOVA KONZOLNA APLIKACIJA v1 *");
            Console.WriteLine("**********************************");

            GlavniIzbornik();
            Izbornik Izbornik = new Izbornik();
        }
        public void GlavniIzbornik ()
        {
         
            Console.WriteLine("\n" + "Izbornik" +
                              "\n" +
                              "*****************************************************************");
            Console.WriteLine("1. Rad sa smjerovima");
            Console.WriteLine("2. Rad s predavacima");
            Console.WriteLine("3. Rad s polaznicima");
            Console.WriteLine("4. Rad s grupama");
            Console.WriteLine("5. Izlaz programa");

            OdabirStavkeIzbornika();
            

        }

        private void OdabirStavkeIzbornika ()
        {
           

            switch (Pomocno.UcitajInt("Unesite svoj izbor: "))
            {

                case 1:
                    Console.WriteLine("\n" + "Izabrali ste rad s smjerovima" +
                                      "\n" +
                                      "*****************************************************************");
                    ObradaSmjer.IzbornikRadSaSmjerovima();
                    break;
                case 2:
                    Console.WriteLine("Izabrali ste rad s predavacima");
                    ObradaPredavac.IzbornikRadSPredavacima();
                    break;
                case 3:
                    Console.WriteLine("Izabrali ste rad s polaznicima");
                    ObradaPolaznik.IzbornikRadSPolaznicima();
                    break;
                //case 4:
                //    Console.WriteLine("Izabrali ste rad s grupama");
                //    IzbornikRadSGrupama();
                //    break;

                case 5:
                    Console.WriteLine("Izlaz iz programa");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    GlavniIzbornik();
                    break;
            }

        }
    }
}
