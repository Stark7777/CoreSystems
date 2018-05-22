using EjercicioFactura.Models.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Catalogos
{
    public class Banco:EntidadBase
    {
        [Required]
        [StringLength(30, ErrorMessage = "No más de 30 Caracteres")]
        public string Nombre { get; set; }

        //Propiedades de Navegación
        public ICollection<DetallePagoTarjeta> DetallePagoTarjeta { get; set; }
    }
}