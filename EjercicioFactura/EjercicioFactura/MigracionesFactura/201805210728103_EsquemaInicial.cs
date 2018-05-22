namespace EjercicioFactura.MigracionesFactura
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EsquemaInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Facturacion.Bancoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Facturacion.DetallePagoTarjetas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdFactura = c.Long(nullable: false),
                        IdBanco = c.Int(nullable: false),
                        IdMoneda = c.Int(nullable: false),
                        Referencia = c.String(nullable: false),
                        Monto = c.Single(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Banco_Id = c.Long(),
                        Moneda_Id = c.Long(),
                        Factura_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facturacion.Bancoes", t => t.Banco_Id)
                .ForeignKey("Facturacion.Monedas", t => t.Moneda_Id)
                .ForeignKey("Facturacion.Facturas", t => t.Factura_Id)
                .Index(t => t.Banco_Id)
                .Index(t => t.Moneda_Id)
                .Index(t => t.Factura_Id);
            
            CreateTable(
                "Facturacion.Facturas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Consecutivo = c.Long(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Usuario = c.String(),
                        IdCliente = c.Int(nullable: false),
                        IdRealizoPago = c.Int(nullable: false),
                        IdFormadePago = c.Int(nullable: false),
                        Descuento = c.Single(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Cliente_Id = c.Long(),
                        FormadePago_Id = c.Long(),
                        RealizoPago_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facturacion.Clientes", t => t.Cliente_Id)
                .ForeignKey("Facturacion.FormadePagoes", t => t.FormadePago_Id)
                .ForeignKey("Facturacion.RealizoPagoes", t => t.RealizoPago_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.FormadePago_Id)
                .Index(t => t.RealizoPago_Id);
            
            CreateTable(
                "Facturacion.Clientes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        TipoCliente = c.Boolean(nullable: false),
                        Correo = c.String(maxLength: 60),
                        TelefonoContacto = c.String(maxLength: 8),
                        Identificacion = c.String(nullable: false, maxLength: 17),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Facturacion.DetalleFacturas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdFactura = c.Long(nullable: false),
                        IdProducto = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Single(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Factura_Id = c.Long(),
                        Producto_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facturacion.Facturas", t => t.Factura_Id)
                .ForeignKey("Facturacion.Productoes", t => t.Producto_Id)
                .Index(t => t.Factura_Id)
                .Index(t => t.Producto_Id);
            
            CreateTable(
                "Facturacion.Productoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        IdCategoria = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Categoria_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facturacion.Categorias", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
            CreateTable(
                "Facturacion.Categorias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Facturacion.DetalleEntradas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdEntrada = c.Long(nullable: false),
                        IdProducto = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        CostoUnitario = c.Single(nullable: false),
                        CostoVenta = c.Single(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Entrada_Id = c.Long(),
                        Producto_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facturacion.Entradas", t => t.Entrada_Id)
                .ForeignKey("Facturacion.Productoes", t => t.Producto_Id)
                .Index(t => t.Entrada_Id)
                .Index(t => t.Producto_Id);
            
            CreateTable(
                "Facturacion.Entradas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        NoOrden = c.Long(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        IdProveedor = c.Int(nullable: false),
                        Observaciones = c.String(maxLength: 150),
                        NumFacturaEntrada = c.Long(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Proveedor_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facturacion.Proveedors", t => t.Proveedor_Id)
                .Index(t => t.Proveedor_Id);
            
            CreateTable(
                "Facturacion.Proveedors",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        Correo = c.String(maxLength: 60),
                        TelefonoContacto = c.String(maxLength: 8),
                        IdentificacionRuc = c.String(nullable: false, maxLength: 17),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Facturacion.DetallePagoCreditoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdFactura = c.Long(nullable: false),
                        NumCredito = c.Long(nullable: false),
                        FechaLimitePago = c.DateTime(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Factura_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facturacion.Facturas", t => t.Factura_Id)
                .Index(t => t.Factura_Id);
            
            CreateTable(
                "Facturacion.DetallePagoEfectivoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdFactura = c.Long(nullable: false),
                        IdMoneda = c.Int(nullable: false),
                        Monto = c.Single(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Factura_Id = c.Long(),
                        Moneda_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facturacion.Facturas", t => t.Factura_Id)
                .ForeignKey("Facturacion.Monedas", t => t.Moneda_Id)
                .Index(t => t.Factura_Id)
                .Index(t => t.Moneda_Id);
            
            CreateTable(
                "Facturacion.Monedas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                        Simbolo = c.String(nullable: false, maxLength: 2),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Facturacion.FormadePagoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Facturacion.RealizoPagoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        Identificacion = c.String(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificado = c.DateTime(nullable: false),
                        Version = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Facturacion.Facturas", "RealizoPago_Id", "Facturacion.RealizoPagoes");
            DropForeignKey("Facturacion.Facturas", "FormadePago_Id", "Facturacion.FormadePagoes");
            DropForeignKey("Facturacion.DetallePagoTarjetas", "Factura_Id", "Facturacion.Facturas");
            DropForeignKey("Facturacion.DetallePagoTarjetas", "Moneda_Id", "Facturacion.Monedas");
            DropForeignKey("Facturacion.DetallePagoEfectivoes", "Moneda_Id", "Facturacion.Monedas");
            DropForeignKey("Facturacion.DetallePagoEfectivoes", "Factura_Id", "Facturacion.Facturas");
            DropForeignKey("Facturacion.DetallePagoCreditoes", "Factura_Id", "Facturacion.Facturas");
            DropForeignKey("Facturacion.DetalleFacturas", "Producto_Id", "Facturacion.Productoes");
            DropForeignKey("Facturacion.DetalleEntradas", "Producto_Id", "Facturacion.Productoes");
            DropForeignKey("Facturacion.Entradas", "Proveedor_Id", "Facturacion.Proveedors");
            DropForeignKey("Facturacion.DetalleEntradas", "Entrada_Id", "Facturacion.Entradas");
            DropForeignKey("Facturacion.Productoes", "Categoria_Id", "Facturacion.Categorias");
            DropForeignKey("Facturacion.DetalleFacturas", "Factura_Id", "Facturacion.Facturas");
            DropForeignKey("Facturacion.Facturas", "Cliente_Id", "Facturacion.Clientes");
            DropForeignKey("Facturacion.DetallePagoTarjetas", "Banco_Id", "Facturacion.Bancoes");
            DropIndex("Facturacion.DetallePagoEfectivoes", new[] { "Moneda_Id" });
            DropIndex("Facturacion.DetallePagoEfectivoes", new[] { "Factura_Id" });
            DropIndex("Facturacion.DetallePagoCreditoes", new[] { "Factura_Id" });
            DropIndex("Facturacion.Entradas", new[] { "Proveedor_Id" });
            DropIndex("Facturacion.DetalleEntradas", new[] { "Producto_Id" });
            DropIndex("Facturacion.DetalleEntradas", new[] { "Entrada_Id" });
            DropIndex("Facturacion.Productoes", new[] { "Categoria_Id" });
            DropIndex("Facturacion.DetalleFacturas", new[] { "Producto_Id" });
            DropIndex("Facturacion.DetalleFacturas", new[] { "Factura_Id" });
            DropIndex("Facturacion.Facturas", new[] { "RealizoPago_Id" });
            DropIndex("Facturacion.Facturas", new[] { "FormadePago_Id" });
            DropIndex("Facturacion.Facturas", new[] { "Cliente_Id" });
            DropIndex("Facturacion.DetallePagoTarjetas", new[] { "Factura_Id" });
            DropIndex("Facturacion.DetallePagoTarjetas", new[] { "Moneda_Id" });
            DropIndex("Facturacion.DetallePagoTarjetas", new[] { "Banco_Id" });
            DropTable("Facturacion.RealizoPagoes");
            DropTable("Facturacion.FormadePagoes");
            DropTable("Facturacion.Monedas");
            DropTable("Facturacion.DetallePagoEfectivoes");
            DropTable("Facturacion.DetallePagoCreditoes");
            DropTable("Facturacion.Proveedors");
            DropTable("Facturacion.Entradas");
            DropTable("Facturacion.DetalleEntradas");
            DropTable("Facturacion.Categorias");
            DropTable("Facturacion.Productoes");
            DropTable("Facturacion.DetalleFacturas");
            DropTable("Facturacion.Clientes");
            DropTable("Facturacion.Facturas");
            DropTable("Facturacion.DetallePagoTarjetas");
            DropTable("Facturacion.Bancoes");
        }
    }
}
