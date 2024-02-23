using ServiceLayer.DTOs.HouseRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHouseRoomService
    {
        Task<List<HouseRoomDto>> GetAllAsync(int id);

        Task InsertAsync(HouseRoomCreateDto houseRoom);
        Task<HouseRoomDto> GetAsync(int id);

        Task DeleteAsync(int id);
        Task UpdateAsync(int id, HouseRoomEditDto houseRoom);


    }
}
