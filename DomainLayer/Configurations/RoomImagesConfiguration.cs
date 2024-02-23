using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DomainLayer.Configurations
{
    public class RoomImagesConfiguration : IEntityTypeConfiguration<RoomImages>
    {
        public void Configure(EntityTypeBuilder<RoomImages> builder)
        {
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}
