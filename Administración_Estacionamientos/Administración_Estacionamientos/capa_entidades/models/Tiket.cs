using System;
using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models

{
    public class Tiket
    {
        [Key]
        public int TiketID { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaHora_Ingreso { get; set; }
        public DateTime? FechaHora_Salida { get; set; }
        public decimal? Monto_Tarifa { get; set; }
        public TimeSpan? Tiempo_Estacionado { get; set; }
        public int EstacionamientoID { get; set; } // FK 
        public int VehiculoID { get; set; } // FK 
        public int EspacioID { get; set; } // FK 

       
    }
}
