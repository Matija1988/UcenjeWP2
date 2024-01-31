using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
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
        private List<Grupa> Grupe; 

        public Program() {


            Smjerovi  = new List<Smjer>();
            Predavaci = new List<Predavac>();
            Polaznici = new List<Polaznik>();
            Grupe = new List<Grupa>();

            // hardkodao sam par stavki radi lakseg prolaska kroz funkcije aplikacije

            Predavaci.Add(new Predavac()
            {
                Sifra = 1,
                Ime = "Immanuel",
                Prezime = "Kant",
                Oib = "12345678911",
                Email = "IkantButYouCould@gmail.com",
                IBAN = "HRE 58712353123523"

            });

            Predavaci.Add(new Predavac()
            {
                Sifra = 2,
                Ime = "Friedrich",
                Prezime = "Nietzsche",
                Oib = "12345678912",
                Email = "zaratustra@hotmail.com",
                IBAN = "DE 97771232100001230000"

            });

            Predavaci.Add(new Predavac() 
            { 
                Sifra = 3,
                Ime = "Diogen",
                Prezime = "Prolupali",
                Oib = "12345678913",
                Email = "zaklanjasmisunce@yahoo.com",
                IBAN = "samo kes na ruke"
                        
            });

            Polaznici.Add(new Polaznik()
            {
                Sifra = 1,
                Ime = "Tom",
                Prezime = "Cardy",
                Oib = "12345678914",
                Email = "tomoizaustralije@gmail.com",
                BrojUgovora = "WP2 - 22"


            });

            Polaznici.Add(new Polaznik()
            {
                Sifra = 2,
                Ime = "Ana",
                Prezime = "Anic",
                Oib = "12345678915",
                Email = "ana@gmail.com",
                BrojUgovora = "JP - 132"

            });

            Polaznici.Add(new Polaznik()
            {
                Sifra = 3,
                Ime = "Tomo",
                Prezime = "Tomic",
                Oib = "12345678916",
                Email = "tt@gmail.com",
                BrojUgovora = "WP2 - 12"

            });

            Polaznici.Add(new Polaznik()
            {
                Sifra = 4,
                Ime = "Ivo",
                Prezime = "Ivic",
                Oib = "12345678919",
                Email = "ii@gmail.com",
                BrojUgovora = "WP2 - 11"

            });

            Smjerovi.Add(new Smjer()
            {
                Sifra = 1,
                Naziv = "Web programiranje",
                BrojSati = 220,
                Cijena = 1200,
                Upisnina = 200,
                Verificiran = true, 

            });

            Smjerovi.Add(new Smjer()
            {
                Sifra = 1,
                Naziv = "Java programiranje",
                BrojSati = 225,
                Cijena = 1235,
                Upisnina = 210,
                Verificiran = true,

            });


            PozdravnaPoruka();
            Izbornik();
        }

        private void Izbornik()
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

        private void OdabirStavkeIzbornika()
        {

            switch (Pomocno.UcitajInt("Unesite svoj izbor: "))
            {

                case 1:
                    Console.WriteLine("\n" + "Izabrali ste rad s smjerovima" + 
                                      "\n" +
                                      "*****************************************************************");
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
            Console.WriteLine("\n" + "Izbornik smjerovi" + 
                              "\n" +
                              "*****************************************************************");
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
                
                int a = Pomocno.UcitajInt("Obrisi smjer: ") - 1;

                bool potvrda = Pomocno.UcitajBool("\n" + "Obrisati smjer " + "\n" + Smjerovi[a] + "\n"+ "1) DA / 2) NE | ");
                
                if(potvrda == true) { 

                Smjerovi.RemoveAt(a);

                }


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

                int sifra = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n" + "Stara sifra: " + s.Sifra + "\n" + "Nova sifra: ");
                string naziv = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari naziv: " + s.Naziv + "\n" + "Novi naziv: ");
                int brojSati = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n" + "Stari broj sati: " + s.BrojSati + "\n" + "Novi broj sati: ");
                float cijena = Pomocno.UcitajFloat("\n" + "_______________________________________" + "\n" + "Stara cijena: " + s.Cijena + "\n" + "Nova cijena: ");
                float upisnina = Pomocno.UcitajFloat("\n" + "_______________________________________" + "\n" + "Stara upisnina: " + s.Upisnina + "\n" + "Nova upisnina: ");
                bool verificiran = Pomocno.UcitajBool("\n" + "_______________________________________" + "\n" + "Prijasnja verifikacija: " + s.Verificiran + "\n" + "Nova verifikacija: 1) DA / 2) NE | ");

                bool potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " + "\n" +
                                                  "\n" + "Prijasnji unos: " + s + "\n" +
                                                  "Novi unos: " + naziv + " || " + "Novi broj sati: " + brojSati + " || " + "Nova cijena: " + cijena + " || " + "Nova upisnina: " + upisnina + " || " + "Verificiran: " + verificiran + "\n" +
                                                  "1) DA / 2) NE | ");

                if (potvrda == true)
                {

                    s.Sifra = sifra;
                    s.Naziv = naziv;
                    s.BrojSati = brojSati;
                    s.Cijena = cijena;
                    s.Upisnina = upisnina;
                    s.Verificiran = verificiran;
                }
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
            int sifra = Pomocno.UcitajInt("Unesi sifru smjera: ");

            // provjera ID

                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!! " + " Ova sifra se koristi " + " !!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!! " + " Unesite drugu sifru " + " !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                
           
            Smjerovi.Add(new Smjer()
            {
              
                Sifra = sifra,
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
            Console.WriteLine("\n" + "Izbornik predavaci" + 
                              "\n" +
                              "*****************************************************************");
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
            PrikaziPredavace(); 

            try {

                int a = Pomocno.UcitajInt("Izbrisi predavaca: ") - 1;

                bool potvrda = Pomocno.UcitajBool("\n" + "Obrisati predavaca " + "\n" + Predavaci[a] + "\n" + "    1) DA / 2) NE | ");

                if (potvrda == true)
                {
                    Predavaci.RemoveAt(a);
                }
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

                int sifra = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n" + "Stara sifra: " + p.Sifra + "\n" + "Nova sifra: ");
                string ime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro ime: " + p.Ime + "\n" + "Novo ime: ");
                string prezime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro prezime: " + p.Prezime + "\n" + "Novo prezime: ");
                string oib = Pomocno.UcitajOIB("\n" + "_______________________________________" + "\n" + "Stari OIB: " + p.Oib + "\n" + "Novi OIB: ");
                string email = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari email: " + p.Email + "\n" + "Novi email: ");
                string iban = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari IBAN: " + p.IBAN + "\n" + "Novi IBAN: ");

                bool potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " + "\n" +
                                                  "\n" + "Prijasnji unos: " + p + "\n" +
                                                  "Novi unos: " + ime + " || " + "Novo prezime: " + prezime + " || " + "Novi OIB: " + oib + " || " + "Novi emial: " + email + " || " + "Novi IBAN: " + iban + "\n" +
                                                  "1) DA / 2) NE | ");

                if (potvrda == true)
                {
                    p.Sifra = sifra;
                    p.Ime = ime;
                    p.Prezime = prezime;
                    p.Oib = oib;
                    p.Email = email;
                    p.IBAN = iban;

                }

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
                Email = Pomocno.UcitajString("Email: "), 
                IBAN = Pomocno.UcitajString("IBAN: ")

            }); 

            IzbornikRadSPredavacima(); 
        }

        private void IzbornikRadSPolaznicima()
        {
            Console.WriteLine("\n" + "Izbornik polaznici" + 
                              "\n" +
                              "*****************************************************************");
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
                    Console.WriteLine("\n"+"Prikazujem sve polaznike" + "\n");
                    PrikaziPolaznike();
                    IzbornikRadSPolaznicima(); 
                    break;
                case 2:
                    Console.WriteLine("\n" + "Dodajem polaznika" + "\n");
                    DodajNovogPolaznika(); 
                    IzbornikRadSPolaznicima();
                    break;
                case 3:
                    Console.WriteLine("\n" + "Uredujem polaznika" + "\n");
                    UrediPolaznika(); 
                    break;
                case 4:
                    Console.WriteLine("\n" + "Izbrisi polaznika" + "\n");
                    IzbrisiPolaznika();
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!! KRIVI UNOS !!!!!!!!!!!!!!!!!!!!!");
                    IzbornikRadSPolaznicima();
                    break;
            }
        }

        private void IzbrisiPolaznika ()
        {
            PrikaziPolaznike();


            int a = Pomocno.UcitajInt("Odaberite sifru polaznika kojeg zelite izbrisati: ") - 1;

            bool potvrda = Pomocno.UcitajBool("\n" + "Obrisati polaznika " + "\n" + Polaznici[a] + "\n" + "   1) DA / 2) NE | ");

            if (potvrda == true)
            {

                Polaznici.RemoveAt(a);
            }

            IzbornikRadSPolaznicima();
        }

        private void UrediPolaznika ()
        {
           PrikaziPolaznike ();

            try
            {

                int a = Pomocno.UcitajInt("Odaberi polaznika za izmjenu: ") - 1;

                var polaznik = Polaznici[a];

                int sifra = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n" + "Stara sifra: " + polaznik.Sifra + "\n" + "Nova sifra: ");
                string ime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro ime: " + polaznik.Ime + "\n" + "Novo ime: ");
                string prezime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro prezime: " + polaznik.Prezime + "\n" + "Novo prezime: ");
                string oib = Pomocno.UcitajOIB("\n" + "_______________________________________" + "\n" + "Stari OIB: " + polaznik.Oib + "\n" + "Novi OIB: ");
                string email = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari email: " + polaznik.Email + "\n" + "Novi email: ");
                string brojUgovora = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari broj ugovora: " + polaznik.BrojUgovora + "\n" + "Novi broj ugovora: ");

                bool potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " + "\n" +
                                                  "\n" + "Prijasnji unos: " + polaznik + "\n" +
                                                  "Novi unos: " + ime + " " + prezime + " || " + oib + " || " + email + " || " + brojUgovora + "\n" + 
                                                  "1) DA / 2) NE | "); 

                if(potvrda == true) { 

                polaznik.Sifra = sifra;
                polaznik.Ime = ime;
                polaznik.Prezime = prezime;
                polaznik.Oib = oib;
                polaznik.BrojUgovora = brojUgovora;

                }


            }
            catch
            {

                Console.WriteLine("!!!!!!!!!!!!!!!!!!! " + "Ne postoji polaznik pod odabranom sifrom" + " !!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! " + " Provjerite ispravnost svoga unosa" + " !!!!!!!!!!!!!!!!!!!!!!!!");
                UrediPolaznika();
            }

            IzbornikRadSPolaznicima();

        }

        private void DodajNovogPolaznika ()
        {
            Polaznici.Add(new Polaznik() 
            {
                Sifra = Pomocno.UcitajInt("Sifra: "),
                Ime = Pomocno.UcitajString("Ime: "),
                Prezime = Pomocno.UcitajString("Prezime: "), 
                Oib = Pomocno.UcitajOIB("OIB: "),
                Email = Pomocno.UcitajString("Email: "),
                BrojUgovora = Pomocno.UcitajString("Broj ugovora: "), 

            });

            IzbornikRadSPolaznicima(); 
        }

        private void PrikaziPolaznike ()
        {
           var i = 0;
            Polaznici.ForEach(polaznik => { Console.WriteLine(++i + ". " + polaznik); });
        }

        private void IzbornikRadSGrupama()
        {
            Console.WriteLine("\n" + "Izbornik grupe" + 
                              "\n" + 
                              "*****************************************************************");
            Console.WriteLine("1. Prikazi sve grupe");
            Console.WriteLine("2. Dodaj grupu");
            Console.WriteLine("3. Uredi grupu");
            Console.WriteLine("4. Izbrisi grupu");
            Console.WriteLine("5. Prikazi sve polaznike grupe");
            Console.WriteLine("6. Izbrisi polaznika iz grupe");
            Console.WriteLine("7. Povratak na glavni izbornik");

            OdabirRadSGrupama();
        }

        private void OdabirRadSGrupama ()
        {
            switch (Pomocno.UcitajInt("Unesite svoj izbor: "))
            {
                case 1:
                    Console.WriteLine("\n" + "Prikazujem sve grupe" + "\n");
                    PrikaziGrupe();
                    IzbornikRadSGrupama();
                    break;
                case 2:
                    Console.WriteLine("\n" + "Dodajem grupu" + "\n");
                    DodajNovuGrupu(); 
                    break;
                case 3:
                    Console.WriteLine("\n" + "Uredujem grupu" + "\n");
                    UrediGrupu();
                    break;
                case 4:
                    Console.WriteLine("\n" + "Izbrisi grupu" + "\n");
                    IzbrisiGrupu(); 
                    break;
                case 5:
                    Console.WriteLine("\n" + "Prikazujem polaznike grupe" + "\n");
                    PrikaziSvePolaznikeOdabraneGrupe(); 
                    IzbornikRadSGrupama();
                    break;
                case 6:
                    Console.WriteLine("\n" + " Brisem polaznika iz grupe" + "\n");
                    IzbrisiPolaznikaIzGrupe(); 
                    break;
                case 7:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!! KRIVI UNOS !!!!!!!!!!!!!!!!!!!!!");
                    IzbornikRadSPolaznicima();
                    break;
            }
        }

        private void PrikaziSvePolaznikeOdabraneGrupe ()
        {
            PrikaziGrupe();
            int b = 1;
            int i = Pomocno.UcitajInt("Odaberi redni broj grupe: ");
            var g = Grupe[i - 1];

            Console.WriteLine("-----------------------------------------------------------------");

            foreach (Polaznik polaznik in g.Polaznici)
            {
                Console.WriteLine("{0}. {1}", b++, polaznik);

            }
            Console.WriteLine("-----------------------------------------------------------------");


          
        }

        private void IzbrisiPolaznikaIzGrupe ()
        {
            PrikaziSvePolaznikeOdabraneGrupe();
            var g = Grupe[Grupe.Count() - 1];
            int a = Pomocno.UcitajInt("Odaberi polaznika kojeg zelite obrizati: ") - 1;

            bool potvrda = Pomocno.UcitajBool("\n"+ "Obrisati polaznika " + "\n" + g.Polaznici[a] + "\n" + "1) DA / 2) NE | ");
            
            if(potvrda == true)
            {
                g.Polaznici.RemoveAt(a);
            }
            
            IzbornikRadSGrupama();
        }

        private void IzbrisiGrupu ()
        {
            PrikaziGrupe();
            int a = Pomocno.UcitajInt("Odaberi polaznika kojeg zelite obrizati: ") - 1;
            bool potvrda = Pomocno.UcitajBool("\n" + "Obrisati polaznika " + "\n" + Grupe[a] + "\n" + "1) DA / 2) NE | ");

            if (potvrda == true)
            {
                Grupe.RemoveAt(a);
            }
            IzbornikRadSGrupama();
        }

        private void UrediGrupu ()
        {
           PrikaziGrupe();

            

            int i = Pomocno.UcitajInt("Odaberi redni broj grupe: ");
            var g = Grupe[i - 1];

            int sifra    = Pomocno.UcitajInt("\n" + "------------------------------------------------------------------------------" + 
                                             "\n" + "Stara sifra: " + g.Sifra + "\n" + "Nova sifra: ");

            string naziv = Pomocno.UcitajString("\n" + "------------------------------------------------------------------------------" +    
                                                "\n" + "Stari naziv: " + g.Naziv + "\n" + "Novi naziv: ");

            var predavac = PostaviPredavaca(); 

            Console.WriteLine("\n" + "------------------------------------------------------------------------------" + "\n" + "Trenutni smjer: {0}", g.Smjer.Naziv);

            var smjer = PostaviSmjer();

            int b = 1;

            Console.WriteLine("\n" + "Trenutni polaznici: " + "\n");
            Console.WriteLine("------------------------------------------------------------------------------");


            foreach (Polaznik polaznik in g.Polaznici)
            {

                Console.WriteLine("{0}. {1}", b++, polaznik);

            }
            Console.WriteLine("-------------------------------------------------------------------------------");
           
            var polaznici = PostaviPolaznike();

            int maksimalnoPolaznika = Pomocno.UcitajInt("Maksimalno plaznika: ");
            DateTime dateTime = Pomocno.UcitajDatum("Novi datum pocetka: ");

            bool potvrda = Pomocno.UcitajBool("\n" + "Prihvati izmjene: " + "\n" + "\n" +
                                              "Stari unos: " + g + "\n" +
                                              "Novi unos: " + smjer.Naziv + " || " + "Nova grupa: " +  naziv + " || " + "Novi predavac: " + predavac.Ime + " " + predavac.Prezime +  " || " +
                                              "Maksimalno polaznika: " + maksimalnoPolaznika + " || " + "Novi datum pocetka: " + dateTime + "\n" + 
                                              "1) DA / 2) NE | ") ;

            if(potvrda== true) {  

            g.Sifra = sifra;
            g.Naziv = naziv;
            g.Predavac = predavac; 
            g.Smjer = smjer;

            g.Polaznici = polaznici;
            }


            IzbornikRadSGrupama();
        }

        private void DodajNovuGrupu ()
        {
            Grupe.Add(new Grupa()
            {
                Sifra = Pomocno.UcitajInt("Unesi sifru grupe: "),
                Naziv = Pomocno.UcitajString("Unesi naziv grupe: "),
                Predavac = PostaviPredavaca(),
                Smjer = PostaviSmjer(),
                Polaznici = PostaviPolaznike(),

                MaksPolaznika = Pomocno.UcitajInt("Maksimalan broj polaznika: "),
                DatumPocetka = Pomocno.UcitajDatum("Unesi datum grupe u formatu dd.MM.yyyy.: ") // NAPOMENA!!!!! FORMAT RADI U SKLADU SA DATE & TIME POSTAVKAMA OPERATIVNOG SUSTAVA 


            });

            IzbornikRadSGrupama(); 
        }

        private List<Polaznik> PostaviPolaznike ()
        {
           List<Polaznik> polaznici = new List<Polaznik>();
            while (Pomocno.UcitajBool("Zelite li dodati polaznike? 1) DA / 2) NE | "))
                {
                polaznici.Add(PostaviPolaznika());
            }
            return polaznici;
        }

        private Polaznik PostaviPolaznika()
        {
            PrikaziPolaznike();
            int i = Pomocno.UcitajRasponBrojeva("\n" + "Odaberi redni broj polaznika: ", 0, Polaznici.Count());

            // ako polaznik postoji, odbij unos

            return Polaznici[i - 1];
        }

        private Smjer PostaviSmjer ()
        {
            PrikaziSmjerove();
            int i = Pomocno.UcitajInt("\n" + "Odaberi redni broj smjera: ");
            return Smjerovi[i - 1]; 
        }

        private Predavac PostaviPredavaca ()
        {
            PrikaziPredavace();
            int i = Pomocno.UcitajRasponBrojeva("\n" + "Odaberi redni broj predavaca: ", 0, Predavaci.Count());
            return Predavaci[i - 1];
        }

        private void PrikaziGrupe ()
        {
            var i = 0;
            Grupe.ForEach(g => { Console.WriteLine(++i + ". " + g); });
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*+********************************");
            Console.WriteLine("* EDUNOVA KONZOLNA APLIKACINA v1 *");
            Console.WriteLine("**********************************");
        }
    }
}
