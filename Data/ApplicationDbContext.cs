using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Action",
                        DisplayOrder = 1,
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Science Fiction",
                        DisplayOrder = 2,
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Romance",
                        DisplayOrder = 3,
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "Horror",
                        DisplayOrder = 4,
                    }
                );
        }
        // public DbSet<Product> Products { get; set; }
        // public DbSet<CoverType> CoverTypes { get; set; }
        // public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        // public DbSet<OrderHeader> OrderHeaders { get; set; }
        // public DbSet<OrderDetail> OrderDetails { get; set; }
        // public DbSet<Company> Companies { get; set; }
        // public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
