using Microsoft.AspNetCore.Mvc;

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

        public int NizSParnimBrojevima()
        {

            for (int i = 1; i < 57; i++)
            {
                int a;
                if(i % 2 == 0)
                {
                    a = i;
                }
            }

            

            return 0; 
        }
    }
}
