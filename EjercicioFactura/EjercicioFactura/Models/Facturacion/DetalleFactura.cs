using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Facturacion
{
    public class DetalleFactura:EntidadBase
    {
        [Required]
        public long IdFactura { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public float Precio { get; set; }

        //Propiedades de Navegaciòn
        public virtual  Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }

    }
}