using ED.domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace ED.Service
{
    public class Context : DbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Provider> Providers { get; set; }
        DbSet<Chemical> Chemicals { get; set; }
        DbSet<Biological> Biologicals { get; set; }
        DbSet<Category> Categories { get; set; }

        public Context()
        {
           // Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source = (localdb)\MSSQLlocalDB;initial catalog=ProductStore;Integrated Security = True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
