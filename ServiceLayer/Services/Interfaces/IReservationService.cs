using ServiceLayer.DTOs.Reservation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IReservationService
    {
        Task<List<ReservationDto>> GetAllAsync(int id);

        Task InsertAsync(ReservationCreateDto reservation);
        Task<ReservationDto> GetAsync(int id);

        Task DeleteAsync(int id);
        Task UpdateAsync(int id, ReservationEditDto reservation);



    }
}
