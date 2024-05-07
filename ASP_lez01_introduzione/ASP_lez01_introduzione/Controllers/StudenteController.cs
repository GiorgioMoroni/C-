using ASP_lez01_introduzione.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_lez01_introduzione.Controllers
{
    [ApiController]
    [Route("api/studente")]
    public class StudenteController : Controller
    {
        [HttpGet("test")]
        public IActionResult TestGet()
        {
            return Ok("Test di GET");
        }

        [HttpPost("test")]
        public IActionResult TestPost()
        {
            return Ok("Test di POST");
        }

        [HttpGet("dettaglio")]
        public ActionResult<Studente?> RecuperaStudenti()
        {
            Studente stu = new Studente()
            {
                Id = 1,
                Nome = "Giovanni",
                Cognome = "Pace",
                Matricola = "AB1234"
            };

            return Ok(stu);
        }

        [HttpGet("elenco")]
        public ActionResult<List<Studente>> ElencoStudenti()
        {
            List<Studente> lista = new List<Studente>();

            Studente stu1 = new Studente()
            {
                Id = 1,
                Nome = "Giovanni",
                Cognome = "Pace",
                Matricola = "AB1234"
            };

            Studente stu2 = new Studente()
            {
                Id = 2,
                Nome = "Valeria",
                Cognome = "Verdi",
                Matricola = "AB1235"
            };

            Studente stu3 = new Studente()
            {
                Id = 3,
                Nome = "Mario",
                Cognome = "Rossi",
                Matricola = "AB1236"
            };

            lista.Add(stu1);
            lista.Add(stu2);
            lista.Add(stu3);

            return Ok(lista);

        }

        [HttpPost("inserisci")]
        public ActionResult Inserisci(Studente objStud)
        {
            return Ok(objStud);
        }
    }
}
