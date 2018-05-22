using EjercicioFactura.Models.Entradas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Facturacion
{
    public class Producto:EntidadBase
    {
        [Required]
        public long Codigo { get; set; }
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public string Descripcion { get; set; }

        //Propiedades de Navegacion
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
        public virtual ICollection<DetalleEntrada> DetalleEntrada { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}