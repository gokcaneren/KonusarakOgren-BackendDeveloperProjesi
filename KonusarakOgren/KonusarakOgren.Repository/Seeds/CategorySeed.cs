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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id=1,
                    Name="Phone",
                    Description="sdcaswcdea",
                    CreatedDate=DateTime.Now,
                },
                new Category
                {
                    Id = 2,
                    Name = "Tv",
                    Description = "sdcaswcdea",
                    CreatedDate = DateTime.Now,
                },
                new Category
                {
                    Id = 3,
                    Name = "Laptop",
                    Description = "sdcaswcdea",
                    CreatedDate = DateTime.Now,
                }, 
                new Category
                {
                    Id = 4,
                    Name = "Whiteware",
                    Description = "sdcaswcdea",
                    CreatedDate = DateTime.Now,
                }
                );
        }
    }
}
