namespace SigalRApp.Migration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SigalRApp.Models.DevTestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(SigalRApp.Models.DevTestContext context)
        {
            //DataInitialization.DataInitializer.Initialize(context);
            //context.SaveChanges();
        }

    }
}