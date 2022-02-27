using ED.domain;
using Microsoft.EntityFrameworkCore;
using System;


namespace ED.Service
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Category> Categories { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllodcaldb;Initial Catalog=GestionCompteDB;Integrated Security=true");
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=master;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
