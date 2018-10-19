namespace RentCar_1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RentCar_1.Models.RentCarContext>
    {
        public Configuration()
        {
            //alterar base de datos automaticamente (default: false)
            AutomaticMigrationsEnabled = true; 
        }

        protected override void Seed(RentCar_1.Models.RentCarContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
