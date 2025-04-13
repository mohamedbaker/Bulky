using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BulkyApp.Models;

namespace BulkyApp.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        // public DbSet<Product> Products { get; set; }
        // public DbSet<CoverType> CoverTypes { get; set; }
        // public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        // public DbSet<OrderHeader> OrderHeaders { get; set; }
        // public DbSet<OrderDetail> OrderDetails { get; set; }
        // public DbSet<Company> Companies { get; set; }
        // public DbSet<ApplicationUser> ApplicationUsers { get; set; } 
        
    }
}