﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVenta { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public DateTime Fecha { get; set; }

        public List<Detalle_Venta> Detalles { get; set; }

        public Venta()
        {
            Detalles = new List<Detalle_Venta>();
        }
    }
}
