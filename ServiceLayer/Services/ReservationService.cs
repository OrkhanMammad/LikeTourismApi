using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Reservation;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class ReservationService : IReservationService
    {

        private readonly IReservationRepository _repository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {

            var hotel = await _repository.GetAsync(id);
            await _repository.DeleteAsync(hotel);
        }

        public async Task<List<ReservationDto>> GetAllAsync(int id)
        {
            var result = await _repository.FindAsync(m => m.HotelListId == id);

            return _mapper.Map<List<ReservationDto>>(result);
        }

        public async Task<ReservationDto> GetAsync(int id)
        {
            var model = await _repository.GetReservationAsync(id);
            var result = _mapper.Map<ReservationDto>(model);
            return result;
        }

        public async Task InsertAsync(ReservationCreateDto reservation)
        {
            await _repository.CreateAsync(_mapper.Map<Reservation>(reservation));

        }

        public async Task UpdateAsync(int id, ReservationEditDto reservation)
        {
            var entity = await _repository.GetAsync(id);
            _mapper.Map(reservation, entity);
            await _repository.UpdateAsync(entity);
        }
    }
}
