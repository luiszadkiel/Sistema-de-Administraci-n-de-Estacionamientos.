﻿using System;
using System.ComponentModel.DataAnnotations;

namespace p2_FINAAL_parqueo.Models

{
    public class Tiket
    {
        [Key]
        public int TiketID { get; set; }
        public string Codigo { get; set; } 
        public DateTime FechaHoraIngreso { get; set; } 
        public DateTime? FechaHoraSalida { get; set; } 
        public decimal? MontoTarifa { get; set; } 
        public TimeSpan? TiempoEstacionado { get; set; } 
        public int EstacionamientoID { get; set; } // FK 
        public int VehiculoID { get; set; } // FK 
        public int EspacioID { get; set; } // FK 

        // Relaciones 
        public Estacionamiento Estacionamiento { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Espacio Espacio { get; set; }
    }
}