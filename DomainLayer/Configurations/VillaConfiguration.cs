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
    public class VillaConfiguration : IEntityTypeConfiguration<Villa>
    {
        public void Configure(EntityTypeBuilder<Villa> builder)
        {
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.Name).IsRequired();
            builder.Property(m => m.Location).IsRequired();
            builder.Property(m => m.Rating).IsRequired();
            builder.Property(m => m.RatingText).IsRequired();
            builder.Property(m => m.Desc).IsRequired();
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
        }
    }
}
