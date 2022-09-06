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
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id=1,
                    Name="Wallace",
                    Address="England London",
                },
                new Customer
                {
                    Id = 2,
                    Name = "Ali",
                    Address = "Turkey Ankara",
                }, new Customer
                {
                    Id = 3,
                    Name = "France",
                    Address = "Lyon",
                }
                );
        }
    }
}
