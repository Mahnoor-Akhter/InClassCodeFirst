namespace InClassCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InClassCodeFirst.TeamData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "InClassCodeFirst.TeamData";
        }

        protected override void Seed(InClassCodeFirst.TeamData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
