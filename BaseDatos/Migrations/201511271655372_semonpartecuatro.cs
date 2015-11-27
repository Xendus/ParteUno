namespace BaseDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class semonpartecuatro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proveedors", "NumeroDeEntrega", c => c.String());
            AddColumn("dbo.Proveedors", "NombreProveedor", c => c.String());
            AddColumn("dbo.Tiempoes", "NumeroDeEntrega", c => c.String());
            AddColumn("dbo.Tiempoes", "NombreProveedor", c => c.String());
            DropColumn("dbo.Proveedors", "NumE");
            DropColumn("dbo.Proveedors", "NomP");
            DropColumn("dbo.Tiempoes", "Dia");
            DropColumn("dbo.Tiempoes", "Mes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tiempoes", "Mes", c => c.String());
            AddColumn("dbo.Tiempoes", "Dia", c => c.String());
            AddColumn("dbo.Proveedors", "NomP", c => c.String());
            AddColumn("dbo.Proveedors", "NumE", c => c.String());
            DropColumn("dbo.Tiempoes", "NombreProveedor");
            DropColumn("dbo.Tiempoes", "NumeroDeEntrega");
            DropColumn("dbo.Proveedors", "NombreProveedor");
            DropColumn("dbo.Proveedors", "NumeroDeEntrega");
        }
    }
}
