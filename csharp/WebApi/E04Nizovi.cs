using Microsoft.AspNetCore.Mvc;

namespace WebApi
{

    [ApiController]
    [Route("E04")]
    public class E04Nizovi
    {
        [HttpGet]
        [Route("zad1")]

        private string zad1(int broj)
        {

            return "Nije gotovo";
        }

    }
}
