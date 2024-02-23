using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IFamousCityRepository, FamousCityRepository>();
            services.AddScoped<IHotelListRepository, HotelListRepository>();
            services.AddScoped<ISliderRepository, SliderRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IHouseRepository, HouseRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IRoomImagesRepository, RoomImagesRepository>();
            services.AddScoped<IHotelListImagesRepository, HotelListImagesRepository>();
            services.AddScoped<IHotelDescriptionRepository, HotelDescriptionRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IHouseImagesRepository, HouseImagesRepository>();
            services.AddScoped<IHouseRoomRepository, HouseRoomRepository>();
            services.AddScoped<IHouseRoomImagesRepository, HouseRoomImagesRepository>();
            services.AddScoped<IVillaRepository, VillaRepository>();











            return services;
        }
    }
}
