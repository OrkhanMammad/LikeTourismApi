using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DomainLayer.Configurations
{
    public class HotelDescriptionConfiguration : IEntityTypeConfiguration<HotelDescription>
    {
        public void Configure(EntityTypeBuilder<HotelDescription> builder)
        {
            builder.Property(m => m.LongDesc).IsRequired();
            builder.Property(m => m.Breakfast).IsRequired();
            builder.Property(m => m.BreakfastType).IsRequired();
            builder.Property(m => m.Parking).IsRequired();
            builder.Property(m => m.Animal).IsRequired();
            builder.Property(m => m.CheckIn).IsRequired();

            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}
