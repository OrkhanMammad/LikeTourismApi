using ServiceLayer.DTOs.HotelList;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHotelListService
    {
        Task<List<HotelListDto>> GetAllAsync(int id);

        Task InsertAsync(HotelListCreateDto hotelList);

        Task<HotelListDto> GetAsync(int id);
        Task UpdateAsync(int id, HotelListEditDto hotelList);

        Task DeleteAsync(int id);

        Task<IEnumerable<HotelListDto>> GetAllNameAsync(string name);






    }
}
