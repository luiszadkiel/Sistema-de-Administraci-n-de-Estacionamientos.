using Microsoft.AspNetCore.Mvc;
using Repository.Services;

namespace p2_FINAAL_parqueo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class administradoresController : Controller
    {

        private readonly IRepository<Administradores> service;
        public administradoresController(IRepository<Administradores> service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
