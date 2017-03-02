namespace SigalRApp.Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DevTests", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DevTests", "Address");
        }
    }
}
