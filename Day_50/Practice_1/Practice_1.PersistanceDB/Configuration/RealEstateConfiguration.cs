using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice1.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1.PersistanceDB.Configuration
{
    public class RealEstateConfiguration : IEntityTypeConfiguration<RealEstate>
    {
        public void Configure(EntityTypeBuilder<RealEstate> builder)
        {
            builder.HasIndex(x => x.Id).IsUnique();

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Address).IsRequired().HasMaxLength(25);

            builder.Property(x => x.Owner).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Price);

            builder.Property(x => x.Identifier).IsRequired().HasMaxLength(30).IsFixedLength();

        }
    }
}
