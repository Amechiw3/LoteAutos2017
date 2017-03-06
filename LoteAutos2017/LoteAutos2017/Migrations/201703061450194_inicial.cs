namespace LoteAutos2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autos",
                c => new
                    {
                        pkAuto = c.Int(nullable: false, identity: true),
                        sMarca = c.String(nullable: false, unicode: false),
                        sModelo = c.String(nullable: false, unicode: false),
                        iAnio = c.Int(nullable: false),
                        sNumeroSerie = c.String(nullable: false, unicode: false),
                        sDescripcion = c.String(unicode: false),
                        sFotoPrincipal = c.String(nullable: false, unicode: false),
                        sFotoSecundaria = c.String(nullable: false, unicode: false),
                        sFotoTercearia = c.String(nullable: false, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        clienteVendedor_pkClientesVendedor = c.Int(),
                    })
                .PrimaryKey(t => t.pkAuto)
                .ForeignKey("dbo.ClientesVendedor", t => t.clienteVendedor_pkClientesVendedor)
                .Index(t => t.clienteVendedor_pkClientesVendedor);
            
            CreateTable(
                "dbo.ClientesVendedor",
                c => new
                    {
                        pkClientesVendedor = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.pkClientesVendedor);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Autos", "clienteVendedor_pkClientesVendedor", "dbo.ClientesVendedor");
            DropIndex("dbo.Autos", new[] { "clienteVendedor_pkClientesVendedor" });
            DropTable("dbo.Clientes");
            DropTable("dbo.ClientesVendedor");
            DropTable("dbo.Autos");
        }
    }
}
