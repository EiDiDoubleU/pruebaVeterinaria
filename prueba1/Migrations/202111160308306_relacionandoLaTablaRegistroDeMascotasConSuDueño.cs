namespace prueba1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionandoLaTablaRegistroDeMascotasConSuDueño : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegistroAnimales", "tblRegistroDueñoId", c => c.Int());
            CreateIndex("dbo.tblRegistroAnimales", "tblRegistroDueñoId");
            AddForeignKey("dbo.tblRegistroAnimales", "tblRegistroDueñoId", "dbo.tblRegistroDueño", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblRegistroAnimales", "tblRegistroDueñoId", "dbo.tblRegistroDueño");
            DropIndex("dbo.tblRegistroAnimales", new[] { "tblRegistroDueñoId" });
            DropColumn("dbo.tblRegistroAnimales", "tblRegistroDueñoId");
        }
    }
}
