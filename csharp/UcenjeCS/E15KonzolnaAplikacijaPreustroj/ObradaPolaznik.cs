using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacijaPreustroj.Model;

namespace UcenjeCS.E15KonzolnaAplikacijaPreustroj
{
    
    internal class ObradaPolaznik
    {
        public List<Polaznik> Polaznici;

       

        public Izbornik Izbornik { get; }

        public ObradaPolaznik(Izbornik izbornik):this()
        {
            this.Izbornik = izbornik;
        }


        public ObradaPolaznik() 
        { 
            
            Polaznici = new List<Polaznik>();

          

            if(Pomocno.dev)
            {
                TestniPodaci(); 
            }
        
        }
        public void IzbornikRadSPolaznicima ()
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

       
        private void OdabirRadSPolaznicima ()
        {
            switch (Pomocno.UcitajInt("\n" + "Unesite svoj izbor: "))
            {
                case 1:
                    Console.WriteLine("\n" + "Prikazujem sve polaznike" + "\n");
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
                    Izbornik.GlavniIzbornik();
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
            PrikaziPolaznike();

            try
            {

                int a = Pomocno.UcitajInt("Odaberi polaznika za izmjenu: ") - 1;

                var polaznik = Polaznici[a];

                //int sifra = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n" + "Stara sifra: " + polaznik.Sifra + "\n" + "Nova sifra: ");
                //if (ProvjeriSifrePolaznika(Polaznici, sifra) == true)
                //{

                //    UrediPolaznika();

                //}
                string ime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro ime: " + polaznik.Ime + "\n" + "Novo ime: ");
                string prezime = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Staro prezime: " + polaznik.Prezime + "\n" + "Novo prezime: ");
                string oib = Pomocno.UcitajOIB("\n" + "_______________________________________" + "\n" + "Stari OIB: " + polaznik.Oib + "\n" + "Novi OIB:  ");
                string email = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari email: " + polaznik.Email + "\n" + "Novi email: ");
                string brojUgovora = Pomocno.UcitajString("\n" + "_______________________________________" + "\n" + "Stari broj ugovora: " + polaznik.BrojUgovora + "\n" + "Novi broj ugovora: ");

                bool potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " + "\n" +
                                                  "\n" + "Prijasnji unos: " + polaznik + "\n" +
                                                  "Novi unos: " + ime + " " + prezime + " || " + oib + " || " + email + " || " + brojUgovora + "\n" +
                                                  "1) DA / 2) NE | ");

                if (potvrda == true)
                {

                   // polaznik.Sifra = sifra;
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
            PrikaziPolaznike();

            int sifra = Pomocno.UcitajInt("Sifra: ");

            if (ProvjeriSifrePolaznika(Polaznici, sifra) == true)
            {

                DodajNovogPolaznika();

            }

            Polaznici.Add(new Polaznik()
            {
                Sifra = sifra,
                Ime = Pomocno.UcitajString("Ime: "),
                Prezime = Pomocno.UcitajString("Prezime: "),
                Oib = Pomocno.UcitajOIB("OIB: "),
                Email = Pomocno.UcitajString("Email: "),
                BrojUgovora = Pomocno.UcitajString("Broj ugovora: "),

            });

            IzbornikRadSPolaznicima();
        }

        private bool ProvjeriSifrePolaznika (List<Polaznik> polaznici, int sifra)
        {
            foreach (Polaznik polaznik in Polaznici)
            {
                if (polaznik.Sifra.Equals(sifra))
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!! " + " Unesena sifra se koristi " + " !!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! " + " Unesite drugu sifru" + " !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    return true;

                }

            }
            return false;
        }

       

        public void PrikaziPolaznike ()
        {
            var i = 0;
            Polaznici.ForEach(polaznik => { Console.WriteLine(++i + ". " + polaznik); });
        }

        private void TestniPodaci ()
        {
            Polaznici.Add(new Polaznik
            {
                Sifra = 1,
                Ime = "Ana",
                Prezime = "Gal",
                Email = "agal@gmail.com",
                Oib = "33736472822",
                BrojUgovora = "WP 2 - 02"
            }); 

            Polaznici.Add(new Polaznik
            {
                Sifra = 2,
                Ime = "Marija",
                Prezime = "Zimska",
                Email = "mzimska@gmail.com",
                Oib = "33736472821",
                 BrojUgovora = "WP 2 - 05"
            });

            Polaznici.Add(new Polaznik
            {
                Sifra = 3,
                Ime = "Marko",
                Prezime = "Janko",
                Email = "majan@gmail.com",
                Oib = "12345678910",
                BrojUgovora = "WP 2 - 10"
            });

            Polaznici.Add(new Polaznik
            {
                Sifra = 4,
                Ime = "Lucija",
                Prezime = "Perkovic",
                Email = "lperk@gmail.com",
                Oib = "33367832122",
                BrojUgovora = "WP 2 - 14"
            });
            Polaznici.Add(new Polaznik
            {
                Sifra = 5,
                Ime = "Sanja",
                Prezime = "Lazar",
                Email = "sanjalazar@gmail.com",
                Oib = "79832155501",
                BrojUgovora = "WP 2 - 15"
            });

            Polaznici.Add(new Polaznik
            {
                Sifra = 6,
                Ime = "Tomislav",
                Prezime = "Padovanski",
                Email = "tpadovanski@gmail.com",
                Oib = "12345678912",
                BrojUgovora = "JP 12 - 01"
            });

            Polaznici.Add(new Polaznik
            {
                Sifra = 7,
                Ime = "Tihomir",
                Prezime = "Tihic",
                Email = "tt@gmail.com",
                Oib = "12345678920",
                BrojUgovora = "JP 12 - 13"
            });

            Polaznici.Add(new Polaznik
            {
                Sifra = 8,
                Ime = "Tamara",
                Prezime = "Suvak",
                Email = "tami@gmail.com",
                Oib = "12345678930",
                BrojUgovora = "JP 12 - 04"
            });
        }
    }
}
