namespace LoteAutos2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDTABLAVENTAS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        pkVenta = c.Int(nullable: false, identity: true),
                        dFechaVenta = c.DateTime(nullable: false, precision: 0),
                        fkAuto = c.Int(nullable: false),
                        PrecioVenta = c.Double(nullable: false),
                        bStatus = c.Boolean(nullable: false),
                        TipoMovimiento = c.Int(nullable: false),
                        cliente_pkCliente = c.Int(),
                    })
                .PrimaryKey(t => t.pkVenta)
                .ForeignKey("dbo.Clientes", t => t.cliente_pkCliente)
                .Index(t => t.cliente_pkCliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "cliente_pkCliente", "dbo.Clientes");
            DropIndex("dbo.Ventas", new[] { "cliente_pkCliente" });
            DropTable("dbo.Ventas");
        }
    }
}
