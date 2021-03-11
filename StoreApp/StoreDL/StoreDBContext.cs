using Microsoft.EntityFrameworkCore;
using System;
using StoreModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions options) : base(options)
        {
        }

        protected StoreDBContext()
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StoreLocation> StoreLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Order>()
                .HasOne(Order => Order.CustID)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Customer>(c => c.Id);
            modelBuilder.Entity<Order>()
                .HasOne(Order => Order.LocID)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey<StoreLocation>(l => l.Id);
            modelBuilder.Entity<Order>()
                .HasOne(Order => Order.ProID)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Product>(p => p.Id);

            modelBuilder.Entity<Product>()
                .HasOne(Order => Order.LocationID)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<StoreLocation>(l => l.Id);*/

            modelBuilder.Entity<Customer>()
               .Property(Customer => Customer.Id)
               .ValueGeneratedOnAdd();
        }
    }
}