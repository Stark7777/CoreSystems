using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.ViewModels
{
    public class FacturasVM
    {
        public long Id { get; set; }
        public long Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string RealizoPago { get; set; }
        public string Pago { get; set; }
        public float Descuento { get; set; }
        public bool Estado { get; set; }
    }
}