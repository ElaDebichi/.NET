using ED.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace ED.Data.Configurations
{
    public class ChemicalConfiguration : IEntityTypeConfiguration<Chemical>
    {
        public void Configure(EntityTypeBuilder<Chemical> builder)
        {
            //throw new NotImplementedException();
            builder.OwnsOne(c => c.Adress, p =>
            {
                p.Property(p => p.City).HasColumnName("MyCity").HasMaxLength(50).IsRequired();
                p.Property(p => p.StreetAdress).HasColumnName("MyAdress").HasMaxLength(50).IsRequired();
            });
        }
    }
}
