using DomainLayer.Configurations;
using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FamousCityConfiguration());
            modelBuilder.ApplyConfiguration(new HotelListConfiguration());
            modelBuilder.ApplyConfiguration(new SliderConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new HouseConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new RoomImagesConfiguration());
            modelBuilder.ApplyConfiguration(new HotelListImagesConfiguration());
            modelBuilder.ApplyConfiguration(new HotelDescriptionConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfigration());
            modelBuilder.ApplyConfiguration(new HouseImagesConfiguration());
            modelBuilder.ApplyConfiguration(new HouseRoomConfiguration());
            modelBuilder.ApplyConfiguration(new HouseRoomImagesConfiguration());
            modelBuilder.ApplyConfiguration(new VillaConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
