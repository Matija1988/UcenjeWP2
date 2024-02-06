using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Delegati
{
    internal class Primjerkoristenja1
    {
        public Primjerkoristenja1()
        {
            var os = new ObradaSmjer();
            os.IspisSmjer(MojIspisUOvojKlasi); 

            //Action<Smjer> a = new(MojIspisUOvojKlasi);  
            // os.IspisSmjeraAction(a);

            // Ova linija je ekvivalent gornjim dvijema linijama

            os.IspisSmjeraAction(new(MojIspisUOvojKlasi)); 

        }
            
        private void MojIspisUOvojKlasi(Smjer s)
        {
            Console.WriteLine("1 " + s.Naziv);
        }


    }
}
