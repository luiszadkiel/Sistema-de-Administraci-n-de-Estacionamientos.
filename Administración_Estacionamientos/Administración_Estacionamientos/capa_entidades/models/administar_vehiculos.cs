﻿using Administración_Estacionamientos_.capa_negocio;
using System.ComponentModel.DataAnnotations;

namespace Administración_Estacionamientos_.capa_entidades.models

{
    public class administar_vehiculos
    {
        [Key]
        public int TipoVehiculoID { get; set; }
        public string Nombre_Tipo { get; set; }
    }
 
}
