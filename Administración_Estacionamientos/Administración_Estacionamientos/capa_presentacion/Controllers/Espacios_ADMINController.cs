using Administración_Estacionamientos.capa_negocio.interfaz;
using Administración_Estacionamientos_.capa_entidades.models;
using Microsoft.AspNetCore.Mvc;

namespace Administración_Estacionamientos_.capa_presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Espacios_ADMINController : Controller
    {
        private readonly IRepository<Espacios> service;

        public Espacios_ADMINController(IRepository<Espacios> service)
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
        public IActionResult Crear([FromBody] Espacios modelo)
        {
            if (modelo == null)
                return BadRequest("El modelo no puede ser nulo.");

            service.Set(modelo);
            return CreatedAtAction(nameof(Buscar), new { id = modelo.EspacioID }, modelo);
        }


        [HttpGet("{id}")]
        public IActionResult Buscar(int id)
        {
            var result = service.GetById(id);
            if (result == null)
                return NotFound($"No se encontró un administrador con ID {id}.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Borrar(int id)
        {
            try
            {
                var entity = service.GetById(id);
            if (entity == null)
                return NotFound($"No se encontró un administrador con ID {id}.");

            service.Delete(id);
            return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { status = "error", message = "Este espacio no se puedeo borrar poque tiene un registro en la BD"  });
            }
        }

        [HttpPut]
        public void Actualizar([FromBody] Espacios modelo)
        {
            service.Update(modelo);

        }
    }
}
