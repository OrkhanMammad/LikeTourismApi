using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configurations
{
    public class HouseRoomConfiguration : IEntityTypeConfiguration<HouseRoom>
    {
        public void Configure(EntityTypeBuilder<HouseRoom> builder)
        {

            builder.Property(m => m.RoomType).IsRequired();
            builder.Property(m => m.Image).IsRequired();

            builder.Property(m => m.RoomPrise).IsRequired();
            builder.Property(m => m.Remained).IsRequired();
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}
