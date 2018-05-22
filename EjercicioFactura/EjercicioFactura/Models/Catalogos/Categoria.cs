using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Facturacion
{
    public class Categoria:EntidadBase
    {
        [Required]
        [StringLength(30, ErrorMessage = "No más de 30 Caracteres")]
        public string Nombre { get; set; }

        //Propiedades de Navegacion
        public virtual ICollection<Producto> Producto{ get; set; }
    }
}