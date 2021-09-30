using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using CustomMethodBenjamin.Models.ConData;

namespace CustomMethodBenjamin.Data
{
  public partial class ConDataContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public ConDataContext(DbContextOptions<ConDataContext> options):base(options)
    {
    }

    public ConDataContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<CustomMethodBenjamin.Models.ConData.Product>()
              .HasOne(i => i.ProductCategory)
              .WithMany(i => i.Products)
              .HasForeignKey(i => i.CategoryID)
              .HasPrincipalKey(i => i.CategoryID);


        builder.Entity<CustomMethodBenjamin.Models.ConData.Product>()
              .Property(p => p.ProductID)
              .HasPrecision(19, 0);

        builder.Entity<CustomMethodBenjamin.Models.ConData.Product>()
              .Property(p => p.CategoryID)
              .HasPrecision(19, 0);

        builder.Entity<CustomMethodBenjamin.Models.ConData.Product>()
              .Property(p => p.UnitPrice)
              .HasPrecision(18, 2);

        builder.Entity<CustomMethodBenjamin.Models.ConData.ProductCategory>()
              .Property(p => p.CategoryID)
              .HasPrecision(19, 0);
        this.OnModelBuilding(builder);
    }


    public DbSet<CustomMethodBenjamin.Models.ConData.Product> Products
    {
      get;
      set;
    }

    public DbSet<CustomMethodBenjamin.Models.ConData.ProductCategory> ProductCategories
    {
      get;
      set;
    }
  }
}
