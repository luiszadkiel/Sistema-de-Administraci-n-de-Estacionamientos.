using System;
using System.ComponentModel.DataAnnotations;

namespace p2_FINAAL_parqueo.Models

{
    public class Administrador
    {
        [Key]
        public int AdministradorID { get; set; }
        public string NombreUsuario { get; set; } 
        public string Contrasena { get; set; }
        public DateTime FechaCreacion { get; set; } 
        public DateTime? UltimoLogueo { get; set; }
    }

}
