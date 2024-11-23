using System;
using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models

{
    public class Estacionamientos
    {
        [Key]
        public int EstacionamientoID { get; set; }
        public int Numero_Estacionamiento { get; set; }
        public int Capacidad_Espacios { get; set; }
        public int Espacios_Disponibles { get; set; }

    }
}
