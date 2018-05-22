using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using EjercicioFactura.Contexto;
using EjercicioFactura.Models.ViewModels;

namespace EjercicioFactura.Controllers
{

   [EnableCors(origins: "http://localhost:20278",headers:"*",methods:"*")]
    public class FacturasController : ApiController
    {
        private FacturacionContext db = new FacturacionContext();

        public ICollection<FacturasVM> GetFacturas()
        {
            var facturas = (from f in db.Factura
                            join c in db.Clientes on f.IdCliente equals c.Id
                            join r in db.RealizoPago on f.IdRealizoPago equals r.Id
                            join fp in db.FormadePago on f.IdFormadePago equals fp.Id
                            //where f.Estado == true
                            select new FacturasVM
                            {
                                Id=f.Id,
                                Consecutivo = f.Consecutivo,
                                Fecha = f.Fecha,
                                Cliente = c.Nombre,
                                RealizoPago = r.Nombre,
                                Pago = fp.Descripcion,
                                Descuento = f.Descuento,
                                Estado = f.Estado
                            }).ToList();
            return facturas;
        }

        public ICollection<DetalleFacturaVM> GetDetalle(long id)
        {
            var detalle = (from d in db.DetalleFactura
                            join p in db.Producto on d.IdProducto equals p.Id                           
                            where d.Estado == true && d.IdFactura==id
                            select new DetalleFacturaVM
                            {
                               Producto=p.Descripcion,
                               Cantidad=d.Cantidad,
                               Precio=d.Precio,
                               SubTotal=d.Cantidad*d.Precio
                            }).ToList();
            return detalle;
        }
    }
}
