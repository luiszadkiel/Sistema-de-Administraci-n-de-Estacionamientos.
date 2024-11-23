using Administración_Estacionamientos.capa_negocio.interfaz;
using Administración_Estacionamientos_.capa_entidades.models;
using Microsoft.AspNetCore.Mvc;

namespace Administración_Estacionamientos_.capa_presentacion.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class TiketController : ControllerBase
        {
            private readonly IRepository<Tiket> service;

            public TiketController(IRepository<Tiket> service)
            {
                this.service = service;
            }

            [HttpGet]
            public IActionResult VerTodos()
            {
                var result = service.GetAll();
                return Ok(result);
            }

            [HttpPost]
            public IActionResult Crear([FromBody] Tiket modelo)
            {

                if (modelo == null)
                    return BadRequest("El modelo no puede ser nulo.");

                service.Set(modelo);
                return CreatedAtAction(nameof(Buscar), new { id = modelo.TiketID }, modelo);


            }


            [HttpGet("{id}")]
            public IActionResult Buscar(int id)
            {
                var result = service.GetById(id);
                if (result == null)
                    return NotFound($"No se encontró un administrador con ID {id}.");

                return Ok(result);
            }


            [HttpPut]
            public void Actualizar([FromBody] Tiket modelo)
            {
                service.Update(modelo);

            }
        }
    
}
