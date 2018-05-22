using EjercicioFactura.Models.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Entradas
{
    public class DetalleEntrada:EntidadBase
    {
        public long IdEntrada { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public float CostoUnitario { get; set; }
        public float CostoVenta { get; set; }

        //Propiedades de Navegacion 
        public virtual Entrada Entrada { get; set; }
        public virtual Producto Producto { get; set; }
    }
}