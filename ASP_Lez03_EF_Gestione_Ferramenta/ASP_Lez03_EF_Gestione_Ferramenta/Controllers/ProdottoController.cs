using ASP_Lez03_EF_Gestione_Ferramenta.Models;
using ASP_Lez03_EF_Gestione_Ferramenta.Repos;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Lez03_EF_Gestione_Ferramenta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdottoController : Controller
    {
        private readonly IRepo<Prodotto> _repository;


        public ProdottoController(IRepo<Prodotto> repo) 
        { 
            _repository = repo;
        }

        public ActionResult RestituisciTuttiProdotti()
        {
            return Ok(_repository.GetAll());
        }
    }
}
