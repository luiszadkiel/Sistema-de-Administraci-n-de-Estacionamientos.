using System.ComponentModel.DataAnnotations;

namespace p2_FINAAL_parqueo.Models

{
	public class administar_vehiculos
    {
        [Key]
        public int TipoVehiculoID { get; set; }
        public string NombreTipo { get; set; }
    }
}
