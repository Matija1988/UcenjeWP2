using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacija.Model
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


            return new StringBuilder(Smjer.Naziv).Append(" || " + Naziv + " || " + Predavac.Ime + " " + Predavac.Prezime + " || " + "Maksimalno polaznika: " + MaksPolaznika + " || " + "Datum pocetka: " + DatumPocetka).ToString(); 
        }
        // new StringBuilder(Smjer.Naziv).Append(" || ").Append(Naziv).Append(" || ")
               // .Append (Predavac.Ime).Append (" ").Append (Predavac.Prezime).Append (" || ").Append ("Maksimalno polaznika: ").Append (MaksPolaznika).Append (" || ").Append ("Datum pocetka: ").Append (DatumPocetka).ToString ();
        // Smjer.Naziv + " || " + Naziv + " || " + Predavac.Ime + " " + Predavac.Prezime + " || " + "Maksimalno plaznika: " + MaksPolaznika + " || " + "Datum pocetka: " + DatumPocetka + "\n";
    }
}
