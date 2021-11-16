namespace prueba1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiandonotacionesyrelacionandotablas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegistroDueño", "tblRegistroPersonalEspecialidad", c => c.Int());
            AddColumn("dbo.tblRegistroDueño", "tblRegistroPersonal_Id", c => c.Int());
            CreateIndex("dbo.tblRegistroDueño", "tblRegistroPersonal_Id");
            AddForeignKey("dbo.tblRegistroDueño", "tblRegistroPersonal_Id", "dbo.tblRegistroPersonal", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblRegistroDueño", "tblRegistroPersonal_Id", "dbo.tblRegistroPersonal");
            DropIndex("dbo.tblRegistroDueño", new[] { "tblRegistroPersonal_Id" });
            DropColumn("dbo.tblRegistroDueño", "tblRegistroPersonal_Id");
            DropColumn("dbo.tblRegistroDueño", "tblRegistroPersonalEspecialidad");
        }
    }
}
