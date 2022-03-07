using System;
using System.Collections.Generic;
using System.Text;
using ED.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ED.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //builder.ToTable("Product");
            builder.HasOne(p => p.category).WithMany(c => c.products).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.SetNull); //.Cascade
            builder.HasDiscriminator<int>("type").HasValue<Product>(0).HasValue<Biological>(1).HasValue<Chemical>(2);
            
        }
    }
}