using EjercicioFactura.Models.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Facturacion
{
    public class DetallePagoTarjeta:EntidadBase
    {
        [Required]
        public long IdFactura { get; set; }
        [Required]
        public int IdBanco { get; set; }
        [Required]
        public int IdMoneda { get; set; }
        //[Required]
        //public string NumTarjeta { get; set; }
        [Required]
        public string Referencia { get; set; }
        [Required]
        public float Monto { get; set; }


        //Propiedades de Navegación
        public virtual Banco Banco { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual Factura Factura { get; set; }
    }
}