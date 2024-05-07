using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskChat.DTO;
using TaskChat.Services;
using TaskChat.Utilis;

namespace TaskChat.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UtenteController : Controller
    {
        
        readonly UtenteServ _service;

        public UtenteController(UtenteServ service)
        {
            _service = service;
        }

        [HttpPost("Register")]
        public IActionResult Register(UtenteDTO utente)
        {
            if (ModelState.IsValid)
            {
                if (_service.Registra(utente))
                {
                    return Ok(new Risposta()
                    {
                        Stato = "SUCCESS",
                        Data = true
                    });
                }
            }

            return BadRequest();
        }

        
    }
}
