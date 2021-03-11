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

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<StoreLocation> StoreLocation { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartProd> CartProd { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
               .Property(Customer => Customer.Id)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Cart>()
               .Property(x => x.Id)
               .ValueGeneratedOnAdd();

            //modelBuilder.Entity<LocationProduct>()
            //.Property(x => x.ID)
            //.ValueGeneratedOnAdd();

            modelBuilder.Entity<StoreLocation>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            //modelBuilder.Entity<OrderProducts>()
            //.Property(x => x.ID)
            //.ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}