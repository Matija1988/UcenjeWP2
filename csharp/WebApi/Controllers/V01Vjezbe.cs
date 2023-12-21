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

        //private int[] Vjezba2(double[] niz)
        //{
        //    string[] s = niz.ToString();
            

        //    return null;
        //}  
    }
}
