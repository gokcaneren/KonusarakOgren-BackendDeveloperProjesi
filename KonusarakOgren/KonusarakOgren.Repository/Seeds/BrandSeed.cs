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
    public class BrandSeed : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand
                {
                    Id=1,
                    Name="Vestel",
                    Country="Turkey",
                },
                new Brand
                {
                    Id = 2,
                    Name = "Samsung",
                    Country = "S.Korea",
                },
                new Brand
                {
                    Id = 3,
                    Name = "Apple",
                    Country = "USA",
                },
                new Brand
                {
                    Id = 4,
                    Name = "Bosch",
                    Country = "Germany",
                }
                );
        }
    }
}
