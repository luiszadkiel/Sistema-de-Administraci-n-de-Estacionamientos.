using System.ComponentModel.DataAnnotations;

namespace p2_FINAAL_parqueo.Models

{
    public class Vehiculo
    {
        [Key]
        public int VehiculoID { get; set; }
        public int TipoVehiculoID { get; set; } // FK 
        public TipoVehiculo TipoVehiculo { get; set; }

    }
}
