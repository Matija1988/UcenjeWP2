using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacija.Model;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    internal class Program
    {
        private List<Smjer> Smjerovi;
        private List<Predavac> Predavaci;
        private List<Polaznik> Polaznici;

        public Program() {


            Smjerovi  = new List<Smjer>();
            Predavaci = new List<Predavac>();
            PozdravnaPoruka();
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("\n" + "Izbornik" + "\n" + "*********************");
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
                    Console.WriteLine("\n" + "Izabrali ste rad s smjerovima" + "\n" + "*********************");
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
                    IzbornikRadSGrupama(); 
                    break;
                case 5:
                    Console.WriteLine("Izlaz iz programa");
                    Environment.Exit(0);
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

            try { 
            Smjerovi.RemoveAt(Pomocno.UcitajInt("Odaberi smjer za brisanje: ") - 1);
            }
            catch {

                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!! " + "Ne postoji smjer pod odabranom sifrom" + " !!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! " + " Provjerite ispravnost svoga unosa" + " !!!!!!!!!!!!!!!!!!!!!!!!");
                IzbrisiSmjer(); 
                
            }
            IzbornikRadSaSmjerovima();
        }

        private void UrediSmjer()
        {
            PrikaziSmjerove();

            try { 
            var s = Smjerovi[Pomocno.UcitajInt("Odaberi smjer za promjenu: ") - 1];
            s.Sifra = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n"  + "Stara sifra: " + s.Sifra + "\n" + "Unesi promijenjenu sifru: ");
            s.Naziv = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stara sifra: " + s.Naziv + "\n" +  "Unesi promijenjeni naziv: ");
            s.BrojSati = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n" + "Stara broj sati: " + s.BrojSati + "\n"+ "Unesi novi broj sati: "); 
            s.Cijena = Pomocno.UcitajFloat("\n" + "_______________________________________" + "\n" + "Stara sifra: " + s.Cijena + "\n" + "Unesi promijenjenu cijenu: "); 
            s.Upisnina = Pomocno.UcitajFloat("\n" + "_______________________________________" + "\n" + "Stara upisnina: " + s.Upisnina + "\n" + "Unesi novu upisninu: ");
            s.Verificiran = Pomocno.UcitajBool("\n" + "_______________________________________" + "\n" + "Staro stranje: " + s.Verificiran + "\n" + "Novo stanje: ");
            } 
            catch {

                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!! " + "Ne postoji smjer pod odabranom sifrom" + " !!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! " + " Provjerite ispravnost svoga unosa" + " !!!!!!!!!!!!!!!!!!!!!!!!");
                UrediSmjer();

            }
         
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
                Sifra = Pomocno.UcitajInt("Unesi sifru smjera: "),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera: "),
                BrojSati = Pomocno.UcitajInt("Broj sati: "),
                Cijena = Pomocno.UcitajFloat("Unesi cijenu smjera: "),
                Upisnina = Pomocno.UcitajFloat("Unesi upisninu: "),
                Verificiran = Pomocno.UcitajBool("Verificirani tecaj: " + "\n" + "1) Verificiran" + "\n" + "2) Neverificiran" + "\n" + "Izbor: ")


            }); 

            IzbornikRadSaSmjerovima();
        }

        private void IzbornikRadSPredavacima()
        {
            Console.WriteLine("\n" + "Izbornik predavaci" + "\n" + "*************************");
            Console.WriteLine("1. Prikazi sve predavace");
            Console.WriteLine("2. Dodaj predavaca");
            Console.WriteLine("3. Uredi predavaca");
            Console.WriteLine("4. Izbrisi predavaca");
            Console.WriteLine("5. Povratak na glavni izbornik");

          OdabirIzbornikRadSPredavacima();

        }

        private void OdabirIzbornikRadSPredavacima()
        {
            switch (Pomocno.UcitajInt("Unesite svoj izbor: "))
            {
                case 1:
                    Console.WriteLine("\n"+"Prikazujem sve predavace" + "\n");
                    PrikaziPredavace();
                    IzbornikRadSPredavacima();
                    break;
                case 2:
                    Console.WriteLine("\n"+"Dodajem predavaca" + "\n");
                    DodajNovogPredavaca(); 
                    break;
                case 3:
                    Console.WriteLine("\n" + "Uredujem predavaca" + "\n");
                    UrediPredavaca(); 
                    break;
                case 4:
                    Console.WriteLine("\n" + "Brisem predavaca" + "\n");
                    IzbrisiPredavaca(); 
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

        private void IzbrisiPredavaca ()
        {
            try { 
            Predavaci.RemoveAt(Pomocno.UcitajInt("Izbrisi predavaca: ") -1);
            } catch
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!! " + "Ne postoji predavac pod odabranom sifrom" + " !!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! " + " Provjerite ispravnost svoga unosa" + " !!!!!!!!!!!!!!!!!!!!!!!!");
                IzbrisiPredavaca();
            }
            IzbornikRadSPredavacima();
        }

        private void UrediPredavaca()
        {
            PrikaziPredavace();

            try
            {
                var p = Predavaci[Pomocno.UcitajInt("Odaberi predavaca za izmjene: ") - 1];
                p.Sifra = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n"  + "Stara sifra: " + p.Sifra + "\n" + "Unesi promijenjenu sifru: ");
                p.Ime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro ime: " + p.Ime + "\n" + "Unesi promijenjeno ime: ");
                p.Prezime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro prezime: " + p.Prezime + "\n" + "Unesi promijenjeno prezime: ");
                p.Oib = Pomocno.UcitajOIB("\n" + "_______________________________________" + "\n" + "Stari OIB: " + p.Oib + "\n" + "Unesi promijenjeni OIB: ");
                p.Email = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari email: " + p.Email + "\n" + "Unesi promijenjeni email: ");
                

            } catch 
            {

                Console.WriteLine("!!!!!!!!!!!!!!!!!!! " + "Ne postoji predavac pod odabranom sifrom" + " !!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! " + " Provjerite ispravnost svoga unosa" + " !!!!!!!!!!!!!!!!!!!!!!!!");
                UrediPredavaca();
            }
            IzbornikRadSPredavacima();
        }

        private void PrikaziPredavace()
        {
            var i = 0;
            Predavaci.ForEach(p => { Console.WriteLine(++i + ". " + p); });
        }

        private void DodajNovogPredavaca ()
        {
            Predavaci.Add(new Predavac()
            {
                Sifra = Pomocno.UcitajInt("Unesi sifru: "),
                Ime = Pomocno.UcitajString("Unesi ime predavaca: "),
                Prezime = Pomocno.UcitajString("Unesi prezime predavaca: "),
                Oib = Pomocno.UcitajOIB("OIB: "),
                Email = Pomocno.UcitajString("Email: ") 

            }); 

            IzbornikRadSPredavacima(); 
        }

        private void IzbornikRadSPolaznicima()
        {
            Console.WriteLine("\n" + "Izbornik polaznici" + "\n" + "**************");
            Console.WriteLine("1. Prikazi sve polaznike");
            Console.WriteLine("2. Dodaj polaznika");
            Console.WriteLine("3. Uredi polaznika");
            Console.WriteLine("4. Izbrisi polaznika");
            Console.WriteLine("5. Povratak na glavni izbornik");

            OdabirRadSPolaznicima();
        }

        private void OdabirRadSPolaznicima()
        {
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

        private void IzbornikRadSGrupama()
        {
            Console.WriteLine("\n" + "Izbornik grupe" + "\n" + "**************");
            Console.WriteLine("1. Prikazi sve grupe");
            Console.WriteLine("2. Dodaj grupu");
            Console.WriteLine("3. Uredi grupu");
            Console.WriteLine("4. Izbrisi grupu");
            Console.WriteLine("5. Povratak na glavni izbornik");

            OdabirRadSGrupama();
        }

        private void OdabirRadSGrupama ()
        {
            switch (Pomocno.UcitajInt("Unesite svoj izbor: "))
            {
                case 1:
                    Console.WriteLine("Prikazujem sve grupe");
                    break;
                case 2:
                    Console.WriteLine("Dodajem grupu");
                    break;
                case 3:
                    Console.WriteLine("Uredujem grupu");
                    break;
                case 4:
                    Console.WriteLine("Izbrisi grupu");
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
