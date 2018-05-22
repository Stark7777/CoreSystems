using EjercicioFactura.Models.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Catalogos
{
    public class Moneda:EntidadBase
    {
      
        [Required]
        [StringLength(30, ErrorMessage = "No más de 30 Caracteres")]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(2, ErrorMessage = "No más de 2 Caracteres")]
        public string Simbolo { get; set; }

        //Propiedades de Navegación
        public virtual ICollection<DetallePagoTarjeta> DetallePagoTarjeta { get; set; }
        public virtual ICollection<DetallePagoEfectivo> DetallePagoEfectivo { get; set; }
    }
}