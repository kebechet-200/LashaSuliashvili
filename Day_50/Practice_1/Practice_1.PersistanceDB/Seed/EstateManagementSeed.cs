using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Practice_1.PersistanceDB.Context;
using Practice1.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1.PersistanceDB.Seed
{
    public static class EstateManagementSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var database = scope.ServiceProvider.GetRequiredService<EstateManagementContext>();

            SeedEverything(database);
            Migrate(database);
        }

        private static void SeedEverything(EstateManagementContext context)
        {
            var seeded = false;
            SeedEstate(context, ref seeded);
            SeedAccounts(context, ref seeded);

            if (seeded)
                context.SaveChanges();
        }

        private static void Migrate(EstateManagementContext context)
        {
            context.Database.Migrate();
        }

        private static void SeedEstate(EstateManagementContext context, ref bool seeded)
        {
            var estate = new List<RealEstate>()
            {
                new RealEstate()
                {
                    Owner = "Lasha Suliashvili",
                    Address = "მარჯანიშვილის #4",
                    Price = 2500,
                    Identifier = "IDWA-412-DWAF4-921VB"
                },
                new RealEstate()
                {
                    Owner = "Luka Sharashelidze",
                    Address = "ლეონიძის #4",
                    Price = 3000,
                    Identifier = "PW5B-412E-GWQ5-HAZ3"
                }
            };

            foreach (var item in estate)
            {
                if (context.RealEstates.AnyAsync(x => x.Identifier == item.Identifier).Result) continue;

                context.RealEstates.Add(item);
            }
            seeded = true;
        }

        private static void SeedAccounts(EstateManagementContext context, ref bool seeded)
        {
            var accounts = new List<Account>
            {
                new Account
                {
                    Username = "lasha917",
                    Password = "12345678"
                },

                new Account
                {
                    Username = "gio917",
                    Password = "87654321"
                }
            };

            foreach (var item in accounts)
            {
                if (context.Accounts.AnyAsync(x => x.Username == item.Username).Result) continue;

                context.Accounts.Add(item);
            }
            seeded = true;
        }
    }
}
