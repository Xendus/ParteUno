namespace BaseDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class semonsemon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IDCliente = c.Int(nullable: false, identity: true),
                        NombreC = c.String(),
                        Tel = c.Int(nullable: false),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.IDCliente);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        IDVenta = c.Int(nullable: false, identity: true),
                        IDTiempo = c.Int(nullable: false),
                        IDCodigo = c.Int(nullable: false),
                        IDCliente = c.Int(nullable: false),
                        IDEmpleado = c.Int(nullable: false),
                        DiaReq = c.String(),
                        CantUn = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDVenta)
                .ForeignKey("dbo.Clientes", t => t.IDCliente, cascadeDelete: true)
                .ForeignKey("dbo.Empleadoes", t => t.IDEmpleado, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.IDCodigo, cascadeDelete: true)
                .ForeignKey("dbo.Tiempoes", t => t.IDTiempo, cascadeDelete: true)
                .Index(t => t.IDTiempo)
                .Index(t => t.IDCodigo)
                .Index(t => t.IDCliente)
                .Index(t => t.IDEmpleado);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        IDEmpleado = c.Int(nullable: false, identity: true),
                        NombreE = c.String(),
                        Contratacion = c.String(),
                    })
                .PrimaryKey(t => t.IDEmpleado);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        IDCodigo = c.Int(nullable: false, identity: true),
                        NombreP = c.String(),
                        NombreCa = c.String(),
                        Precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDCodigo);
            
            CreateTable(
                "dbo.Tiempoes",
                c => new
                    {
                        IDTiempo = c.Int(nullable: false, identity: true),
                        Dia = c.String(),
                        Mes = c.String(),
                        Año = c.String(),
                    })
                .PrimaryKey(t => t.IDTiempo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "IDTiempo", "dbo.Tiempoes");
            DropForeignKey("dbo.Ventas", "IDCodigo", "dbo.Productoes");
            DropForeignKey("dbo.Ventas", "IDEmpleado", "dbo.Empleadoes");
            DropForeignKey("dbo.Ventas", "IDCliente", "dbo.Clientes");
            DropIndex("dbo.Ventas", new[] { "IDEmpleado" });
            DropIndex("dbo.Ventas", new[] { "IDCliente" });
            DropIndex("dbo.Ventas", new[] { "IDCodigo" });
            DropIndex("dbo.Ventas", new[] { "IDTiempo" });
            DropTable("dbo.Tiempoes");
            DropTable("dbo.Productoes");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Ventas");
            DropTable("dbo.Clientes");
        }
    }
}
