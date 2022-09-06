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
    public class ShipperSeed : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasData(
                new Shipper
                {
                    Id=1,
                    Name="UPS",
                    Phone="1231212"
                },
                new Shipper
                {
                    Id = 2,
                    Name = "FedEx",
                    Phone = "12312122331"
                },
                new Shipper
                {
                    Id = 3,
                    Name = "PTT",
                    Phone = "35415123"
                }
                );
        }
    }
}
