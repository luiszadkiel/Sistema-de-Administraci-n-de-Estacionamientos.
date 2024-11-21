using System;
using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models

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
      



    }
}
