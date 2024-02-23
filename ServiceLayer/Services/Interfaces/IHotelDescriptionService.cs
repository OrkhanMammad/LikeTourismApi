using ServiceLayer.DTOs.HotelDescription;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHotelDescriptionService
    {

        Task<List<HotelDescriptionDto>> GetAllAsync(int id);
        Task InsertAsync(HotelDescriptionCreateDto hotelDescription);
        Task UpdateAsync(int id, HotelDescriptionEditDto hotelDescription);

        Task<HotelDescriptionDto> GetAsync(int id);
        Task DeleteAsync(int id);




    }
}
