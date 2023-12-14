using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodatakaOperatori : ControllerBase 
    {
        [HttpGet]
        [Route("zad1")]

        public int zad1()
        {
            return int.MinValue;
        }

        [HttpGet]
        [Route("Zad2")]

        public float zad2(int i, int j) 
        {
            return (float)i / j;

        }

        [HttpGet]
        [Route("Zad3")]

        public float zad3(int i, int j)
        {
            int k = i * j;
            float l = i / j;
            
            return (float)k + l;

        }

        [HttpGet]
        [Route("Zad4")]

        public string zad4(string s, string s1)
        {
            string conc = s + s1; 
            return conc;

        }

        [HttpGet]
        [Route("Zad5")]

        public bool zad5(int a, int b)
        {

            return a == b;

        }

    }
}
