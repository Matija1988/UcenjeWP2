using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("E01")]
    public class E01UlazIzlaz : ControllerBase
    {
 
        [HttpGet]
        [Route("Hello")]
        public string Helloworld(string ime, int godine, bool aktivan)
        {
            return "Upisali ste " + ime + ", koji ima " + godine + " godina " + aktivan; 
        }
        

    }
}   