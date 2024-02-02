using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacijaPreustroj.Model;


namespace UcenjeCS.E15KonzolnaAplikacijaPreustroj
{
    internal class ObradaGrupe

    {

        public List<Grupa> Grupe {  get;  }

        public List<Smjer> Smjerovi { get; }    
        public List<Polaznik> Polaznici { get; }
        public List<Predavac> Predavaci {  get; }   

        private Izbornik Izbornik { get; }

        private ObradaPolaznik ObradaPolaznik { get; }
        private ObradaSmjer ObradaSmjer { get; }
        private ObradaPredavac ObradaPredavac { get; }

        public ObradaGrupe(Izbornik izbornik, ObradaPolaznik obradaPolaznik, ObradaSmjer obradaSmjer, ObradaPredavac obradaPredavac):this()
        {
            this.Izbornik = izbornik;
            this.ObradaPolaznik = obradaPolaznik;
            this.ObradaSmjer = obradaSmjer;
            this.ObradaPredavac = obradaPredavac;
            
        }

        public ObradaGrupe ()
        {
            Grupe = new List<Grupa>();

        }

        public void IzbornikRadSGrupama ()
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

            Console.WriteLine("7. Ukupno polaznika na svim grupama");
            Console.WriteLine("8. Ukupan iznos prihoda po smjerovima");
            Console.WriteLine("9. Prosjecan iznos prihoda po polazniku");

            Console.WriteLine("10. Povratak na glavni izbornik");

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
                    Console.WriteLine("Ukupan broj polaznika na svim grupama");
                    UcitajUkupanBrojPolaznika(Grupe);

                    break;
                case 8:
                    Console.WriteLine("Ukupan iznos prihoda po smjerovima");
                    IznosPrihodaPoSmjerovima();
                    break;
                case 10:
                    Izbornik.GlavniIzbornik(); 
                    break;
                default:
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!! KRIVI UNOS !!!!!!!!!!!!!!!!!!!!!");
                    IzbornikRadSGrupama();
                    break;
            }

        }


        private void IzbrisiPolaznikaIzGrupe ()
        {
            PrikaziSvePolaznikeOdabraneGrupe();
            var g = Grupe[Grupe.Count() - 1];
            int a = Pomocno.UcitajInt("Odaberi polaznika kojeg zelite obrizati: ") - 1;

            bool potvrda = Pomocno.UcitajBool("\n" + "Obrisati polaznika " + "\n" + g.Polaznici[a] + "\n" + "1) DA / 2) NE | ");

            if (potvrda == true)
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

            //int sifra = Pomocno.UcitajInt("\n" + "------------------------------------------------------------------------------" +
            //                                 "\n" + "Stara sifra: " + g.Sifra + "\n" + "Nova sifra: ");

            //while (ProvjeraSifreGrupe(Grupe, sifra) == true)
            //{
            //    UrediGrupu();
            //}

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
                                              "Novi unos: " + smjer.Naziv + " || " + "Nova grupa: " + naziv + " || " + "Novi predavac: " + predavac.Ime + " " + predavac.Prezime + " || " +
                                              "Maksimalno polaznika: " + maksimalnoPolaznika + " || " + "Novi datum pocetka: " + dateTime + "\n" +
                                              "1) DA / 2) NE | ");

            if (potvrda == true)
            {

              //  g.Sifra = sifra;
                g.Naziv = naziv;
                g.Predavac = predavac;
                g.Smjer = smjer;

                g.Polaznici = polaznici;
            }


            IzbornikRadSGrupama();
        }

        private void DodajNovuGrupu ()
        {

            int sifra = Pomocno.UcitajInt("Unesi sifru grupe: ");

            if (ProvjeraSifreGrupe(Grupe, sifra))
            {
                DodajNovuGrupu();
            }

            Grupe.Add(new Grupa()
            {
                Sifra = sifra,
                Naziv = Pomocno.UcitajString("Unesi naziv grupe: "),
                Predavac = PostaviPredavaca(),
                Smjer = PostaviSmjer(),
                Polaznici = PostaviPolaznike(),

                MaksPolaznika = Pomocno.UcitajInt("Maksimalan broj polaznika: "),
                DatumPocetka = Pomocno.UcitajDatum("Unesi datum grupe u formatu dd.MM.yyyy.: ") // NAPOMENA!!!!! FORMAT RADI U SKLADU SA DATE & TIME POSTAVKAMA OPERATIVNOG SUSTAVA 


            });

            IzbornikRadSGrupama();
        }

        private bool ProvjeraSifreGrupe (List<Grupa> grupe, int sifra)
        {
            foreach (Grupa grupa in Grupe)
            {
                if (grupa.Sifra.Equals(sifra))
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!! " + " Unesena sifra se koristi " + " !!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! " + " Unesite drugu sifru" + " !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    return true;

                }

            }
            return false;
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

        private Polaznik PostaviPolaznika ()
        {
            ObradaPolaznik.PrikaziPolaznike();
            int i = Pomocno.UcitajRasponBrojeva("\n" + "Odaberi redni broj polaznika: ", 0, Polaznici.Count());

            // ako polaznik postoji, odbij unos

            return Polaznici[i - 1];
        }

        private Smjer PostaviSmjer ()
        {
            ObradaSmjer.PrikaziSmjerove();
            int i = Pomocno.UcitajInt("\n" + "Odaberi redni broj smjera: ");
            return Smjerovi[i - 1];
        }

        private Predavac PostaviPredavaca ()
        {
            ObradaPredavac.PrikaziPredavace();
            int i = Pomocno.UcitajRasponBrojeva("\n" + "Odaberi redni broj predavaca: ", 0, Predavaci.Count());
            return Predavaci[i - 1];
        }

        private void PrikaziGrupe ()
        {
            var i = 0;
            Grupe.ForEach(g => { Console.WriteLine(++i + ". " + g); });


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

        private void UcitajUkupanBrojPolaznika (List<Grupa> Grupe)
        {
            int a = 0;

            Grupe.ForEach(Grupa => { Console.WriteLine("Trenutno nastavu pohada " + Grupa.Polaznici.Count() + " polaznika u " + ++a + " grupe"); });

            IzbornikRadSGrupama();

        }

        private void IznosPrihodaPoSmjerovima ()
        {
           ObradaSmjer.PrikaziSmjerove();


            int b = 1;
            int i = Pomocno.UcitajInt("\n" + "Odaberi redni broj smjera: ");
            var s = Smjerovi[i - 1];

            float ukupno = 0;

            foreach (Smjer smjer in Smjerovi)
            {
                b++;
                ukupno = s.Cijena * b;
            }



            Console.WriteLine("Ukupno: " + ukupno);

            IzbornikRadSGrupama();

        }

    }
}
