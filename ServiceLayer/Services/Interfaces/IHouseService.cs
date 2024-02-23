using ServiceLayer.DTOs.House;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHouseService
    {
        Task<List<HouseListDto>> GetAllAsync();
        Task InsertAsync(HouseCreateDto house);

        Task DeleteAsync(int id);
        Task UpdateAsync(int id, HouseEditDto house);
        Task<HouseListDto> GetAsync(int id);






    }
}
