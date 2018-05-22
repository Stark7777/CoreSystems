using EjercicioFactura.Models.Entradas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models.Catalogos
{
    public class Proveedor:EntidadBase
    {
        [Required]
        public int Codigo { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "No más de 60 Caracteres")]
        public string Nombre { get; set; }
       
        [StringLength(60, ErrorMessage = "No más de 60 Caracteres")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }
        //[Required]
        [StringLength(8, ErrorMessage = "No más de 8 Caracteres")]
        public string TelefonoContacto { get; set; }
        [Required]
        [StringLength(17, ErrorMessage = "No más de 17 Caracteres")]
        public string IdentificacionRuc { get; set; }

        //Propiedades de Navegacion
        public virtual ICollection<Entrada> Entradas { get; set; }
    }
}