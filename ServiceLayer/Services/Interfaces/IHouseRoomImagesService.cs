using ServiceLayer.DTOs.HouseRoomImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHouseRoomImagesService
    {
        Task<List<HouseRoomImagesDto>> GetAllAsync(int id);
        Task InsertAsync(CreateHouseRoomImagesDto houseRoomImagesDto);

        Task<HouseRoomImagesDto> GetAsync(int id);
        Task DeleteAsync(int id);
    }
}
