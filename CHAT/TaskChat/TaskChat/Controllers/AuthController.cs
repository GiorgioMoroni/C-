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
    public class AuthController : Controller
    {
        private readonly UtenteServ _service;

        public AuthController(UtenteServ service)
        {
            _service = service;
        }

        [HttpGet("{nome}/{password}")]
        public IActionResult Login(string nome, string password)
        {
            if (!nome.Trim().Equals("") && !password.Equals(""))
            {
                string utente = _service.LoginUtente(new UtenteDTO() { Nom = nome, Pass = password });

                if (!utente.Equals(""))
                {
                    return Ok(new Risposta()
                    {
                        Stato = "SUCCESS",
                        Data = utente
                    });
                }
            }

            return BadRequest();
        }

        [HttpPost("login")]
        public IActionResult Loggati(UtenteDTO objLogin)
        {

            if (objLogin.Nom is not null && !_service.LoginUtente(objLogin).Equals(""))
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(JwtRegisteredClaimNames.Sub, objLogin.Nom),
                    new Claim("UserType", "user"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_super_secret_key_your_super_secret_key"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "Chat",
                    audience: "Utenti",
                    claims: claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: creds
                    );

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token), nickname = _service.LoginUtente(objLogin) });
            }

            return Unauthorized();
        }

















    }
}
