namespace prueba1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregandoElSegundoIntARegistroDueños : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.tblRegistroDueño", name: "tblRegistroPersonal_Id", newName: "tblRegistroPersonalId");
            RenameIndex(table: "dbo.tblRegistroDueño", name: "IX_tblRegistroPersonal_Id", newName: "IX_tblRegistroPersonalId");
            DropColumn("dbo.tblRegistroDueño", "tblRegistroPersonalEspecialidad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblRegistroDueño", "tblRegistroPersonalEspecialidad", c => c.Int());
            RenameIndex(table: "dbo.tblRegistroDueño", name: "IX_tblRegistroPersonalId", newName: "IX_tblRegistroPersonal_Id");
            RenameColumn(table: "dbo.tblRegistroDueño", name: "tblRegistroPersonalId", newName: "tblRegistroPersonal_Id");
        }
    }
}
