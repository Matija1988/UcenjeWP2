using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("E03")]
    public class E03UvjetnaGrananja : ControllerBase 
    {
        [HttpGet]
        [Route("zad1")]

        public string zad1(int Broj)
        {
            //if (Broj % 2 == 0) 
            //{
            //    return "Broj je paran";
            //}

            //return "Broj je neparan";

            //return Broj % 2 == 0 ? "Paran" : "Neparan";
            return (Broj % 2 != 0 ? "NE" : "") + "PARAN";
        }
        [HttpGet]
        [Route("zad2")]

        public string OcjenaTekstom(int Ocjena)
        {
            switch (Ocjena)
            {
                case 1:
                    return("Nedovoljan");
                    break;
                case 2:
                    return("Dovoljan");
                    break;
                case 3:
                    return ("Dobar");
                    break;
                case 4:
                return ("Vrlo dobar");
                    break;
                    case 5:
                    return ("Odlican");
                    break;
                
            }

            return $"{Ocjena} nije ocjena";

        }
        
    }
}
