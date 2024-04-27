using CapaEntidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Xml.Linq;

namespace CapaDatos
{
    public partial class ContextoDB : DbContext
    {
        public ContextoDB() : base("name=ContextoDB")
        {

        }


       

        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }





    }
}
