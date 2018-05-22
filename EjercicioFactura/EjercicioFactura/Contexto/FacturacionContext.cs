using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EjercicioFactura.Models.Catalogos;
using EjercicioFactura.Models.Facturacion;

namespace EjercicioFactura.Contexto
{
    public class FacturacionContext:DbContext
    {
        public FacturacionContext():base("FacturaContext")
        {

        }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Facturacion");
        }
        //Mapeo de Entidades
        public DbSet<Banco> Banco { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<FormadePago> FormadePago { get; set; }
        public DbSet<Moneda> Moneda { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<RealizoPago> RealizoPago { get; set; }

        //Mapeo de Entidades de Facturacion
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        public DbSet<DetallePagoTarjeta> DetallePagoTarjeta { get; set; }
        public DbSet<DetallePagoEfectivo> DetallePagoEfectivo { get; set; }

        public System.Data.Entity.DbSet<EjercicioFactura.Models.Facturacion.Cliente> Clientes { get; set; }
    }
}