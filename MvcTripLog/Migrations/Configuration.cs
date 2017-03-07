using MvcTripLog.Models;

namespace MvcTripLog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcTripLog.Models.TripDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcTripLog.Models.TripDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Trips.AddOrUpdate(i => i.Title,
            new Trip
            {
                Title = "When Harry Met Sally",
                TravelDate = DateTime.Parse("1989-1-11"),
                Region = "Romantic Comedy",
                Price = 7.99M
            },

            new Trip
            {
                Title = "Ghostbusters ",
                TravelDate = DateTime.Parse("1984-3-13"),
                Region = "Comedy",
                Price = 8.99M
            },

            new Trip
            {
                Title = "Ghostbusters 2",
                TravelDate = DateTime.Parse("1986-2-23"),
                Region = "Comedy",
                Price = 9.99M
            },

            new Trip
            {
                Title = "Rio Bravo",
                TravelDate = DateTime.Parse("1959-4-15"),
                Region = "Western",
                Price = 3.99M
            }
            );
        }
    }
}
