using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SigalRApp.Models
{
    public class DevTestContext : DbContext
    {
        public DevTestContext(): base("dbConnectionString")
        {
            Database.SetInitializer<DevTestContext>(new CreateDatabaseIfNotExists<DevTestContext>());
        }
        public DbSet<DevTest> DevTests { get; set; }
    }
}