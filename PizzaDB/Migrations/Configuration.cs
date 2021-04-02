using System.Data.Entity.Migrations;

namespace PizzaDB.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PizzaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}