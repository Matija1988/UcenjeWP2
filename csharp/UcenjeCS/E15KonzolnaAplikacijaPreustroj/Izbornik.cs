using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacijaPreustroj.Model;

namespace UcenjeCS.E15KonzolnaAplikacijaPreustroj
{
    internal class Izbornik
    {
        public ObradaSmjer ObradaSmjer { get; }
        public ObradaPredavac ObradaPredavac { get; }

        public ObradaPolaznik ObradaPolaznik { get; }
        public ObradaGrupe ObradaGrupe { get; }

       
 

        public Izbornik()
        
        {
            Pomocno.dev = true; 
            ObradaSmjer = new ObradaSmjer(this);    
            ObradaPredavac = new ObradaPredavac(this);
            ObradaPolaznik = new ObradaPolaznik(this);
            ObradaGrupe = new ObradaGrupe(this);

           

            PozdravnaPoruka(); 
            
        }


        

        public void PozdravnaPoruka ()
        {
            Console.WriteLine("*+********************************");
            Console.WriteLine("* EDUNOVA KONZOLNA APLIKACIJA v1 *");
            Console.WriteLine("**********************************");
            
            GlavniIzbornik();

           
            
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
                case 4:
                    Console.WriteLine("Izabrali ste rad s grupama");
                    ObradaGrupe.IzbornikRadSGrupama();
                    break;

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
