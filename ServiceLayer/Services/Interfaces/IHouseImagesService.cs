using ServiceLayer.DTOs.HouseImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHouseImagesService
    {
        Task<List<HouseImagesDto>> GetAllAsync(int id);
        Task InsertAsync(HouseImagesCreateDto house);

        Task<HouseImagesDto> GetAsync(int id);

        Task DeleteAsync(int id);
    }
}
