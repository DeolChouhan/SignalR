namespace SigalRApp.Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DevTests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CampaignName = c.String(),
                        Date = c.DateTime(),
                        Conversions = c.String(),
                        Impressions = c.String(),
                        AffiliateName = c.String(),
                        Clicks = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DevTests");
        }
    }
}
