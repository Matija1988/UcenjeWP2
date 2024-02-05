using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacijaPreustroj.Model
{
    internal class Grupa : Entitet

    {
        public string Naziv { get; set; }

        public Predavac Predavac { get; set; }

        public Smjer Smjer { get; set; }

        public int MaksPolaznika { get; set; }

        public DateTime DatumPocetka { get; set; }

        public List<Polaznik> Polaznici { get; set; }


        public override string ToString ()
        {
            try { 

            return new StringBuilder(Smjer.Naziv).Append(" || " + Naziv + " || " + Predavac.Ime + " " + Predavac.Prezime + " || " + "Maksimalno polaznika: " + MaksPolaznika + " || " + "Datum pocetka: " + DatumPocetka).ToString();

            } catch
            {
                Console.WriteLine("Problem u ispisu grupa. Pogledati - String override u klasi Grupe!");
                return null;
            }
        }
        
    }
}