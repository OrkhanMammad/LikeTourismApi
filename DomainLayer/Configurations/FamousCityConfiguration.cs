using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DomainLayer.Configurations
{
    public class FamousCityConfiguration : IEntityTypeConfiguration<FamousCity>
    {
        public void Configure(EntityTypeBuilder<FamousCity> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);

        }
    }
}
