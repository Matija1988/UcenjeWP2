using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacijaPreustroj.Model;

namespace UcenjeCS.E15KonzolnaAplikacijaPreustroj
{
    internal class ObradaPredavac
    {
        private List<Predavac> Predavaci;

        public Izbornik Izbornik { get;  }
       
        public ObradaPredavac(Izbornik Izbornik):this()
        {
            this.Izbornik = Izbornik;
        }
    
        public ObradaPredavac ()
        {
            Predavaci = new List<Predavac> ();

            if (Pomocno.dev)
            {
                TestniPodaci();
            }

        }

        public void IzbornikRadSPredavacima ()
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

        private void OdabirIzbornikRadSPredavacima ()
        {
            switch (Pomocno.UcitajInt("\n"+"Unesite svoj izbor: "))
            {
                case 1:
                    Console.WriteLine("\n" + "Prikazujem sve predavace" + "\n");
                    PrikaziPredavace();
                    IzbornikRadSPredavacima();
                    break;
                case 2:
                    Console.WriteLine("\n" + "Dodajem predavaca" + "\n");
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
                    Console.WriteLine("Povratak na glavni izbornik");
                   Izbornik.GlavniIzbornik();
                    
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

            try
            {

                int a = Pomocno.UcitajInt("Izbrisi predavaca: ") - 1;

                bool potvrda = Pomocno.UcitajBool("\n" + "Obrisati predavaca " + "\n" + Predavaci[a] + "\n" + "    1) DA / 2) NE | ");

                if (potvrda == true)
                {
                    Predavaci.RemoveAt(a);
                }
            }
            catch
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!! " + "Ne postoji predavac pod odabranom sifrom" + " !!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! " + " Provjerite ispravnost svoga unosa" + " !!!!!!!!!!!!!!!!!!!!!!!!");
                IzbrisiPredavaca();
            }
            IzbornikRadSPredavacima();
        }

        private void UrediPredavaca ()
        {
            PrikaziPredavace();

            try
            {
                var p = Predavaci[Pomocno.UcitajInt("Odaberi predavaca za izmjene: ") - 1];

                //int sifra = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n" + "Stara sifra: " + p.Sifra + "\n" + "Nova sifra: ");

                //Predavaci.ForEach(p => {
                //    if (p.Sifra == sifra)
                //    {
                //        Console.WriteLine("\n" + "!!!!!!!!!!!!!!!!!!!!! POSTOJI PREDAVAC SA UNESENOM SIFROM !!!!!!!!!!!!!!!!!!!!!");
                //        DodajNovogPredavaca();
                //    }
                //});

                string ime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro ime: " + p.Ime + "\n" + "Novo ime: ");
                string prezime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro prezime: " + p.Prezime + "\n" + "Novo prezime: ");
                string oib = Pomocno.UcitajOIB("\n" + "_______________________________________" + "\n" + "Stari OIB: " + p.Oib + "\n" + "Novi OIB:  ");
                string email = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari email: " + p.Email + "\n" + "Novi email: ");
                string iban = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari IBAN: " + p.IBAN + "\n" + "Novi IBAN: ");

                bool potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " + "\n" +
                                                  "\n" + "Prijasnji unos: " + p + "\n" +
                                                  "Novi unos: " + ime + " || " + "Novo prezime: " + prezime + " || " + "Novi OIB: " + oib + " || " + "Novi emial: " + email + " || " + "Novi IBAN: " + iban + "\n" +
                                                  "1) DA / 2) NE | ");

                if (potvrda == true)
                {
                  //  p.Sifra = sifra;
                    p.Ime = ime;
                    p.Prezime = prezime;
                    p.Oib = oib;
                    p.Email = email;
                    p.IBAN = iban;

                }

            }
            catch
            {

                Console.WriteLine("!!!!!!!!!!!!!!!!!!! " + "Ne postoji predavac pod odabranom sifrom" + " !!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! " + " Provjerite ispravnost svoga unosa" + " !!!!!!!!!!!!!!!!!!!!!!!!");
                UrediPredavaca();
            }
            IzbornikRadSPredavacima();
        }

        public void PrikaziPredavace ()
        {
            var i = 0;
            Predavaci.ForEach(p => { Console.WriteLine(++i + ". " + p); });
        }

        private void DodajNovogPredavaca ()
        {
            PrikaziPredavace();

            int sifra = Pomocno.UcitajInt("Unesi sifru: ");


            Predavaci.ForEach(p => {
                if (p.Sifra == sifra)
                {
                    Console.WriteLine("\n" + "!!!!!!!!!!!!!!!!!!!!! POSTOJI PREDAVAC SA UNESENOM SIFROM !!!!!!!!!!!!!!!!!!!!!");
                    DodajNovogPredavaca();
                }
            });




            Predavaci.Add(new Predavac()
            {
                Sifra = sifra,
                Ime = Pomocno.UcitajString("Unesi ime predavaca: "),
                Prezime = Pomocno.UcitajString("Unesi prezime predavaca: "),
                Oib = Pomocno.UcitajOIB("OIB: "),
                Email = Pomocno.UcitajString("Email: "),
                IBAN = Pomocno.UcitajString("IBAN: ")

            });

            IzbornikRadSPredavacima();
        }

        private void TestniPodaci()
        {

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

        }
    }
}
