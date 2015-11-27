namespace BaseDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class semonpartedos : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tiempoes", "Año");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tiempoes", "Año", c => c.String());
        }
    }
}
