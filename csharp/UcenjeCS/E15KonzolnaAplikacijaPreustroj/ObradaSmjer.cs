using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacija;
using UcenjeCS.E15KonzolnaAplikacijaPreustroj.Model;

namespace UcenjeCS.E15KonzolnaAplikacijaPreustroj
{
    internal class ObradaSmjer
    {

      
        public List<Smjer> Smjerovi { get; }

        private Izbornik Izbornik { get; }


        public ObradaSmjer(Izbornik izbornik):this() 
        { 
        
            this.Izbornik = izbornik;

        }

        public ObradaSmjer ()
        {
         

            Smjerovi = new List<Smjer>();
            if (Pomocno.dev)
            {
                TestniPodaci();
            }

            
        }
        
    

        public void IzbornikRadSaSmjerovima ()
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


        public void OdabirStavkeIzbornikSmjera ()
        {
            switch (Pomocno.UcitajInt("\n" + "Unesite svoj izbor: "))
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
                    Console.WriteLine("Povratak na glavni izbornik:");
                    Izbornik.GlavniIzbornik();
                 
                    break;
                default:
                    Console.WriteLine("Krivi unos!!!!!" + "\n");
                    IzbornikRadSaSmjerovima();
                    break;
            }
        }

        private void IzbrisiSmjer ()
        {
            PrikaziSmjerove();

            try
            {

                int a = Pomocno.UcitajInt("Obrisi smjer: ") - 1;

                bool potvrda = Pomocno.UcitajBool("\n" + "Obrisati smjer " + "\n" + Smjerovi[a] + "\n" + "1) DA / 2) NE | ");

                if (potvrda == true)
                {

                    Smjerovi.RemoveAt(a);

                }


            }
            catch
            {

                Console.WriteLine("\n" + "!!!!!!!!!!!!!!!!!!!!! " + "Ne postoji smjer pod odabranom sifrom" + " !!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! " + " Provjerite ispravnost svoga unosa" + " !!!!!!!!!!!!!!!!!!!!!!!!" + "\n");
                IzbrisiSmjer();

            }
            IzbornikRadSaSmjerovima();
        }

        private void UrediSmjer ()
        {
            PrikaziSmjerove();

            try
            {
                var s = Smjerovi[Pomocno.UcitajInt("\n" + "Odaberi smjer za promjenu: ") - 1];

                //int sifra = Pomocno.UcitajInt("\n" + "_______________________________________" + "\n" + "Stara sifra: " + s.Sifra + "\n" + "Nova sifra: ");


                //Smjerovi.ForEach(s =>
                //{
                //    if (s.Sifra == sifra)
                //    {
                //        Console.WriteLine("\n" + "!!!!!!!!!!!!!!!!!!!!! POSTOJI SMJER SA UNESENOM SIFROM !!!!!!!!!!!!!!!!!!!!!");
                //        UrediSmjer();
                //    }
                //});
                Console.WriteLine("1) Naziv smjera");
                Console.WriteLine("2) Broj sati");
                Console.WriteLine("3) Cijena");
                Console.WriteLine("4) Upisnina");
                Console.WriteLine("5) Status verifikacije");
                Console.WriteLine("6) Uredi sve");
                Console.WriteLine("7) Izbornik rad s predavacima");

                switch (Pomocno.UcitajInt("Odaberite stavku koju zelite promijeniti: " ))
                { 
                    
                    case 1:
                        string naziv = Pomocno.UcitajString("\n" + "_______________________________________" +  
                                                             "\n" + "Stari naziv: " + s.Naziv + 
                                                              "\n" + "Novi naziv: ");

                        bool potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " + 
                                                           "\n" +
                                                            "\n" + "Prijasnji unos: " + s.Naziv + 
                                                             "\n" + "Novi unos: " + naziv + 
                                                              "\n" + "Prihvati promjene: 1) DA / 2) NE | ");
                        if(potvrda) 
                        { 
                        s.Naziv = naziv;
                        }
                        break;

                    case 2:
                        int brojSati = Pomocno.UcitajInt("\n" + "_______________________________________" + 
                                                          "\n" + "Stari broj sati: " + s.BrojSati +
                                                           "\n" + "Novi broj sati: ");

                        potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " 
                                                    + "\n" +
                                                       "\n" + "Prijasnji unos: " + s.BrojSati +
                                                        "\n" + "Novi unos: " + brojSati + 
                                                         "\n" + "Prihvati promjene: 1) DA / 2) NE | ");

                        if (potvrda)
                        {
                            s.BrojSati = brojSati;
                        }
                        break;

                        case 3:
                        float cijena = Pomocno.UcitajFloat("\n" + "_______________________________________" + 
                                                            "\n" + "Stara cijena: " + s.Cijena +
                                                             "\n" + "Nova cijena: ");

                        potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " +
                                                      "\n" +
                                                       "\n" + "Prijasnji unos: " + s.Cijena + 
                                                        "\n" + "Novi unos: " + cijena +
                                                         "\n" + "Prihvati promjene: 1) DA / 2) NE | ");
                        if(potvrda) 
                        { 
                            s.Cijena = cijena;
                        }
                        break;

                        case 4:
                        float upisnina = Pomocno.UcitajFloat("\n" + "_______________________________________" +     
                                                              "\n" + "Stara upisnina: " + s.Upisnina + 
                                                               "\n" + "Nova upisnina: ");

                        potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " + 
                                                      "\n" +
                                                       "\n" + "Prijasnji unos: " + s.Upisnina + 
                                                        "\n" + "Novi unos: " + upisnina + 
                                                         "\n" + "Prihvati promjene: 1) DA / 2) NE | ");
                        if(potvrda)
                        {
                            s.Upisnina = upisnina;
                        }
                        break;

                    case 5:
                       bool verificiran = Pomocno.UcitajBool("\n" + "_______________________________________" +     
                                                              "\n" + "Prijasnja verifikacija: " + s.Verificiran + 
                                                               "\n" + "Nova verifikacija: 1) DA / 2) NE | ");

                        potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " + 
                                                      "\n" +
                                                       "\n" + "Prijasnji unos: " + s.Verificiran + 
                                                        "\n" + "Novi unos: " + verificiran + 
                                                         "\n" + "Prihvati promjene: 1) DA / 2) NE | ");
                        if (verificiran)
                        {
                            s.Verificiran = verificiran;
                        }
                        break;

                        case 6:
                         naziv = Pomocno.UcitajString("\n" + "_______________________________________" + 
                                                       "\n" + "Stari naziv: " + s.Naziv +
                                                        "\n" + "Novi naziv: ");

                         brojSati = Pomocno.UcitajInt("\n" + "_______________________________________" + 
                                                       "\n" + "Stari broj sati: " + s.BrojSati + 
                                                        "\n" + "Novi broj sati: ");

                         cijena = Pomocno.UcitajFloat("\n" + "_______________________________________" + 
                                                       "\n" + "Stara cijena: " + s.Cijena +
                                                        "\n" + "Nova cijena: ");

                         upisnina = Pomocno.UcitajFloat("\n" + "_______________________________________" + 
                                                         "\n" + "Stara upisnina: " + s.Upisnina +
                                                          "\n" + "Nova upisnina: ");

                         verificiran = Pomocno.UcitajBool("\n" + "_______________________________________" + 
                                                           "\n" + "Prijasnja verifikacija: " + s.Verificiran + 
                                                            "\n" + "Nova verifikacija: 1) DA / 2) NE | ");

                         potvrda = Pomocno.UcitajBool("\n" + "Promijeniti informacije polaznika " + 
                                                       "\n" +
                                                        "\n" + "Prijasnji unos: " + s + 
                                                         "\n" + "Novi unos: " + naziv + " || " + "Novi broj sati: " + brojSati + " || " + "Nova cijena: " + cijena + " || " + "Nova upisnina: " + upisnina + " || " + "Verificiran: " + verificiran +
                                                          "\n" +
                                                           "\n" + "Prihvati promjene: 1) DA / 2) NE | ");

                        if (potvrda)
                        {

                            //   s.Sifra = sifra;
                            s.Naziv = naziv;
                            s.BrojSati = brojSati;
                            s.Cijena = cijena;
                            s.Upisnina = upisnina;
                            s.Verificiran = verificiran;
                        }
                        break;

                    default:
                        break;

                }

             }
            catch
            {

                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!! " + "Ne postoji smjer pod odabranom sifrom" + " !!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!! " + " Provjerite ispravnost svoga unosa" + " !!!!!!!!!!!!!!!!!!!!!!!!");
                UrediSmjer();

            }

            IzbornikRadSaSmjerovima();
        }

  

     
        public void PrikaziSmjerove ()
        {
            var i = 0;
            Smjerovi.ForEach(smi => { Console.WriteLine(++i + ". " + smi); });

        }
        private void DodajNoviSmjer ()
        {
            PrikaziSmjerove();

            int sifra = Pomocno.UcitajInt("\n" + "Unesi sifru smjera: ");
                        

            Smjerovi.ForEach(s =>
            {
                if (s.Sifra == sifra)
                {
                    Console.WriteLine("\n" + "!!!!!!!!!!!!!!!!!!!!! POSTOJI SMJER SA UNESENOM SIFROM !!!!!!!!!!!!!!!!!!!!!");
                    DodajNoviSmjer();
                }
            });



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

        private void TestniPodaci ()
        {

            Smjerovi.Add(new Smjer
            {
                Sifra = 1,
                Naziv = "Web programiranje",
                BrojSati = 250,
                Cijena = 1000,
                Upisnina = 50,
                Verificiran = true
            });

            Smjerovi.Add(new Smjer
            {
                Sifra = 2,
                Naziv = "Java programiranje",
                BrojSati = 130,
                Cijena = 1000,
                Upisnina = 50,
                Verificiran = true
            });

        }

    }
}
