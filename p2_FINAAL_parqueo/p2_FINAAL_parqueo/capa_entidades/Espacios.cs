using System;
using System.ComponentModel.DataAnnotations;

namespace p2_FINAAL_parqueo.Models

{
    public class Espacios
    {
        [Key]
        public int EspacioID { get; set; }
        public int NumeroEspacio { get; set; }
        public string Estado { get; set; } // "Disponible" o "Ocupado"
        public TimeSpan? TiempoOcupado { get; set; } 
        public string TipoEspacio { get; set; } //"Por tipo de carro
        public int EstacionamientoID { get; set; } // FK 
        public Estacionamiento Estacionamiento { get; set; } // Relación 



    }
}
