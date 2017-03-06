namespace LoteAutos2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        pkCliente = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                        sApellidos = c.String(nullable: false, unicode: false),
                        sEmail = c.String(unicode: false),
                        sTelefono = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkCliente);
            
            CreateTable(
                "dbo.ClientesVendedor",
                c => new
                    {
                        pkComprador = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                        sApellidos = c.String(nullable: false, unicode: false),
                        sEmail = c.String(unicode: false),
                        sTelefono = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        sINE = c.String(nullable: false, unicode: false),
                        sCalle = c.String(nullable: false, unicode: false),
                        sNumero = c.String(nullable: false, unicode: false),
                        sEntreCalle = c.String(unicode: false),
                        sColonia = c.String(nullable: false, unicode: false),
                        sCiudad = c.String(nullable: false, unicode: false),
                        sEstado = c.String(unicode: false),
                        sImagen = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.pkComprador);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientesVendedor");
            DropTable("dbo.Clientes");
        }
    }
}
