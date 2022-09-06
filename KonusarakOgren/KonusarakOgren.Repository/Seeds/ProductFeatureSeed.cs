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
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {
                    Id = 1,
                    Color="Black",
                    Height=122,
                    Width=57,
                    ProductId=1
                },
                new ProductFeature
                {
                     Id = 2,
                     Color = "White",
                     Height = 20,
                     Width = 10,
                     ProductId=2
                },
                new ProductFeature
                {
                     Id = 3,
                     Color = "Silver",
                     Height = 50,
                     Width = 45,
                     ProductId = 3
                }
                );
        }
    }
}
