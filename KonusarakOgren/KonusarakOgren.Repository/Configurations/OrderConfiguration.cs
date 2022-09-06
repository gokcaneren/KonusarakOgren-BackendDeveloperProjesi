using KonusarakOgren.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Repository.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OrderDate).HasColumnType("datetime");

            builder.HasOne(x => x.Shipper)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.ShipperId);

            builder.HasOne(x=>x.Customer)
                .WithMany(x=>x.Orders)
                .HasForeignKey(x=>x.CustomerId);
        }
    }
}
