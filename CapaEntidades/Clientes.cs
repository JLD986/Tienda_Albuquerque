using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }
        [Required]

        public int telefono { get; set; }
        [Required]
        [MaxLength(100)]
        public string direccion { get; set; }

        //Clientes pa la tiendita 
    }
}
