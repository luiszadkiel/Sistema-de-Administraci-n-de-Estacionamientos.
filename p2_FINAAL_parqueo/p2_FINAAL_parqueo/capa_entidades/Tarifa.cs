using System;
using System.ComponentModel.DataAnnotations;

namespace p2_FINAAL_parqueo.Models

{
    public class Tarifa
    {
        [Key]
        public int TarifaID { get; set; }
        public int TipoVehiculoID { get; set; } // FK 
        public decimal TarifaPorHora { get; set; } 

        // Relación
        public TipoVehiculo TipoVehiculo { get; set; }
    }
}
