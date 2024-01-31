﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            return Smjer.Naziv + " || " + Naziv + " || " + Predavac.Ime + " " + Predavac.Prezime + " || " + "Maksimalno plaznika " + MaksPolaznika + " || " + "Datum pocetka " + DatumPocetka + "\n";
        }
    }
}
