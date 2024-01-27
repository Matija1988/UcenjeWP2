using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacija.Model;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    internal class Program
    {
        private List<Smjer> Smjerovi;

        public Program() {


            Smjerovi  = new List<Smjer>();
            PozdravnaPoruka();
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("\n" + "Izbornik" + "\n" + "****************");
            Console.WriteLine("1. Rad sa smjerovima");
            Console.WriteLine("2. Rad s predavacima");
            Console.WriteLine("3. Rad s polaznicima");
            Console.WriteLine("4. Rad s grupama");
            Console.WriteLine("5. Izlaz programa");
            OdabirStavkeIzbornika();
            
        }

        private void OdabirStavkeIzbornika()
        {

            switch (Pomocno.UcitajInt("Unesite svoj izbor: "))
            {

                case 1:
                    Console.WriteLine("Izabrali ste rad s smjerovima" + "\n" + "*********************");
                    IzbornikRadSaSmjerovima(); 
                    break;
                case 2:
                    Console.WriteLine("Izabrali ste rad s predavacima");
                    IzbornikRadSPredavacima(); 
                    break;
                case 3:
                    Console.WriteLine("Izabrali ste rad s polaznicima");
                    IzbornikRadSPolaznicima(); 
                    break;
                case 4:
                    Console.WriteLine("Izabrali ste rad s grupama");
                    break;
                case 5:
                    Console.WriteLine("Izlaz iz programa");
                    break;
                default:
                   Console.WriteLine("Krivi odabir");
                    Izbornik();
                    break;
            }

        }

       

        private void IzbornikRadSaSmjerovima()
        {
            Console.WriteLine("\n" + "Izbornik smjerovi" + "\n" + "*******************");
            Console.WriteLine("1. Prikazi sve smjerove");
            Console.WriteLine("2. Dodaj smjer");
            Console.WriteLine("3. Uredi smjer");
            Console.WriteLine("4. Izbrisi smjer");
            Console.WriteLine("5. Povratak na glavni izbornik");

            OdabirStavkeIzbornikSmjera(); 
        
        }

        private void OdabirStavkeIzbornikSmjera()
        {
            switch (Pomocno.UcitajInt("Unesite svoj izbor: "))
            {
                case 1:
                    Console.WriteLine("\n" + "Prikazujem sve smjerove:" + "\n");
                    PrikaziSmjerove();
                    IzbornikRadSaSmjerovima();
                    break;
                case 2:
                    Console.WriteLine("Dodajem smjer:" + "\n");
                    DodajNoviSmjer();
                    
                    break;
                case 3:
                    Console.WriteLine("Uredujem smjer:" + "\n");
                    UrediSmjer(); 
                    break;
                case 4:
                    Console.WriteLine("Smjer izbrisi:" + "\n");
                    IzbrisiSmjer(); 
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("Krivi unos!!!!!" + "\n");
                    IzbornikRadSaSmjerovima();
                    break;
            }
        }

        private void IzbrisiSmjer()
        {
            PrikaziSmjerove();
            Smjerovi.RemoveAt(Pomocno.UcitajInt("Odaberi smjer za brisanje: ") - 1);
            IzbornikRadSaSmjerovima();
        }

        private void UrediSmjer()
        {
            PrikaziSmjerove();
            var s = Smjerovi[Pomocno.UcitajInt("Odaberi smjer za promjenu: ") - 1];
            s.Sifra = Pomocno.UcitajInt(s.Sifra + " Unesi promijenjenu sifru: ");
            s.Naziv = Pomocno.UcitajString(s.Naziv + " Unesi promijenjeni naziv: ");
            // promijeniti ostale vrijednosti
            IzbornikRadSaSmjerovima();
        }

        private void PrikaziSmjerove()
        {
            var i = 0;
            Smjerovi.ForEach(smi => { Console.WriteLine(++i + ". " + smi); });
         
        }
        private void DodajNoviSmjer()
        {
            Smjerovi.Add(new Smjer()
            {
                Sifra = Pomocno.UcitajInt("Unesi sifru smjera: " ),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera: "),
                // Ucitati ostale vrijednosti
                
            });

            IzbornikRadSaSmjerovima();
        }

        private void IzbornikRadSPredavacima()
        {
            Console.WriteLine("Izbornik smjerovi" + "\n" + "*************************");
            Console.WriteLine("1. Prikazi sve predavace");
            Console.WriteLine("2. Dodaj predavaca");
            Console.WriteLine("3. Uredi predavaca");
            Console.WriteLine("4. Izbrisi predavaca");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Pomocno.UcitajInt("Unesite svoj izbor: "))
            {
                case 1:
                    Console.WriteLine("Prikazujem sve predavace" + "\n");
                    break;
                case 2:
                    Console.WriteLine("Dodajem predavaca" + "\n");
                    break;
                case 3:
                    Console.WriteLine("Uredujem predavaca" + "\n");
                    break;
                case 4:
                    Console.WriteLine("Izbrisi predavaca" + "\n");
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("Krivi unos");
                    IzbornikRadSPredavacima();
                    break;
            }

        }

        private void IzbornikRadSPolaznicima()
        {
            Console.WriteLine("Izbornik polaznici" + "\n" + "**************");
            Console.WriteLine("1. Prikazi sve polaznike");
            Console.WriteLine("2. Dodaj polaznika");
            Console.WriteLine("3. Uredi polaznika");
            Console.WriteLine("4. Izbrisi polaznika");
            Console.WriteLine("5. Povratak na glavni izbornik");

            switch (Pomocno.UcitajInt("Unesite svoj izbor: "))
            {
                case 1:
                    Console.WriteLine("Prikazujem sve polaznike");
                    break;
                case 2:
                    Console.WriteLine("Dodajem polaznika");
                    break;
                case 3:
                    Console.WriteLine("Uredujem polaznika");
                    break;
                case 4:
                    Console.WriteLine("Izbrisi polaznika");
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("Krivi unos");
                    IzbornikRadSPolaznicima();
                    break;
            }
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*+********************************");
            Console.WriteLine("* EDUNOVA KONZOLNA APLIKACINA v1 *");
            Console.WriteLine("**********************************");
        }
    }
}
