using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DomainLayer.Configurations
{
    public class HotelListConfiguration : IEntityTypeConfiguration<HotelList>
    {
        public void Configure(EntityTypeBuilder<HotelList> builder)
        {
            builder.Property(m => m.Image);
            builder.Property(m => m.Name).HasMaxLength(150);
            builder.Property(m => m.Distance);
            builder.Property(m => m.Desc).HasMaxLength(300);
            builder.Property(m => m.Rating);
            builder.Property(m => m.RatingTitle);
            builder.Property(m => m.Star);
            builder.Property(m => m.Prise);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}
