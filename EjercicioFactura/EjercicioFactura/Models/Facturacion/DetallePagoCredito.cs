using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Facturacion
{
    public class DetallePagoCredito:EntidadBase
    {
        [Required]
        public long IdFactura { get; set; }
        [Required]
        public long NumCredito { get; set; }
        [Required]
        public DateTime FechaLimitePago { get; set; }

        //Propiedades de Navegaciòn
        public virtual Factura Factura { get; set; }
    }
}