using System;
using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models

{
    public class administradores
    {
        [Key]
        public int AdministradorID { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime? Ultimo_Logueo { get; set; }
    }

}
