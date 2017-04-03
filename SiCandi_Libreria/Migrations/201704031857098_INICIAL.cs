namespace SiCandi_Libreria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidatas",
                c => new
                    {
                        pkCandida = c.Int(nullable: false, identity: true),
                        dAnioConvocatoria = c.DateTime(nullable: false, precision: 0),
                        sNombreCompleto = c.String(unicode: false),
                        dFechaNacimiento = c.DateTime(nullable: false, precision: 0),
                        sDescripcion = c.String(unicode: false),
                        sEmail = c.String(unicode: false),
                        sCurp = c.String(unicode: false),
                        sFotografia = c.String(unicode: false),
                        iLike = c.Int(nullable: false),
                        bStatus = c.Boolean(nullable: false),
                        fkMunicipio_pkMunicipio = c.Int(),
                        fkUsuario_pkUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.pkCandida)
                .ForeignKey("dbo.Municipios", t => t.fkMunicipio_pkMunicipio)
                .ForeignKey("dbo.Usuarios", t => t.fkUsuario_pkUsuario)
                .Index(t => t.fkMunicipio_pkMunicipio)
                .Index(t => t.fkUsuario_pkUsuario);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        pkMunicipio = c.Int(nullable: false, identity: true),
                        sMunicipio = c.String(unicode: false),
                        sLogotipo = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkMunicipio);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        pkUsuario = c.Int(nullable: false, identity: true),
                        iNoEmpleado = c.Int(nullable: false),
                        sContrasena = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        fkRol_pkUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.pkUsuario)
                .ForeignKey("dbo.Roles", t => t.fkRol_pkUsuario)
                .Index(t => t.fkRol_pkUsuario);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        pkUsuario = c.Int(nullable: false, identity: true),
                        iNoEmpleado = c.Int(nullable: false),
                        sContrasena = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkUsuario);
            
            CreateTable(
                "dbo.PermisosNegadosRol",
                c => new
                    {
                        pkPermisoNegadoRol = c.Int(nullable: false, identity: true),
                        fkPrmiso_pkPermiso = c.Int(),
                        fkRol_pkUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.pkPermisoNegadoRol)
                .ForeignKey("dbo.Permisos", t => t.fkPrmiso_pkPermiso)
                .ForeignKey("dbo.Roles", t => t.fkRol_pkUsuario)
                .Index(t => t.fkPrmiso_pkPermiso)
                .Index(t => t.fkRol_pkUsuario);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        pkPermiso = c.Int(nullable: false, identity: true),
                        sModulo = c.String(unicode: false),
                        sDescripcion = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.pkPermiso);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "fkRol_pkUsuario", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegadosRol", "fkRol_pkUsuario", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegadosRol", "fkPrmiso_pkPermiso", "dbo.Permisos");
            DropForeignKey("dbo.Candidatas", "fkUsuario_pkUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Candidatas", "fkMunicipio_pkMunicipio", "dbo.Municipios");
            DropIndex("dbo.PermisosNegadosRol", new[] { "fkRol_pkUsuario" });
            DropIndex("dbo.PermisosNegadosRol", new[] { "fkPrmiso_pkPermiso" });
            DropIndex("dbo.Usuarios", new[] { "fkRol_pkUsuario" });
            DropIndex("dbo.Candidatas", new[] { "fkUsuario_pkUsuario" });
            DropIndex("dbo.Candidatas", new[] { "fkMunicipio_pkMunicipio" });
            DropTable("dbo.Permisos");
            DropTable("dbo.PermisosNegadosRol");
            DropTable("dbo.Roles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Municipios");
            DropTable("dbo.Candidatas");
        }
    }
}
