using ServiceLayer.DTOs.FamousCity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IFamousCityService
    {
        Task<List<FamousCityListDto>> GetAllAsync();

        Task InsertAsync(FamousCityCreateDto famousCity);

        Task UpdateAsync(int id, FamousCityEditDto famousCity);

        Task DeleteAsync(int id);

        Task<FamousCityListDto> GetAsync(int id);

        Task<IEnumerable<FamousCityDto>> GetCityNameAsync(string name);

    }
}
