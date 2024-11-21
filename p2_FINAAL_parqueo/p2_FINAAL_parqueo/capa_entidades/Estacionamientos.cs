using System;
using System.ComponentModel.DataAnnotations;

namespace p2_FINAAL_parqueo.Models

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
