using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("V01")]
    public class V01Vjezbe : ControllerBase
    {
        [HttpGet]
        [Route("Vjezba1")]

        public int Vjezba1(int a, int b, string s)
        {
                
            switch (s)
            {
                case "+":
                    return a + b;
                    break;
                case "-":
                    return a - b;
                    break;
                case "*":
                    return a * b;
                    break;
                case "/":
                    return a / b;
                    break;
                default:
                    return 0;
                    break;

            }
             
        }

        //[HttpPost]
        //[Route("Vjezba2")]

        //public int Vjezba2(double[] niz)
        //{
        //    for(int i = 0; i < 5; i++)
        //    {
        //        string pretvorba = niz.ToString();
        //        string[] skup = pretvorba.Split('.');
        //        int puniBrojevi = int.Parse(skup[0]);
        //        int izaDecimalne = int.Parse(skup[1]);
        //    }
            
        //    return 0;
        //}
    }
}
