namespace prueba1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblRegistroAnimales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaseAnimal = c.String(nullable: false),
                        Raza = c.String(nullable: false),
                        Edad = c.Int(nullable: false),
                        Color = c.String(nullable: false),
                        Estatura = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblRegistroDueño",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Calle = c.Int(nullable: false),
                        Ciudad = c.String(nullable: false),
                        Telefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblRegistroPersonal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        DocumentoIdentificacion = c.Int(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                        Edad = c.Int(nullable: false),
                        Especialidad = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblRegistroPersonal");
            DropTable("dbo.tblRegistroDueño");
            DropTable("dbo.tblRegistroAnimales");
        }
    }
}
