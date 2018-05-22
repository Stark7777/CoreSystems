using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.ViewModels
{
    public class DetalleFacturaVM
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float SubTotal { get; set; }
    }
}