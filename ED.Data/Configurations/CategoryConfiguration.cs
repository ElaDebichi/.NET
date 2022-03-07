using ED.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ED.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder.ToTable("Category");
            builder.HasKey(c => c.categoryId);
            builder.Property((c) => c.name).HasMaxLength(50).IsRequired();
            builder.HasMany<Product>(c=>c.products).WithOne(p=>p.category).HasForeignKey(p=>p.CategoryId);
           




        }
    }
}
