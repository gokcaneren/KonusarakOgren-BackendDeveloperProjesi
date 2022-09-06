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
    public class OderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => new {x.OrderId, x.ProductId});
            builder.ToTable("Order Details");
            builder.Property(x=>x.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.Quantity).HasDefaultValueSql("((1))");

            builder.Property(x => x.OrderId).HasColumnName("OrderID");
            builder.Property(x => x.ProductId).HasColumnName("ProductID");

            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
