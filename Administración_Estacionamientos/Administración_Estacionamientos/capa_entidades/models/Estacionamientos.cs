using System;
using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models

{
    public class Estacionamientos
    {
        [Key]
        public int EstacionamientoID { get; set; }
        public int NumeroEstacionamiento { get; set; }
        public int CapacidadEspacios { get; set; }
        public int EspaciosDisponibles { get; set; }

    }
}
