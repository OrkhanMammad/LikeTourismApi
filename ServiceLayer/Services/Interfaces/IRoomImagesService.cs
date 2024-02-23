using ServiceLayer.DTOs.RoomImages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IRoomImagesService
    {
        Task<List<RoomImagesDto>> GetAllAsync(int id);
        Task InsertAsync(CreateRoomImageDto roomImageDto);

        Task<RoomImagesDto> GetAsync(int id);
        Task DeleteAsync(int id);



    }
}
