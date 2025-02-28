﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
{
    public void Configure(EntityTypeBuilder<SaleItem> builder)
    {
        builder.ToTable("SaleItems");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.HasOne(si => si.Sale)
           .WithMany(s => s.Items)
           .HasForeignKey(si => si.SaleId);

        builder.HasOne(si => si.Product)
               .WithMany()
               .HasForeignKey(si => si.ProductId);

        builder.Property(si => si.UnitPrice).HasColumnType("decimal(18,2)");
        builder.Property(si => si.Discount).HasColumnType("decimal(18,2)");
        builder.Property(si => si.TotalPrice).HasColumnType("decimal(18,2)");
    }
}
