using DIO.AvaCloud.Domain;
using DIO.AvaCloud.Infra.InitializeDB;
using Microsoft.EntityFrameworkCore;

namespace DIO.AvaCloud.Infra.Context
{
    public class AvaCloudDB : DbContext
    {
        public AvaCloudDB(DbContextOptions<AvaCloudDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.InitDb();
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
