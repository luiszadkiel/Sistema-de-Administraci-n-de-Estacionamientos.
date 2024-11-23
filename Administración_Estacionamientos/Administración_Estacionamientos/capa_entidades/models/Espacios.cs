using System;
using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models

{
    public class Espacios
    {
        [Key]
        public int EspacioID { get; set; }
        public int Numero_Espacio { get; set; }
        public string Estado { get; set; } // "Disponible" o "Ocupado"
        public TimeSpan? Tiempo_Ocupado { get; set; }
        public string Tipo_Espacio { get; set; } //"Por tipo de carro
        public int EstacionamientoID { get; set; } // FK 
      



    }
}
