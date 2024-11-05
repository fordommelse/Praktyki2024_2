using CarShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<ProductParts> ProductParts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Define composite key and relationships for ProductParts
            modelBuilder.Entity<ProductParts>()
                .HasKey(pi => new { pi.ProductId, pi.PartId });

            modelBuilder.Entity<ProductParts>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductParts)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductParts>()
                .HasOne(pi => pi.Part)
                .WithMany(i => i.ProductParts)
                .HasForeignKey(pi => pi.ProductId);

            //Seed Data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Bolide" },
                new Category { CategoryId = 2, Name = "Forklift" },
                new Category { CategoryId = 3, Name = "Truck" },
                new Category { CategoryId = 4, Name = "To be added" },
                new Category { CategoryId = 5, Name = "To be added" }
                );

            modelBuilder.Entity<Part>().HasData(
                //add parts here
                new Part { PartId = 1, Name = "Owner's Manual" },
                new Part { PartId = 2, Name = "Spare Tire" },
                new Part { PartId = 3, Name = "Tool Kit" },
                new Part { PartId = 4, Name = "2003 Jaguar R4 Race Data Logger" },
                new Part { PartId = 5, Name = "Toyota Forklift Load Backrest" },
                new Part { PartId = 6, Name = "2018 Volvo VNL 300 DayCab Tractor Truck Fleet Management Software" }
                );

            modelBuilder.Entity<Product>().HasData(

                //add products here
                new Product
                {
                    ProductId = 1,
                    Name = "2003 Jaguar R4",
                    Description = "Own a piece of Formula 1 history with the 2003 Jaguar R4—an iconic, limited-production race car with stunning performance pedigree, once driven by Mark Webber and meticulously designed to embody Jaguar Racing’s relentless pursuit of speed and innovation.",
                    Price = 112000,
                    Stock = 1,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Toyota Forklift",
                    Description = "Invest in unmatched reliability and efficiency with a Toyota forklift, renowned for its durability, precision handling, and built to elevate productivity in any industrial setting.",
                    Price = 25000,
                    Stock = 143575,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 3,
                    Name = "2018 Volvo VNL 300 DayCab Tractor Truck",
                    Description = "The 2018 Volvo VNL 300 DayCab Tractor Truck offers powerful performance and driver comfort, featuring fuel-efficient technology, advanced safety features, and a spacious cab ideal for regional haul and short-haul operations.",
                    Price = 70000,
                    Stock = 2469,
                    CategoryId = 3
                }
                );

            modelBuilder.Entity<ProductParts>().HasData(
                new ProductParts { ProductId = 1, PartId = 1},
                new ProductParts { ProductId = 1, PartId = 2},
                new ProductParts { ProductId = 1, PartId = 3},
                new ProductParts { ProductId = 1, PartId = 4},
                new ProductParts { ProductId = 2, PartId = 1},
                new ProductParts { ProductId = 2, PartId = 2},
                new ProductParts { ProductId = 2, PartId = 3},
                new ProductParts { ProductId = 2, PartId = 5},
                new ProductParts { ProductId = 3, PartId = 1},
                new ProductParts { ProductId = 3, PartId = 2},
                new ProductParts { ProductId = 3, PartId = 3},
                new ProductParts { ProductId = 3, PartId = 6}

                );
            }
    }
}
