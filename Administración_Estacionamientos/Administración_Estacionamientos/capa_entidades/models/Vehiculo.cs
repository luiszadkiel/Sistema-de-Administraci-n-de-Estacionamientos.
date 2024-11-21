using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models

{
    public class Vehiculo
    {
        [Key]
        public int VehiculoID { get; set; }
        public int TipoVehiculoID { get; set; } // FK 

    }
}
