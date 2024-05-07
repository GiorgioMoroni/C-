using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskChat.DTO;
using TaskChat.Models;
using TaskChat.Services;
using TaskChat.Utilis;

namespace TaskChat.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MessaggioController : Controller
    {
        private readonly MessaggioServ _service;

        public MessaggioController(MessaggioServ service)
        {
            _service = service;
        }

        [HttpPost("sendMessage/{staID}")]
        public IActionResult InserisciMessaggio(Messaggio m, string staID)
        {
            try
            {
                var us = User.Claims.FirstOrDefault(x => x.Type == "Username")?.Value;
                if (us != null)
                {
                    m.Mittente = User.Claims.First(x => x.Type == "Username").Value;
                    m.StanzaRIF = new MongoDB.Bson.ObjectId(staID);
                    if (_service.InserimentoMessaggio(m))
                        return Ok(new Risposta() { Stato = "SUCCESS" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return BadRequest();
        }




























    }
}

    

