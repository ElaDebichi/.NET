using ED.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ED.Data.Configurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(b => new { b.ClientFk, b.ProductFk, b.Date });
            builder.HasOne(b => b.Product).WithMany(b => b.Bills).HasForeignKey(b => b.ProductFk);
            builder.HasOne(b => b.Client).WithMany(b => b.Bills).HasForeignKey(b => b.ClientFk);
            //builder.HasMany(b => b.Product).WithMany(b => b.Client).UsingEntity(p => p.ToTable());

        }
    }
}
