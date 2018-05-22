using EjercicioFactura.Models.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Facturacion
{
    public class Factura:EntidadBase
    {
        [Required]
        public long Consecutivo { get; set; }
        // [Required]
        //public string NumTicket { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public int IdRealizoPago { get; set; }
        // [Required]
        //public int IdTipoPagp { get; set; }
        [Required]
        public int IdFormadePago { get; set; }
        [Required]
        public float Descuento { get; set; }

        //Propiedades de Navegacion 
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
        public virtual ICollection<DetallePagoEfectivo> DetallePagoEfectivo  { get; set; }
        public virtual ICollection<DetallePagoCredito> DetallePagoCredito { get; set; }
        public virtual ICollection<DetallePagoTarjeta> DetallePagoTarjetas { get; set; }
        public virtual FormadePago FormadePago { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual RealizoPago RealizoPago { get; set; }
    }
}