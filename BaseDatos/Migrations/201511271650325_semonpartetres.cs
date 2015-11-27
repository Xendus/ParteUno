namespace BaseDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class semonpartetres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        IDProveedor = c.Int(nullable: false, identity: true),
                        NumE = c.String(),
                        NomP = c.String(),
                    })
                .PrimaryKey(t => t.IDProveedor);
            
            AddColumn("dbo.Ventas", "Proveedor_IDProveedor", c => c.Int());
            CreateIndex("dbo.Ventas", "Proveedor_IDProveedor");
            AddForeignKey("dbo.Ventas", "Proveedor_IDProveedor", "dbo.Proveedors", "IDProveedor");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "Proveedor_IDProveedor", "dbo.Proveedors");
            DropIndex("dbo.Ventas", new[] { "Proveedor_IDProveedor" });
            DropColumn("dbo.Ventas", "Proveedor_IDProveedor");
            DropTable("dbo.Proveedors");
        }
    }
}
