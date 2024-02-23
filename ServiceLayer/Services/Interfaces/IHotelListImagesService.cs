using ServiceLayer.DTOs.HotelListImages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHotelListImagesService
    {
        Task<List<HotelListImagesDto>> GetAllAsync(int id);
        Task InsertAsync(CreateHotelListImagesDto createHotel);

        Task<HotelListImagesDto> GetAsync(int id);

        Task DeleteAsync(int id);

        Task UpdateAsync(int id, HotelListImagesEditDto hotelList);

    }
}
