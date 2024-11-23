using Administración_Estacionamientos_.capa_negocio;
using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models
{
    public class vehiculosPermmitidos
    {
        [Key]
        public int vehiculos_permmitidosID { get; set; }
        public string? NOMBRE_vehiculos_permmitidos { get; set; }

        
    }
}
