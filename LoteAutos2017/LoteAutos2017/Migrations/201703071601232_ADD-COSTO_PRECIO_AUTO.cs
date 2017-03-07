namespace LoteAutos2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDCOSTO_PRECIO_AUTO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autos", "Costo", c => c.Double(nullable: false));
            AddColumn("dbo.Autos", "PrecioVenta", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Autos", "PrecioVenta");
            DropColumn("dbo.Autos", "Costo");
        }
    }
}
