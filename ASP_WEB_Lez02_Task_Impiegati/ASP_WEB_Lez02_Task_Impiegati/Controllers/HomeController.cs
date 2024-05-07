using ASP_WEB_Lez02_Task_Impiegati.Models;
using ASP_WEB_Lez02_Task_Impiegati.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_WEB_Lez02_Task_Impiegati.Controllers
{
    public class HomeController : Controller
    {
        private readonly ImpiegatoService _service;

        public HomeController(ImpiegatoService service)
        {
            _service = service;
        }

        public IActionResult Lista()
        {
            List<Impiegato> elenco = _service.ElencoImpiegati();

            return View(elenco);
        }

        public IActionResult Inserimento()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult Salvataggio(Impiegato objImpiegato)
        {
            if (_service.InserisciImpiegato(objImpiegato))
                return Redirect("/Home/Lista");
            else
                return Redirect("/Home/Errore");
        }

        public IActionResult Dettaglio(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return Redirect("/Home/Errore");

            Impiegato? impiegato = _service.RicercaImpiegatoMatricola(varCodice);
            if (impiegato is null)
                return Redirect("/Home/Errore");

            return View(impiegato);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
