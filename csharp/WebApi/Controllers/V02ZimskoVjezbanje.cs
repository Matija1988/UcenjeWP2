using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Diagnostics.CodeAnalysis;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje
    {

        [HttpGet]
        [Route("Vjezba1")]

        public int ZbrojPrvih100()
        {
            return 100 * (100 + 1) / 2;
        }

        [HttpGet]
        [Route("Vjezba2")]

        public int[] NizSParnimBrojevima()
        {
            
            int[] niz = new int[100];
            int a; 

            for(a = 1; a <= 57; a++)
            {
                if(a % 2 == 0)
                {
                    niz[a] = a;
                }
                    

            }

            return niz;  
            
        }


        [HttpGet]
        [Route("Vjezba3")]

        public int ZbrojBrojeva2Do18()
        {
            int suma;
            int[] niz = new int[100];

            for(int i = 2; i <= 18; i++)
            {
                if(i % 2 == 0)
                {
                    niz[i] = i;
                }
            }

            suma = niz.Sum();

            return suma;
        }

        [HttpGet]
        [Route("Vjezba4")]

        public int ZbrojOd1Do(int a) 
        {

           return a*(a+1); 
        }


    }
}
