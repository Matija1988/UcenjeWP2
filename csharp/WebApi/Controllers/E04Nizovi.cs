using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("E04")]
    public class E04Nizovi : ControllerBase
    {
        [HttpPost]
        [Route("zad1")]

        public string zad1(string[] Podaci)
        {
            // vrati prvi element primljenog niza
            return Podaci[0];
        }

        [HttpPut]
        [Route("zad2")] 

        public int zad2(string[] Podaci) 
        {
            var b1 = int.Parse(Podaci[0]);
            var b2 = int.Parse(Podaci[1]);
            var b3 = int.Parse(Podaci[2]);

            if(b1 >= b2 && b1 >= b3) { return b1; }
            else if (b2 >= b1 && b2 >= b3) { return b2; } 
            else { return b3; }

        }

        [HttpDelete]
        [Route("Zad3")]

        public string BrojElemenataNiza(int[] data)
        {


            return $"{data.Count()}"; 
        }

    }
}
