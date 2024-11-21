using Administración_Estacionamientos.capa_negocio.interfaz;
using Administración_Estacionamientos_.capa_entidades.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Administración_Estacionamientos_.capa_presentacion.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class administradoresController : Controller
    {

        private readonly IRepository<administradores> service;
        public administradoresController(IRepository<administradores> service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(service.GetAll());
        }
    }
}
