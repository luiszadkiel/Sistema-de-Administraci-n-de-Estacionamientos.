﻿using Administración_Estacionamientos.capa_negocio.interfaz;
using Administración_Estacionamientos_.capa_entidades.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Administración_Estacionamientos_.capa_presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradoresController : ControllerBase
    {
        private readonly IRepository<administradores> service;

        public AdministradoresController(IRepository<administradores> service)
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
        public IActionResult Crear([FromBody] administradores modelo)
        {
            if (modelo == null)
                return BadRequest("El modelo no puede ser nulo.");

            service.Set(modelo);
            return CreatedAtAction(nameof(Buscar), new { id = modelo.AdministradorID }, modelo);
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
            var entity = service.GetById(id);
            if (entity == null)
                return NotFound($"No se encontró un administrador con ID {id}.");

            service.Delete(id);
            return NoContent();
        }

        [HttpPut]
        public void  Actualizar([FromBody] administradores modelo)
        {
            service.Update(modelo);      
        
        }
    }
}
