using ASP_Lez05_task_Nasa.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Lez05_task_Nasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SistemaController : Controller
    {
        private readonly SistemaService _service;

        public SistemaController(SistemaService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
