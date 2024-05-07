using Microsoft.AspNetCore.Mvc;

namespace ASP_lez01_introduzione.Controllers
{
    [Route("api/hello")]
    public class HelloController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return Ok("Ciao sono la Index");
        }

        [HttpGet("saluta")]
        public IActionResult Saluta()
        {
            return Ok("Ciao Giovanni");
        }

        [HttpGet("saluta/{valNome}/{valCognome}")]
        public IActionResult SalutaPersonalizzato(string valNome, string valCognome)
        {
            return Ok($"Ciao {valNome} {valCognome}");
        }

        [HttpGet("numerico/{valNumero}")]
        public IActionResult SalutaPersonalizzato(int valNumero)
        {
            return Ok($"Ciao {valNumero}");
        }
    }
}
