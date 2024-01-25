using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Polimorfizam
{
    internal class Predavac : Osoba

    {

        public string IBAN { get; set; }

        public override string Pozdravi()
        {
            return "Dobar dan predavacu " + Prezime; 
        }
    }
}
