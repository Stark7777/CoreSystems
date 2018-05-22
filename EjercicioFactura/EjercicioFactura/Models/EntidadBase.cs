using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioFactura.Models
{
    public class EntidadBase
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual DateTime FechaCreacion { get; set; }
        public virtual DateTime FechaModificado { get; set; }
        public virtual int Version { get; set; }
        [DefaultValue(true)]
        public virtual Boolean Estado { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
        public override bool Equals(object obj)
        {
            var entidad = obj as EntidadBase;
            if (entidad != null)
            {
                return (entidad.Id == this.Id && entidad.FechaCreacion == this.FechaCreacion) ? true : false;
            }
            else
            {
                return false;
            }
        }
    }
}