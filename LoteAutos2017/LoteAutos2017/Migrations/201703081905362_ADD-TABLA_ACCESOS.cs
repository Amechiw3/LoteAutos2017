namespace LoteAutos2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDTABLA_ACCESOS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accesos",
                c => new
                    {
                        pkAcceso = c.Int(nullable: false, identity: true),
                        dFecha = c.DateTime(nullable: false, precision: 0),
                        usuario_pkUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.pkAcceso)
                .ForeignKey("dbo.Usuarios", t => t.usuario_pkUsuario)
                .Index(t => t.usuario_pkUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accesos", "usuario_pkUsuario", "dbo.Usuarios");
            DropIndex("dbo.Accesos", new[] { "usuario_pkUsuario" });
            DropTable("dbo.Accesos");
        }
    }
}
