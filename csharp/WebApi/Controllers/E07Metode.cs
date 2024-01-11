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

         int Zbroj(int a, int b)
        {
               return a + b;

        }




    }
}
