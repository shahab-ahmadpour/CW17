using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC._Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PU6OMQ0\\SQLEXPRESS;Database=CW17;Integrated Security=true;User ID=sa;Password=P@ssw0rd;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Books" },
                new Category { Id = 3, Name = "Clothes"}
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 1500, CategoryId = 1 },
                new Product { Id = 2, Name = "Headphones", Price = 200, CategoryId = 1 },
                new Product { Id = 3, Name = "C#", Price = 80, CategoryId = 2 },
                new Product { Id = 4, Name = "Jeans", Price = 100, CategoryId = 3}
            );
        }
    }
}
