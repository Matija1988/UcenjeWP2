using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("E07")]
    public class E07Metode : ControllerBase
    {
        [HttpGet]
        [Route("zad1")]

        public int Zad1(int PrviBroj, int DrugiBroj)
        {
            // napisite metodu koja za dva primljena cijela broja vraca njihov zbroj

            return Zbroj(PrviBroj, DrugiBroj); 
        }

        private int Zbroj(int a, int b)
        {
               return a + b;

        }

        // kreirati rutu zad2 koja prima 4 cijela broja i vraca razliku 1+2 i 3+4
        // koristiti kreiranu metodu za zbroj dvaju brojeva
        [HttpGet]
        [Route("zad2")]

        public int Zad2(int a, int b, int c, int d) 
        {

            return Zbroj(a, b) - Zbroj(c, d); 
        }


        //DZ

        //Kreirati rutu ZAD3 koja prima ime grada i slovo. Ruta vraca broj pojavljivanja slova u primljenom imenu grada
        //Koristiti metode 

        [HttpGet]
        [Route("zad3")]

        public int Zad3(string grad, string slovo)
        {

            return BrojSlova(grad, slovo);
        }

         int BrojSlova(string grad, string slovo)
        {

            int brojac = 0;

            foreach (char c in grad) 
            {
                
                foreach (char d in slovo)
                {
                    if(c == d)
                    {
                        brojac++;
                    }
                }
            
            }

            return brojac; 
        }


    }
}



