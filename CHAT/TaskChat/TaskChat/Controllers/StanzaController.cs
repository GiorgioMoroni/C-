using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using TaskChat.DTO;
using TaskChat.Services;
using TaskChat.Utilis;

namespace TaskChat.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class StanzaController : Controller
    {
        private readonly StanzaServ _service;

        public StanzaController(StanzaServ service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult NuovaStanza(StanzaDTO newRoom)
        {
            try
            {
                if (User.Claims.FirstOrDefault(x => x.Type == "Username")?.Value != null)
                {
                    string username = User.Claims.First(x => x.Type == "Username").Value;
                    if (_service.Inserimento(newRoom, username))
                        return Ok(new Risposta() { Stato = "SUCCESS" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return BadRequest();
        }

        [HttpPost("chat/addUser/{id}")]
        public IActionResult AddUtente(string id, string username)
        {
            try
            {
                if (_service.InserisciUtente(username, new ObjectId(id)))
                    return Ok(new Risposta()
                    {
                        Stato = "Success"
                    });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return BadRequest();
        }







    }
}
