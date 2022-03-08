using Microsoft.EntityFrameworkCore;
using Practice1.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1.PersistanceDB.Context
{
    public class EstateManagementContext : DbContext
    {
        public EstateManagementContext(DbContextOptions<EstateManagementContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<RealEstate> RealEstates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(EstateManagementContext).Assembly);
        }
    }
}
