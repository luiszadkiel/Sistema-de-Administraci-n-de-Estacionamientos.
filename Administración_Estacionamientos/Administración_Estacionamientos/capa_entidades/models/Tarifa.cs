using System;
using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models

{
    public class Tarifa
    {
        [Key]
        public int TarifaID { get; set; }
        public int TipoVehiculoID { get; set; } // FK 
        
        public decimal Tarifa_Por_Hora { get; set; }

       
    }
}
