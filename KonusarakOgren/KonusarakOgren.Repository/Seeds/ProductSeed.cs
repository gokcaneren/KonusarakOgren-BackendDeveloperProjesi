using KonusarakOgren.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id=1,
                    Name="V13c",
                    Stock=23,
                    Price=250,
                    CategoryId=2,
                    BrandId=1
                },
                 new Product
                 {
                     Id = 2,
                     Name = "Samsung Galaxy S10",
                     Stock = 32,
                     Price = 100,
                     CategoryId = 1,
                     BrandId = 2
                 },
                  new Product
                  {
                      Id = 3,
                      Name = "Coffee Maker",
                      Stock = 12,
                      Price = 48,
                      CategoryId = 4,
                      BrandId = 4
                  }
                );
        }
    }
}
