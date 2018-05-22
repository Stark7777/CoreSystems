using EjercicioFactura.Models.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Entradas
{
    public class Entrada:EntidadBase
    {
        [Required]      
        public long NoOrden { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int IdProveedor { get; set; }
        [StringLength(150, ErrorMessage = "No más de 150 Caracteres")]
        public string Observaciones { get; set; }
        [Required]
        public long NumFacturaEntrada { get; set; }

        //Propiedades de Navegacion
        public  virtual Proveedor Proveedor { get; set; }
        public virtual ICollection<DetalleEntrada> DetalleEntrada { get; set; }

    }
}