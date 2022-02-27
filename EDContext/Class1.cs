using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.

using ED.domain;
namespace EDContext
{
    public class EDContext : DbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Chemical> Chemicals { get; set; }
        DbSet<Biological> Biologicals { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Provider> Providers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer
        }
    }
}
