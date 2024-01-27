﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacija.Model
{
    internal class Smjer : Entitet
    {
        public string Naziv { get; set; }

        public int BrojSati { get; set; }

        public float Cijena { get; set; }
        public float Upisinina { get; set; }
        public bool Verificiran { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
