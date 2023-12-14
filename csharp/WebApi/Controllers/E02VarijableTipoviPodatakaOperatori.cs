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
        


    }
}
