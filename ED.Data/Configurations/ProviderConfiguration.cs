using ED.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ED.Data.Configurations
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)        {
            builder.Property((p) => p.Nom).HasMaxLength(20).IsRequired().HasDefaultValue("Username").HasColumnName("Name");
            builder.HasKey(p => p.Id);
            builder.Ignore(p => p.ConfirmPassword);
            builder.ToTable("Provider");
            builder.HasMany(p => p.products).WithMany(p => p.providers).UsingEntity(p => p.ToTable("Providings"));

        }
    }
}
