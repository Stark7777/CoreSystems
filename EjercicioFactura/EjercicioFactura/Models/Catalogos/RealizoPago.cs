using EjercicioFactura.Models.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Catalogos
{
    public class RealizoPago:EntidadBase
    {
        [Required]
        [StringLength(60, ErrorMessage = "No más de 60 Caracteres")]
        public string Nombre { get; set; }
        [Required]
        public string Identificacion { get; set; }

        //Propiedades de Navegacion
        public virtual ICollection<Factura> Factura{ get; set; }
    }
}