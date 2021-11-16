namespace prueba1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregandoDateTimeEnRegistroAnimales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegistroAnimales", "FechaCita", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblRegistroAnimales", "FechaCita");
        }
    }
}
