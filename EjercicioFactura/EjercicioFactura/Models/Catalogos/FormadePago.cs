using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Facturacion
{
    public class FormadePago:EntidadBase
    {
        [Required]
        public string Codigo { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "No más de 30 Caracteres")]
        public string Descripcion { get; set; }

        //Propiedades de Navegacion
        public virtual ICollection<Factura> Factura { get; set; }
    }
}