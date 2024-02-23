using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.HotelDescription;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HotelDescriptionService : IHotelDescriptionService
    {

        private readonly IHotelDescriptionRepository _repository;
        private readonly IMapper _mapper;

        public HotelDescriptionService(IHotelDescriptionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            var hotel = await _repository.GetDescAsync(id);
            await _repository.DeleteAsync(hotel);
        }

        public async Task<List<HotelDescriptionDto>> GetAllAsync(int id)
        {
            var result = await _repository.FindAsync(m => m.HotelListId == id);

            return _mapper.Map<List<HotelDescriptionDto>>(result);
        }

        public async Task<HotelDescriptionDto> GetAsync(int id)
        {
            var model = await _repository.FindAsync(m => m.HotelListId == id);
            var result = _mapper.Map<HotelDescriptionDto>(model);
            return result;
        }

        public async Task InsertAsync(HotelDescriptionCreateDto hotelDescription)
        {
            await _repository.CreateAsync(_mapper.Map<HotelDescription>(hotelDescription));

        }

        public async Task UpdateAsync(int id, HotelDescriptionEditDto hotelDescription)
        {
            var entity = await _repository.GetAsync(id);
            _mapper.Map(hotelDescription, entity);
            await _repository.UpdateAsync(entity);
        }
    }
}
