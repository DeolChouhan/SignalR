namespace SigalRApp.Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DevTests", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DevTests", "Address", c => c.String());
        }
    }
}
