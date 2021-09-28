using DIO.AvaCloud.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace DIO.AvaCloud.Infra.InitializeDB
{
    public static class Init
    {
        public static void InitDb(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    Description = "Notebook Dell G7 32GB 1TB SSD",
                    Price = 15000,
                    ProductName = "Dell G7",
                    Seller = "Dell"
                }
            );
        }
    }
}
