using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EjercicioFactura.Models.Catalogos;

namespace EjercicioFactura.Models.Facturacion
{
    public class DetallePagoEfectivo:EntidadBase
    {
        [Required]
        public long IdFactura { get; set; }
        [Required]
        public int IdMoneda { get; set; }
        [Required]
        public float Monto { get; set; }

        //Propiedades de Navegaciòn
        public virtual Moneda Moneda { get; set; }
        public virtual Factura Factura { get; set; }
    }
}